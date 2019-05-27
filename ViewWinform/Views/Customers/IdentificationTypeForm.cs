using MVCWinform.Common;
using MVCWinform.Utils;
using System;

namespace MVCWinform.Customers {
    [ForEntity(Entities.IdentificationType)]
    public partial class IdentificationTypeForm : SingleForm {

        public IDBController Controller;
        private IdentificationTypeModel model;

        public IdentificationTypeModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtIdTypeCode.Select();
                this.txtIdTypeCode.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public IdentificationTypeForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.IdentificationType);
            model = new IdentificationTypeModel();
            FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtIdTypeCode.Text = selected;
            this.Model = (IdentificationTypeModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);

        }

        private void IdentificationTypeFormLoad(object sender, EventArgs e) {
        }
    }
}
