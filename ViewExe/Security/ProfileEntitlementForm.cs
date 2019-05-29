using MVCHIS.Common;
using System;
using ViewWinform.Common;

namespace MVCHIS.Security {
    [ForEntity(Entities.ProfileEntitlement)]
    public partial class ProfileEntitlementForm: ProfileEntitlementsView {


        public ProfileEntitlementForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (ProfileEntitlementsController)DBControllersFactory.GetController(Entities.ProfileEntitlement);
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
