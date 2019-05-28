using MVCWinform.Common;
using MVCWinform.Customers;
using MVCWinform.Utils;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using ViewWinform.Common;

namespace MVCWinform.Billing {

    [ForEntity(Entities.FoodType)]
    public partial class FoodTypeForm: FoodTypeView {

        //public IDBController Controller;

        
        public FoodTypeForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            
            Controller = (FoodTypeController)DBControllersFactory.GetController(Entities.FoodType);

            var type = typeof(FoodTypeModel);
            //template
            Mapper["Id"       ] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["FoodTypeCode"] = txtFoodTypeCode;
            Mapper["FoodTypeDesc"] = txtFoodTypeDesc;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            //this.txtFoodType.Text = selected;
            Model = Controller.Find(new FoodTypeModel() { FoodTypeCode = selected }, "FoodType");

        }

        private void FoodTypeFormLoad(object sender, EventArgs e) {
            
        }
    }
    public class FoodTypeView : BaseView<FoodTypeModel, FoodTypeController> { }
}
