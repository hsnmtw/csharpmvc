using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Billing {
    
    [ForModel(Common.MODELS.BillingCategory)]
    public partial class BillingCategoryForm: BillingCategoryView {

        //private FoodClassController fcController;
        //private FoodTypeController ftController;
        //private AccommClassController acController;


        public BillingCategoryForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;; //(); if (DesignMode||(Site!=null && Site.DesignMode)) return;;
            base.Controller = (BillingCategoryController)DBControllersFactory.GetController(Common.MODELS.BillingCategory);
            this.Controllers = new System.Collections.Generic.Dictionary<string, IDBController> {
                ["FoodClass"  ] = DBControllersFactory.GetController(Common.MODELS.FoodClass),
                ["FoodType"   ] = DBControllersFactory.GetController(Common.MODELS.FoodType),
                ["AccommClass"] = DBControllersFactory.GetController(Common.MODELS.AccommClass)
            };
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["AccommClass"] = txtAccommClassCode;
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

        private void TxtAccommClassCode_TextChanged(object sender, EventArgs e) {
            txtAccommClassDesc.Text = Controllers["AccommClass"].Find(new AccommClassModel() { AccommClassCode = txtAccommClassCode.Text }, "AccommClassCode")?.AccommClassDesc;
        }

        private void TxtFoodClassCode_TextChanged(object sender, EventArgs e) {
            txtFoodClassDesc.Text = Controllers["FoodClass"].Find(new FoodClassModel() { FoodClassCode = txtFoodClassCode.Text }, "FoodClassCode")?.FoodClassDesc;
        }

        private void TxtFoodTypeCode_TextChanged(object sender, EventArgs e) {
            txtFoodTypeDesc.Text = Controllers["FoodType"].Find(new FoodTypeModel() { FoodTypeCode = txtFoodTypeCode.Text }, "FoodTypeCode")?.FoodTypeDesc;
        }
    }
    public class BillingCategoryView : BaseView<BillingCategoryModel, BillingCategoryController> { }
}
