using MVCWinform.Common;
using MVCWinform.Customers;
using MVCWinform.Utils;
using System;

namespace MVCWinform.Billing {
    [ForEntity(Entities.FoodClass)]
    public partial class FoodClassForm : SingleForm {

        public IDBController Controller;
        private FoodClassModel model;   

        public FoodClassModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtFoodClass.Select();
                this.txtFoodClass.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public FoodClassForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            
            Controller = DBControllersFactory.GetController(Entities.FoodClass);
            model = new FoodClassModel();
            FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtFoodClass.Text = selected;
            this.Model = (FoodClassModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);

        }

        private void FoodClassFormLoad(object sender, EventArgs e) {
           
        }
    }
}
