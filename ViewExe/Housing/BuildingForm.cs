using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Data;
using System.Linq;

namespace MVCHIS.Housing.Buildings {
    //[ForModel(Common.MODELS.Building)]
    public partial class BuildingForm: BuildingView {

        //private IDBController roomCntrlr;
        private BuildingTypeController CntrlBT;//= (BuildingTypeController)DBControllersFactory.GetController<BuildingTypeModel>();
        private CompoundController     CntrlCM;//= (CompoundController)DBControllersFactory.GetController<CompoundModel>();


        public BuildingForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;
            CntrlBT = (BuildingTypeController)DBControllersFactory.GetController<BuildingTypeModel>();
            CntrlCM = (CompoundController)DBControllersFactory.GetController<CompoundModel>();

            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["BuildingName"] = txtBuildingName;
            Mapper["BuildingTypeId"] = txtBuildingTypeId;
            Mapper["CompoundId"] = txtCompoundId;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new BuildingModel() { BuildingName = selected }, "BuildingName");

        }

        private void BuildingFormLoad(object sender, EventArgs e) {
        }

        private void TxtBuildingTypeId_TextChanged(object sender, EventArgs e) {
            int id = int.Parse($"0{txtBuildingTypeId.Text}");
            txtBuildingTypeCode.Text = CntrlBT.Find(new BuildingTypeModel() { Id = id }, "Id")?.BuildingTypeCode;
        }

        private void TxtCompoundId_TextChanged(object sender, EventArgs e) {
            int id = int.Parse($"0{txtCompoundId.Text}");
            txtCompoundName.Text = CntrlCM.Find(new CompoundModel() { Id = id }, "Id")?.CompoundName;
        }
    }
    
}
