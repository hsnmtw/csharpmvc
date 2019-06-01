using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.Profile)]
    public partial class ProfileForm: ProfileView {
        const char C = 'C', R = 'R', U = 'U', D = 'D', E = '-';
        private Dictionary<string, List<EntitlementModel>> entitlementsByGroup = new Dictionary<string, List<EntitlementModel>>();
        private Dictionary<int,EntitlementModel> allEntitlements;
        private Dictionary<int, EntitlementGroupModel> entitlementmentGroups;

        public ProfileForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;
            base.Controller = (ProfileController)DBControllersFactory.GetController(Common.MODELS.Profile);

            Controllers = new Dictionary<string, IDBController> {
                ["e" ] = DBControllersFactory.GetController(Common.MODELS.Entitlement),
                ["pe"] = DBControllersFactory.GetController(Common.MODELS.ProfileEntitlement),
                ["eg"] = DBControllersFactory.GetController(Common.MODELS.EntitlementGroup),
            };

            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["ProfileName"] = txtProfileName;
            Mapper["ProfileDesc"] = txtProfileDesc;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }        

        public void RequeryEntitlements() {
            this.lstEntitlements.Items.Clear();
            List<EntitlementModel> filter;
            string eg = $"{this.cmbEntitelmentsGroup.SelectedItem}";
            if ("All".Equals(eg)) {
                filter = allEntitlements.Values.ToList();
            } else if (this.entitlementsByGroup.ContainsKey(eg)) { 
                filter = this.entitlementsByGroup[eg];
            } else {
                filter = new List<EntitlementModel>();
            }
            this.lstEntitlements.Items.AddRange((
                    from ProfileEntitlementModel row
                      in Controllers["pe"].Read(new ProfileEntitlementModel() { ProfileId= Model.Id }, "ProfileId" )
                   where filter.Exists(x => x.Id == row.EntitlementId)
                  select $"{(row.AllowCreate?C:E)}{(row.AllowRead?R:E)}{(row.AllowUpdate?U:E)}{(row.AllowDelete?D:E)}  {allEntitlements[row.EntitlementId].EntitlementName}"
            ).ToArray());
        }

        private void ProfileFormLoad(object sender, EventArgs e) {
            
            cmbEntitelmentsGroup.Items.Clear();
            cmbEntitelmentsGroup.Items.Add("All");
            cmbEntitelmentsGroup.Text = "All";

            allEntitlements = Controllers["e"].Read<EntitlementModel>().ToDictionary(x => x.Id, x => x);

            cmbEntitelmentsGroup.Items.AddRange((
               from eg
               in Controllers["eg"].Read<EntitlementGroupModel>()
               orderby eg.EntitlementGroupName
               select eg.EntitlementGroupName
            ).ToArray());

            entitlementmentGroups = Controllers["eg"].Read<EntitlementGroupModel>().ToDictionary(x => x.Id, x => x);
            
            foreach (var em in Controllers["e"].Read<EntitlementModel>().OrderBy(x => x.EntitlementName)) {
                var egname = entitlementmentGroups[em.EntitlementGroupId].EntitlementGroupName;
                if (entitlementsByGroup.ContainsKey(egname) == false) {
                    entitlementsByGroup[egname] = new List<EntitlementModel>();
                }
                entitlementsByGroup[egname].Add(em);
                allEntitlements.Add(em.Id,em);
            }
        }

        private void CmbEntitelmentsGroup_SelectedIndexChanged(object sender, EventArgs e) {
            RequeryEntitlements();
        }

        private void BtnInitializeEntitlements_Click(object sender, EventArgs e) {
            //remove all existing records for this profile
            foreach (var pemodel in Controllers["pe"].Read(new ProfileEntitlementModel() { ProfileId=Model.Id },"ProfileId")) {
                Controllers["pe"].Delete(pemodel);
            }
            foreach(var entitlement in Controllers["e"].Read<EntitlementModel>()) {
                Controllers["pe"].Save(new ProfileEntitlementModel() {
                    ProfileId = Model.Id,
                    EntitlementId = entitlement.Id,
                    AllowRead = entitlementmentGroups[entitlement.EntitlementGroupId].EntitlementGroupName.Equals("Security") == false
                });
            }
            this.Model = this.Model;
        }

        private void BtnOpen_Click(object sender, EventArgs e) {
            if (this.lstEntitlements.SelectedIndex < 0) return;
            int.TryParse( this.txtId.Text, out int profile);
            string entitlement = $"{this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex]}".Substring(6).Trim();
            int entitlementId = (from EntitlementModel ent in allEntitlements where ent.EntitlementName.Equals(entitlement) select ent).FirstOrDefault().Id;
            var pef = new ProfileEntitlementForm();
            var pem = pef.Controller.Find(new ProfileEntitlementModel() {
                ProfileId = profile,
                EntitlementId = entitlementId
            }, "ProfileName", "EntitlementName" );
            
            pef.Model = pem;
            pef.Show();

        }

        private void ProfileNameLookupLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new ProfileModel() { ProfileName = selected }, "ProfileName");
        }

        private void BtnAllowAll_Click(object sender, EventArgs e) {
            if (this.lstEntitlements.SelectedIndex < 0) return;
            string profile = this.txtProfileName.Text;
            string entitlement = $"{this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex]}".Substring(6).Trim();
            int entitlementId = (from EntitlementModel ent in allEntitlements where ent.EntitlementName.Equals(entitlement) select ent).FirstOrDefault().Id;
            int.TryParse(txtId.Text, out int profileId);
            ((ProfileEntitlementController)Controllers["pe"]).ChangePermissions(profileId, entitlementId, true, true, true, true);
            this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex] = $"{C}{R}{U}{D}  {entitlement}";
            //Utils.FormsHelper.Success("All entitlements were allowed");
            MainView.Instance.setProgress("All entitlements were allowed", 100);
        }

        private void BtnUnallowAll_Click(object sender, EventArgs e) {
            if (this.lstEntitlements.SelectedIndex < 0) return;
            string profile = this.txtProfileName.Text;
            string entitlement = $"{this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex]}".Substring(6).Trim();
            int entitlementId = (from EntitlementModel ent in allEntitlements where ent.EntitlementName.Equals(entitlement) select ent).FirstOrDefault().Id;
            int.TryParse(txtId.Text, out int profileId);

            ((ProfileEntitlementController)Controllers["pe"]).ChangePermissions(profileId, entitlementId, false, false, false, false);
            this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex] = $"{E}{E}{E}{E}  {entitlement}";
            //Utils.FormsHelper.Success("All entitlements were un-allowed");
            MainView.Instance.setProgress("All entitlements were un-allowed", 100);
        }
    }
    public class ProfileView : BaseView<ProfileModel, ProfileController> { }
}
