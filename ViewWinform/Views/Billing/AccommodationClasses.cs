using MVCWinform.Common;
using MVCWinform.Customers;
using MVCWinform.Utils;
using System;

namespace MVCWinform.Billing {
    [ForEntity(Entities.AccomClass)]
    public partial class AccomodationClassForm : SingleForm {

        public IDBController Controller ;
        private AccomClassModel model;

        public AccomClassModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtAccomodationClass.Select();
                this.txtAccomodationClass.Focus();
            }
        }

        public override void UpdateModel() { var _ = Model; }
   

        public AccomodationClassForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            
            Controller = DBControllersFactory.GetController(Entities.AccomClass);
            model = new AccomClassModel();
            FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.Model = this.Controller.Find(new AccomClassModel() {AccomClass = selected }, "AccomClass");
        }

        private void AccomClassFormLoad(object sender, EventArgs e) {
            
        }
    }
}
