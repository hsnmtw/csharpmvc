using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Utils;
using System;
using System.Linq;

namespace MVCHIS.Billing {
    
    //[ForModel(Common.MODELS.BillingCategory)]
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
            Mapper["AccommClassId"] = txtAccommClassId;
            Mapper["BillingCategoryCode"] = txtBillingCategoryCode;
            Mapper["BillingCategoryDesc"] = txtBillingCategoryDesc;
            Mapper["FoodTypeId"] = txtFoodTypeId;
            Mapper["FoodClassId"] = txtFoodClassId;
            Mapper["ReservationOnly"] = chkReservationOnly;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new BillingCategoryModel() { BillingCategoryCode = selected }, "BillingCategory");

        }

        private void AccomCategoryFormLoad(object sender, EventArgs e) {
            
        }

        private void TxtAccommClassId_TextChanged(object sender, EventArgs e) {
            var acmodel = Controllers["AccommClass"].Find(new AccommClassModel { Id = int.Parse($"0{txtAccommClassId.Text}") },"Id");
            txtAccommClassDesc.Text = acmodel?.AccommClassDesc;
            txtAccommClassCode.Text = acmodel?.AccommClassCode;
        }

        private void TxtFoodClassId_TextChanged(object sender, EventArgs e) {
            var fcmodel = Controllers["FoodClass"].Find(new FoodClassModel { Id = int.Parse($"0{txtFoodClassId.Text}") },"Id");
            txtFoodClassDesc.Text = fcmodel?.FoodClassDesc;
            txtFoodClassCode.Text = fcmodel?.FoodClassCode;
        }

        private void TxtFoodTypeId_TextChanged(object sender, EventArgs e) {
            var ftmodel = Controllers["FoodType"].Find(new FoodTypeModel { Id = int.Parse($"0{txtFoodTypeId.Text}") },"Id");
            txtFoodTypeDesc.Text = ftmodel?.FoodTypeDesc;
            txtFoodTypeCode.Text = ftmodel?.FoodTypeCode;
        }
    }
    public class BillingCategoryView : BaseView<BillingCategoryModel, BillingCategoryController> { }
}
