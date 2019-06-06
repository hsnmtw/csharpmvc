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
        }

        public override void LoadForeignKeys(ForeignKeys FK) {
            FK.Put(DBControllersFactory.GetBuildingTypeController());
            FK.Put(DBControllersFactory.GetCompoundController());

            base.LoadForeignKeys(FK);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {            
            Model = Controller.Find(new BuildingModel() { Id = txtBuildingName.Text.ToInteger() }, "Id");
        }

        private void BuildingFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        private void TxtBuildingTypeId_TextChanged(object sender, EventArgs e) {
            txtBuildingTypeCode.Text = ForeignKeys.Instance[MODELS.BuildingType, txtBuildingTypeId.Text];
        }

        private void TxtCompoundId_TextChanged(object sender, EventArgs e) {
            txtCompoundName.Text = ForeignKeys.Instance[MODELS.Compound, txtCompoundId.Text];
        }
    }
    
}
