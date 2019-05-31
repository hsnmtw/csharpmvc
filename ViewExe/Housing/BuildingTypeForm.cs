using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Data;
using System.Linq;

namespace MVCHIS.Housing.BuildingTypes {
    //[ForModel(Common.MODELS.BuildingType)]
    public partial class BuildingTypeForm: BuildingTypeView {

        private IDBController bldgCntrlr;
         
        
        public BuildingTypeForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;;
            bldgCntrlr = DBControllersFactory.GetController(Common.MODELS.Building);
            base.Controller = (BuildingTypeController)DBControllersFactory.GetController(Common.MODELS.BuildingType);
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
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new BuildingTypeModel() { BuildingTypeCode=selected }, "BuildingTypeCode");
        }

        private void BuildingTypeFormLoad(object sender, EventArgs e) {

        }
    }
    
}
