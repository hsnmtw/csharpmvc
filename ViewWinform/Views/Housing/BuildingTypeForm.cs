using MVCWinform.Common;
using MVCWinform.Utils;
using System;
using System.Data;
using System.Linq;

namespace MVCWinform.Housing.BuildingTypes {
    [ForEntity(Entities.BuildingType)]
    public partial class BuildingTypeForm : SingleForm {

        private IDBController bldgCntrlr;
        public IDBController Controller; 
        private BuildingTypeModel model;  

        public BuildingTypeModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.lstBuildings.Items.Clear();
                this.lstBuildings.Items.AddRange((from BuildingModel building in bldgCntrlr.Read(new BuildingModel() { BuildingType = model.BuildingType }, "BuildingType" ) select building.BuildingName).ToArray());

                this.txtBuildingType.Select();
                this.txtBuildingType.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public BuildingTypeForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            bldgCntrlr = DBControllersFactory.GetController(Entities.Building);
            Controller = DBControllersFactory.GetController(Entities.BuildingType);
            model = new BuildingTypeModel();
            FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }


        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtBuildingType.Text = selected;
            this.Model = (BuildingTypeModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);

        }

        private void BuildingTypeFormLoad(object sender, EventArgs e) {

        }
    }
}
