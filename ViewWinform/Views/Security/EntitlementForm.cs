using MVCWinform.Common;
using System;

namespace MVCWinform.Security {
    [ForEntity(Entities.Entitlement)]
    public partial class EntitlementForm : SingleForm {

        public EntitlementController Controller;
        private EntitlementModel model;

        public EntitlementModel Model {
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


        public EntitlementForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (EntitlementController)DBControllersFactory.GetController(Entities.Entitlement);
            model = new EntitlementModel();
            Utils.FormsHelper.BindViewToModel(this, ref this.model);
        }




        private void EntitlementFormLoad(object sender, EventArgs e) {

        }

        private void EntitlementNameLookupLookUpSelected(object sender, EventArgs e) {
            //this.Model = new EntitlementModel();
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.Model = (EntitlementModel)this.Controller.Find(new EntitlementModel() { EntitlementName = selected }, "EntitlementName");
        }
    }
}
