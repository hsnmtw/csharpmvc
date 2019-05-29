using MVCHIS.Common;
using System;

namespace MVCHIS.Security {
    [ForModel(Common.MODELS.ProfileEntitlement)]
    public partial class ProfileEntitlementForm: ProfileEntitlementsView {


        public ProfileEntitlementForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;
            base.Controller = (ProfileEntitlementsController)DBControllersFactory.GetController(Common.MODELS.ProfileEntitlement);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"]  = chkReadOnly;
            //data
            Mapper["ProfileName"] = txtProfileName;
            Mapper["EntitlementName"] = txtEntitlementName;
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

        }

        private void LookUpButton2_LookUpSelected(object sender, EventArgs e) {
            //this.Model = new ProfileEntitlementsModel();
            int id = int.Parse($"0{((LookupEventArgs)e).SelectedValueFromLookup}");
            Model = Controller.Find(new ProfileEntitlementsModel() { Id = id }, "Id");
        }

        private void Button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
    public class ProfileEntitlementsView : BaseView<ProfileEntitlementsModel, ProfileEntitlementsController> { }
}
