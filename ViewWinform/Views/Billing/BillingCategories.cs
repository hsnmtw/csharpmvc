using MVCWinform.Common;
using MVCWinform.Customers;
using MVCWinform.Utils;
using System;

namespace MVCWinform.Billing {
    [ForEntity(Entities.BillingCategory)]
    public partial class BillingCategoryForm : SingleForm {

        public IDBController Controller;  
        private BillingCategoryModel model; 

        public BillingCategoryModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtBillingCategory.Select();
                this.txtBillingCategory.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public BillingCategoryForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            
            Controller = DBControllersFactory.GetController(Entities.BillingCategory);
            model = new BillingCategoryModel();
            FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.Model = this.Controller.Find(new BillingCategoryModel() { BillingCategory = selected }, "BillingCategory");

        }

        private void AccomCategoryFormLoad(object sender, EventArgs e) {
            
        }
    }
}
