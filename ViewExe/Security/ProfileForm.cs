using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ViewWinform.Common;

namespace MVCHIS.Security {
    [ForEntity(Entities.Profile)]
    public partial class ProfileForm: ProfileView {
        const char C = 'C', R = 'R', U = 'U', D = 'D', E = '-';
        private Dictionary<string, List<string>> entitlementsByGroup = new Dictionary<string, List<string>>();
        private List<string> allEntitlements = new List<string>();

        private IDBController eController;
        private IDBController peController;


        public ProfileForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (ProfileController)DBControllersFactory.GetController(Entities.Profile);
            eController = DBControllersFactory.GetController(Entities.Entitlement);
            peController = DBControllersFactory.GetController(Entities.ProfileEntitlement);
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
            List<string> filter;
            string eg = $"{this.cmbEntitelmentsGroup.SelectedItem}";
            if ("All".Equals(eg)) {
                filter = allEntitlements;
            } else if (this.entitlementsByGroup.ContainsKey(eg)) { 
                filter = this.entitlementsByGroup[eg];
            } else {
                filter = new List<string>();
            }
            this.lstEntitlements.Items.AddRange((
                    from ProfileEntitlementsModel row
                      in peController.Read(new ProfileEntitlementsModel() { ProfileName= Model.ProfileName }, "ProfileName" )
                   where filter.Contains(row.EntitlementName)
                 orderby row.EntitlementName
                  select $"{(row.AllowCreate?C:E)}{(row.AllowRead?R:E)}{(row.AllowUpdate?U:E)}{(row.AllowDelete?D:E)}  {row.EntitlementName}"
            ).ToArray());
        }

        private void ProfileFormLoad(object sender, EventArgs e) {
            
            this.cmbEntitelmentsGroup.Items.Clear();
            this.cmbEntitelmentsGroup.Items.Add("All");
            this.cmbEntitelmentsGroup.Text = "All";
            this.cmbEntitelmentsGroup.Items.AddRange((
               from eg
               in DBControllersFactory.GetController(Entities.EntitlementGroup).Read<EntitlementGroupModel>()
               orderby eg.EntitlementGroupName
               select eg.EntitlementGroupName
            ).ToArray());

            foreach (var em in DBControllersFactory.GetController(Entities.Entitlement).Read<EntitlementModel>().OrderBy(x => x.EntitlementName)) {
                if (this.entitlementsByGroup.ContainsKey(em.EntitlementGroupName) == false) {
                    this.entitlementsByGroup[em.EntitlementGroupName] = new List<string>();
                }
                this.entitlementsByGroup[em.EntitlementGroupName].Add(em.EntitlementName);
                this.allEntitlements.Add(em.EntitlementName);
            }
        }

        private void CmbEntitelmentsGroup_SelectedIndexChanged(object sender, EventArgs e) {
            RequeryEntitlements();
        }

        private void BtnInitializeEntitlements_Click(object sender, EventArgs e) {
            //remove all existing records for this profile
            foreach (ProfileEntitlementsModel row in peController.Read(new ProfileEntitlementsModel() { ProfileName=Model.ProfileName },"ProfileName")) {
                peController.Delete(row);
            }
            foreach(var row in eController.Read<EntitlementModel>()) {
                peController.Save(new ProfileEntitlementsModel() {
                    ProfileName = Model.ProfileName,
                    EntitlementName = row.EntitlementName,
                    AllowRead = row.EntitlementGroupName.Equals("Security") == false
                });
            }
            this.Model = this.Model;
        }

        private void BtnOpen_Click(object sender, EventArgs e) {
            if (this.lstEntitlements.SelectedIndex < 0) return;
            string profile = this.txtProfileName.Text;
            string entitlement = $"{this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex]}".Substring(6).Trim();
            var pef = new ProfileEntitlementForm();
            var pem = (ProfileEntitlementsModel)pef.Controller.Find(new ProfileEntitlementsModel() {
                ProfileName = profile,
                EntitlementName = entitlement
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
            ((ProfileEntitlementsController)peController).ChangePermissions(profile, entitlement, true, true, true, true);
            this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex] = $"{C}{R}{U}{D}  {entitlement}";
            //Utils.FormsHelper.Success("All entitlements were allowed");
            MainView.Instance.setProgress("All entitlements were allowed", 100);
        }

        private void BtnUnallowAll_Click(object sender, EventArgs e) {
            if (this.lstEntitlements.SelectedIndex < 0) return;
            string profile = this.txtProfileName.Text;
            string entitlement = $"{this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex]}".Substring(6).Trim();
            ((ProfileEntitlementsController)peController).ChangePermissions(profile, entitlement, false, false, false, false);
            this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex] = $"{E}{E}{E}{E}  {entitlement}";
            //Utils.FormsHelper.Success("All entitlements were un-allowed");
            MainView.Instance.setProgress("All entitlements were un-allowed", 100);
        }
    }
    public class ProfileView : BaseView<ProfileModel, ProfileController> { }
}
