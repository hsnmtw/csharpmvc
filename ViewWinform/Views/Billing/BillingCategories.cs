using MVCWinform.Common;
using MVCWinform.Customers;
using MVCWinform.Utils;
using System;
using ViewWinform.Common;

namespace MVCWinform.Billing {
    
    [ForEntity(Entities.BillingCategory)]
    public partial class BillingCategoryForm: BillingCategoryView {

        public BillingCategoryForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (BillingCategoryController)DBControllersFactory.GetController(Entities.BillingCategory);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["AccomClass"] = txtAccomClassCode;
            Mapper["BillingCategory"] = txtBillingCategory;
            Mapper["BillingCategoryDesc"] = txtBillingCategoryDesc;
            Mapper["FoodType"] = txtFoodTypeCode;
            Mapper["FoodClass"] = txtFoodClassCode;
            Mapper["ReservationOnly"] = chkReservationOnly;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new BillingCategoryModel() { BillingCategory = selected }, "BillingCategory");

        }

        private void AccomCategoryFormLoad(object sender, EventArgs e) {
            
        }
    }
    public class BillingCategoryView : BaseView<BillingCategoryModel, BillingCategoryController> { }
}
