using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Billing {
    //[ForModel(Common.MODELS.FoodClass)]
    public partial class FoodClassForm: FoodClassView {

        
        
        public FoodClassForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
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
            Model = Controller.Find(new FoodClassModel() { FoodClassCode = selected }, "FoodClassCode");

        }

        private void FoodClassFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;

        }
    }
   
}
