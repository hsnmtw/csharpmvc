using MVCHIS.Common;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.ProfileEntitlement)]
    public partial class ProfileEntitlementForm: ProfileEntitlementsView {

        private Dictionary<int, string> entitlements;
        private Dictionary<int, string> profiles;

        public ProfileEntitlementForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;
            base.Controller = (ProfileEntitlementController)DBControllersFactory.GetController(MODELS.ProfileEntitlement);
            Controllers = new Dictionary<string, IDBController> {
                ["e"] = DBControllersFactory.GetController(MODELS.Entitlement),
                ["p"] = DBControllersFactory.GetController(MODELS.Profile)
            };
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"]  = chkReadOnly;
            //data
            Mapper["ProfileId"] = txtProfileId;
            Mapper["EntitlementId"] = txtEntitlementId;

            Mapper["AllowRead"] = chkAllowRead;
            Mapper["AllowDelete"] = chkAllowDelete;
            Mapper["AllowCreate"] = chkAllowCreate;
            Mapper["AllowUpdate"] = chkAllowUpdate;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }        

        private void EntitlementFormLoad(object sender, EventArgs e) {
            entitlements = Controllers["e"].Read<EntitlementModel>().ToDictionary(x => x.Id, x => x.EntitlementName);
            profiles = Controllers["p"].Read<ProfileModel>().ToDictionary(x => x.Id, x => x.ProfileName);
        }

        private void LookUpButton2_LookUpSelected(object sender, EventArgs e) {
            //this.Model = new ProfileEntitlementsModel();
            int id = int.Parse($"0{((LookupEventArgs)e).SelectedValueFromLookup}");
            Model = Controller.Find(new ProfileEntitlementModel() { Id = id }, "Id");
        }

        private void Button1_Click(object sender, EventArgs e) {
            //this.Close();
        }

        private void TxtEntitlementId_TextChanged(object sender, EventArgs e) {
            int.TryParse(txtEntitlementId.Text, out int eid);
            txtEntitlementName.Text = entitlements[eid];
        }

        private void TxtProfileId_TextChanged(object sender, EventArgs e) {
            int.TryParse(txtProfileId.Text, out int pid);
            txtProfileName.Text = profiles[pid];
        }
    }
    
}
