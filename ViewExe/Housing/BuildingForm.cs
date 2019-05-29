using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Data;
using System.Linq;

namespace MVCHIS.Housing.Buildings {
    [ForModel(Common.MODELS.Building)]
    public partial class BuildingForm: BuildingView {

        private IDBController roomCntrlr;
        
        
        public BuildingForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;;
            roomCntrlr = DBControllersFactory.GetController(Common.MODELS.Room);
            base.Controller = (BuildingController)DBControllersFactory.GetController(Common.MODELS.Building);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["BuildingName"] = txtBuildingName;
            Mapper["BuildingType"] = txtBuildingType;
            Mapper["CompoundName"] = txtCompoundName;
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
    }
    public class BuildingView : BaseView<BuildingModel, BuildingController> { }
}
