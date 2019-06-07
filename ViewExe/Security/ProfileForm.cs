using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.Profile)]
    public partial class ProfileForm: ProfileView {
        const char C = 'C', R = 'R', U = 'U', D = 'D', E = '-';
        private Dictionary<string, List<EntitlementModel>> entitlementsByGroup = new Dictionary<string, List<EntitlementModel>>();
        private Dictionary<int, EntitlementModel> allEntitlements;
        private Dictionary<int, EntitlementGroupModel> entitlementmentGroups;

        private EntitlementController        CntrlEN;
        private ProfileEntitlementController CntrlPE;
        private EntitlementGroupController   CntrlEG;

        public ProfileForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
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

        private void ProfileFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            CntrlEN = DBControllersFactory.Entitlement();
            CntrlPE = DBControllersFactory.ProfileEntitlement();
            CntrlEG = DBControllersFactory.EntitlementGroup();

            cmbEntitelmentsGroup.Items.Clear();
            cmbEntitelmentsGroup.Items.Add("All");
            cmbEntitelmentsGroup.Text = "All";

            allEntitlements = CntrlEN.Read().ToDictionary(x => x.Id, x => x);

            cmbEntitelmentsGroup.Items.AddRange((
               from eg
               in CntrlEG.Read()
               orderby eg.EntitlementGroupName
               select eg.EntitlementGroupName
            ).ToArray());

            entitlementmentGroups = CntrlEG.Read().ToDictionary(x => x.Id, x => x);
            
            foreach (var em in CntrlEN.Read().OrderBy(x => x.EntitlementName)) {
                var egname = entitlementmentGroups[em.EntitlementGroupId].EntitlementGroupName;
                if (entitlementsByGroup.ContainsKey(egname) == false) {
                    entitlementsByGroup[egname] = new List<EntitlementModel>();
                }
                entitlementsByGroup[egname].Add(em);
                allEntitlements[em.Id] = em;
            }
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
                      in CntrlPE.Read(new ProfileEntitlementModel() { ProfileId= Model.Id }, "ProfileId" )
                   where filter.Exists(x => x.Id == row.EntitlementId)
                  select $"{(row.AllowCreate?C:E)}{(row.AllowRead?R:E)}{(row.AllowUpdate?U:E)}{(row.AllowDelete?D:E)}  {allEntitlements[row.EntitlementId].EntitlementName}"
            ).ToArray());
        }



        private void CmbEntitelmentsGroup_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                RequeryEntitlements();
            } catch { }
        }

        private void BtnInitializeEntitlements_Click(object sender, EventArgs e) {
            //remove all existing records for this profile
            foreach (var pemodel in CntrlPE.Read(new ProfileEntitlementModel() { ProfileId=Model.Id },"ProfileId")) {
                CntrlPE.Delete(pemodel);
            }
            foreach(var entitlement in CntrlEN.Read()) {
                CntrlPE.Save(new ProfileEntitlementModel() {
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

        private void BtnAllowAll_Click(object sender, EventArgs e) {
            if (this.lstEntitlements.SelectedIndex < 0) return;
            string profile = this.txtProfileName.Text;
            string entitlement = $"{this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex]}".Substring(6).Trim();
            int entitlementId = (from EntitlementModel ent in allEntitlements.Values where ent.EntitlementName.Equals(entitlement) select ent).FirstOrDefault().Id;
            int.TryParse(txtId.Text, out int profileId);

            CntrlPE.ChangePermissions(profileId, entitlementId, true, true, true, true);
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

            CntrlPE.ChangePermissions(profileId, entitlementId, false, false, false, false);
            this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex] = $"{E}{E}{E}{E}  {entitlement}";
            //Utils.FormsHelper.Success("All entitlements were un-allowed");
            MainView.Instance.setProgress("All entitlements were un-allowed", 100);
        }
    }
    
}
