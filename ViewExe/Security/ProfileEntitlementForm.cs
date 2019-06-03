using MVCHIS.Common;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.ProfileEntitlement)]
    public partial class ProfileEntitlementForm: ProfileEntitlementsView {

        private ProfileController     CntrlPR;
        private EntitlementController CntrlEN;

        private Dictionary<int, string> entitlements;
        private Dictionary<int, string> profiles;

        public ProfileEntitlementForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
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

        private void EntitlementFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            CntrlPR = (ProfileController)DBControllersFactory.GetController<ProfileModel>();
            CntrlEN = (EntitlementController)DBControllersFactory.GetController<EntitlementModel>();


            entitlements = CntrlEN.Read().ToDictionary(x => x.Id, x => x.EntitlementName);
            profiles = CntrlPR.Read().ToDictionary(x => x.Id, x => x.ProfileName);
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

        bool current = false;
        private void BtnSelectUnselectAll_Click(object sender, EventArgs e) {
            current = !current;
            var chkboxes = new System.Windows.Forms.CheckBox[] { chkAllowCreate,chkAllowDelete,chkAllowRead,chkAllowUpdate };
            foreach (var c in chkboxes) c.Checked = current;
            
        }
    }
    
}
