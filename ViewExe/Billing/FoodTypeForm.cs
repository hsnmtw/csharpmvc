﻿using MVCHIS.Common;
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
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
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
            //pick lists
            PickList[btnPLFoodType] = txtId;
        }

        private void FoodTypeFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;

        }

        
    }
   
}
