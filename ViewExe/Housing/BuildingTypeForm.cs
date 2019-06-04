﻿using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Data;
using System.Linq;

namespace MVCHIS.Housing.BuildingTypes {
    //[ForModel(Common.MODELS.BuildingType)]
    public partial class BuildingTypeForm: BuildingTypeView {
 
        
        public BuildingTypeForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["BuildingTypeCode"] = txtBuildingTypeCode;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }


        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            Model = Controller.Find(new BuildingTypeModel() { Id = txtBuildingTypeCode.Text.ToInteger() }, "Id");
        }

        private void BuildingTypeFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;

        }
    }
    
}
