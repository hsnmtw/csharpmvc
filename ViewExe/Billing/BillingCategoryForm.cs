using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Utils;
using System;
using System.Linq;

namespace MVCHIS.Billing {
    
    //[ForModel(Common.MODELS.BillingCategory)]
    public partial class BillingCategoryForm: BillingCategoryView {

        public BillingCategoryForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
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

        public override void LoadForeignKeys(ForeignKeys FK) {
            FK.Put(DBControllersFactory.GetController<FoodClassModel>()  );
            FK.Put(DBControllersFactory.GetController<FoodTypeModel>()   );
            FK.Put(DBControllersFactory.GetController<AccommClassModel>());
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            
            Model = Controller.Find(new BillingCategoryModel() { Id = txtBillingCategoryCode.Text.ToInteger() }, "Id");

        }

        private void AccomCategoryFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;

        }

        private void TxtAccommClassId_TextChanged(object sender, EventArgs e) {
            txtAccommClassCode.Text = ForeignKeys.Instance[MODELS.AccommClass, txtAccommClassId.Text];
        }

        private void TxtFoodClassId_TextChanged(object sender, EventArgs e) {
            txtFoodClassCode.Text = ForeignKeys.Instance[MODELS.FoodClass, txtFoodClassId.Text];
        }

        private void TxtFoodTypeId_TextChanged(object sender, EventArgs e) {
            txtFoodTypeCode.Text = ForeignKeys.Instance[MODELS.FoodType, txtFoodTypeId.Text];
        }
    }
    
}
