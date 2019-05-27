using MVCWinform.Common;
using MVCWinform.Utils;
using System;

namespace MVCWinform.Customers {
    [ForEntity(Entities.Identification)]
    public partial class IdentificationForm : SingleForm {

        public IDBController Controller;
        private IdentificationModel model;

        public IdentificationModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtIdNumber.Select();
                this.txtIdNumber.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public IdentificationForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.Identification);
            model = new IdentificationModel();
            FormsHelper.BindViewToModel(this, ref this.model);
        }

        private void ClientTypeFormLoad(object sender, EventArgs e) {
        }

        private void LookUpButtonShortNameLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtId.Text = selected;
            this.Model = (IdentificationModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);
        }
    }
}
