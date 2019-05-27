using MVCWinform.Common;
using MVCWinform.Utils;
using System;

namespace MVCWinform.Customers {
    [ForEntity(Entities.Contact)]
    public partial class ContactForm : SingleForm {

        public IDBController Controller; 
        private ContactModel model; 

        public ContactModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtMobileNumber.Select();
                this.txtMobileNumber.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public ContactForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.Contact);
            model = new ContactModel();
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            //string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            //this.txtMobileNumber.Text = selected;
            this.Model = (ContactModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);

        }

        private void ContactFormLoad(object sender, EventArgs e) {
            FormsHelper.BindViewToModel(this,ref this.model);
        }
    }
}
