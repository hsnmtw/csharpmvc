using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace MVCHIS.Billing {

    //[ForModel(Common.MODELS.FoodType)]
    public partial class FoodTypeForm: FoodTypeView {

        

        
        public FoodTypeForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;
            
            base.Controller = (FoodTypeController)DBControllersFactory.GetController(Common.MODELS.FoodType);

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
            Model = Controller.Find(new FoodTypeModel() { FoodTypeCode = selected }, "FoodTypeCode");

        }

        private void FoodTypeFormLoad(object sender, EventArgs e) {
            
        }
    }
    public class FoodTypeView : BaseView<FoodTypeModel, FoodTypeController> { }
}
