using MVCWinform.Common;
using MVCWinform.Customers;
using MVCWinform.Utils;
using System;

namespace MVCWinform.Billing {
    [ForEntity(Entities.FoodType)]
    public partial class FoodTypeForm : SingleForm {

        public IDBController Controller;
        private FoodTypeModel model;

        public FoodTypeModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtFoodType.Select();
                this.txtFoodType.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public FoodTypeForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            
            Controller = DBControllersFactory.GetController(Entities.FoodType);
            model = new FoodTypeModel();
            FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtFoodType.Text = selected;
            this.Model = (FoodTypeModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);

        }

        private void FoodTypeFormLoad(object sender, EventArgs e) {
            
        }
    }
}
