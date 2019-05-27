using MVCWinform.Common;
using System;

namespace MVCWinform.Security {
    [ForEntity(Entities.ProfileEntitlement)]
    public partial class ProfileEntitlementForm : SingleForm {

        public IDBController Controller;
        private ProfileEntitlementsModel model;

        public ProfileEntitlementForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.ProfileEntitlement);
            model = new ProfileEntitlementsModel();
            Utils.FormsHelper.BindViewToModel(this, ref this.model);
        }

        public ProfileEntitlementsModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtEntitlementName.Select();
                this.txtEntitlementName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }

        private void EntitlementFormLoad(object sender, EventArgs e) {

        }

        private void LookUpButton2_LookUpSelected(object sender, EventArgs e) {
            //this.Model = new ProfileEntitlementsModel();
            int id = int.Parse($"0{((LookupEventArgs)e).SelectedValueFromLookup}");
            this.Model = (ProfileEntitlementsModel)this.Controller.Find(new ProfileEntitlementsModel() { Id = id }, "Id");
        }

        private void Button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
