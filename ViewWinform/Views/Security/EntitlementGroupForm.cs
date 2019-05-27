using MVCWinform.Common;
using System;

namespace MVCWinform.Security {
    [ForEntity(Entities.EntitlementGroup)]
    public partial class EntitlementGroupForm : SingleForm {

        public EntitlementGroupController Controller;
        private EntitlementGroupModel model;

        public EntitlementGroupForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (EntitlementGroupController)DBControllersFactory.GetController(Entities.EntitlementGroup);
            model = new EntitlementGroupModel();
            Utils.FormsHelper.BindViewToModel(this, ref this.model);
        }

        public EntitlementGroupModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtEntitlementGroupName.Select();
                this.txtEntitlementGroupName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }


        private void EntitlementGroupFormLoad(object sender, EventArgs e) {

        }

        private void EntitlementGroupNameLookupLookUpSelected(object sender, EventArgs e) {
            this.txtEntitlementGroupName.Text = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.Model = (EntitlementGroupModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);
        }
    }
}
