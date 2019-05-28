using MVCWinform.Common;
using MVCWinform.Customers;
using MVCWinform.Utils;
using System;
using ViewWinform.Common;

namespace MVCWinform.Billing {
    [ForEntity(Entities.FoodClass)]
    public partial class FoodClassForm: FoodClassView {

        
        
        public FoodClassForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (FoodClassController)DBControllersFactory.GetController(Entities.FoodClass);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["FoodClassCode"] = txtFoodClassCode;
            Mapper["FoodClassDesc"] = txtFoodClassDesc;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            //this.txtFoodClass.Text = selected;
            Model = Controller.Find(new FoodClassModel() { FoodClassCode = selected }, "FoodClassCode");

        }

        private void FoodClassFormLoad(object sender, EventArgs e) {
           
        }
    }
    public class FoodClassView : BaseView<FoodClassModel, FoodClassController> { }
}
