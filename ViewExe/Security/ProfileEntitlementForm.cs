using MVCHIS.Common;
using System;
using System.Linq;
using System.Collections.Generic;
using MVCHIS.Utils;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.ProfileEntitlement)]
    public partial class ProfileEntitlementForm: ProfileEntitlementsView {



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

        public override void LoadForeignKeys(ForeignKeys FK) {
            FK.Put(DBControllersFactory.GetController<ProfileModel>());
            FK.Put(DBControllersFactory.GetController<EntitlementModel>());
        }


        private void EntitlementFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        private void LookUpButton2_LookUpSelected(object sender, EventArgs e) {
            Model = Controller.Find(new ProfileEntitlementModel() { Id = txtId.Text.ToInteger() }, "Id");
        }

        private void Button1_Click(object sender, EventArgs e) {
            //this.Close();
        }

        private void TxtEntitlementId_TextChanged(object sender, EventArgs e) {
            txtEntitlementName.Text = ForeignKeys.Instance[MODELS.Entitlement,txtEntitlementId.Text];
        }

        private void TxtProfileId_TextChanged(object sender, EventArgs e) {
            txtProfileName.Text = ForeignKeys.Instance[MODELS.Profile, txtProfileId.Text];
        }

        bool current = false;
        private void BtnSelectUnselectAll_Click(object sender, EventArgs e) {
            current = !current;
            var chkboxes = new System.Windows.Forms.CheckBox[] { chkAllowCreate,chkAllowDelete,chkAllowRead,chkAllowUpdate };
            foreach (var c in chkboxes) c.Checked = current;
            
        }
    }
    
}
