using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Data;
using System.Linq;

namespace MVCHIS.Housing.Buildings {
    //[ForModel(Common.MODELS.Building)]
    public partial class BuildingForm: BuildingView {

        public BuildingForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
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
            //pick list
            PickList[btnPLBuilding] = txtId;
            PickList[btnPLBuildingType] = txtBuildingTypeId;
            PickList[btnPLComound] = txtCompoundId;
        }

        private void PickListButton1LookUpSelected(int id) {            
        }

        private void BuildingFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        private void TxtBuildingTypeId_TextChanged(object sender, EventArgs e) {
            txtBuildingTypeCode.Text = DBControllersFactory.FK(MODELS.BuildingType, txtBuildingTypeId.Text);
        }

        private void TxtCompoundId_TextChanged(object sender, EventArgs e) {
            txtCompoundName.Text = DBControllersFactory.FK(MODELS.Compound, txtCompoundId.Text);
        }

        
    }
    
}
