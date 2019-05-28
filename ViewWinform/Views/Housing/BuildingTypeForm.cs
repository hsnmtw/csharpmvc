using MVCWinform.Common;
using MVCWinform.Utils;
using System;
using System.Data;
using System.Linq;
using ViewWinform.Common;

namespace MVCWinform.Housing.BuildingTypes {
    [ForEntity(Entities.BuildingType)]
    public partial class BuildingTypeForm: BuildingTypeView {

        private IDBController bldgCntrlr;
        //public IDBController Controller; 
        
        public BuildingTypeForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            bldgCntrlr = DBControllersFactory.GetController(Entities.Building);
            Controller = (BuildingTypeController)DBControllersFactory.GetController(Entities.BuildingType);
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
    public class BuildingTypeView : BaseView<BuildingTypeModel, BuildingTypeController> { }
}
