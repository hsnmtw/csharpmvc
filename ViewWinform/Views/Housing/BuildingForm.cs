using MVCWinform.Common;
using MVCWinform.Utils;
using System;
using System.Data;
using System.Linq;

namespace MVCWinform.Housing.Buildings {
    [ForEntity(Entities.Building)]
    public partial class BuildingForm : SingleForm {

        private IDBController roomCntrlr;
        public IDBController Controller;
        private BuildingModel model;

        public BuildingModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.lstRooms.Items.Clear();
                this.lstRooms.Items.AddRange((from RoomModel room in this.roomCntrlr.Read(new RoomModel() { BuildingName = model.BuildingName }, "BuildingName") select room.RoomName).ToArray());
                this.txtBuildingName.Select();
                this.txtBuildingName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }

        public BuildingForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            roomCntrlr = DBControllersFactory.GetController(Entities.Room);
            Controller = DBControllersFactory.GetController(Entities.Building);
            model = new BuildingModel();
            FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtBuildingName.Text = selected;
            this.Model = (BuildingModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);

        }

        private void BuildingFormLoad(object sender, EventArgs e) {

        }
    }
}
