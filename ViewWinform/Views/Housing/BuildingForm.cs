using MVCWinform.Common;
using MVCWinform.Utils;
using System;
using System.Data;
using System.Linq;
using ViewWinform.Common;

namespace MVCWinform.Housing.Buildings {
    [ForEntity(Entities.Building)]
    public partial class BuildingForm: BuildingView {

        private IDBController roomCntrlr;
        
        
        public BuildingForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            roomCntrlr = DBControllersFactory.GetController(Entities.Room);
            Controller = (BuildingController)DBControllersFactory.GetController(Entities.Building);
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
