using MVCHIS.Common;
using System;
using System.Linq;
using System.Collections.Generic;
using MVCHIS.Utils;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.ProfileEntitlement)]
    public partial class ProfileEntitlementForm: ProfileEntitlementView {



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
            //pick lists
            PickList[btnPLEntitlement] = txtEntitlementId;
            PickList[btnPLProfile] = txtProfileId;
            PickList[btnPLProfileEntitlement] = txtId;
        }

        private void EntitlementFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        private void TxtEntitlementId_TextChanged(object sender, EventArgs e) {
            txtEntitlementName.Text = DBControllersFactory.FK(MODELS.Entitlement, txtEntitlementId.Text);
        }

        private void TxtProfileId_TextChanged(object sender, EventArgs e) {
            txtProfileName.Text = DBControllersFactory.FK(MODELS.Profile, txtProfileId.Text);
        }

        bool current = false;
        private void BtnSelectUnselectAll_Click(object sender, EventArgs e) {
            current = !current;
            var chkboxes = new System.Windows.Forms.CheckBox[] { chkAllowCreate,chkAllowDelete,chkAllowRead,chkAllowUpdate };
            foreach (var c in chkboxes) c.Checked = current;
            
        }

        internal void DisableChangeProfile() {
            btnPLProfileEntitlement.Enabled 
                = btnPLProfile.Enabled 
                = txtId.Enabled 
                = txtProfileId.Enabled 
                = txtProfileName.Enabled
                = false;
        }
    }    
}
