using ControllerLibrary.Common;
using ControllerLibrary.Housing;
using ModelLibrary.Common;
using ModelLibrary.Housing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewWinform.Common;

namespace ViewWinform.Housing.Buildings {
    public partial class BuildingForm : SingleForm {

        private BaseController roomCntrlr = ControllersFactory.GetController(Entities.Room);
        public BaseController Controller => ControllersFactory.GetController(Entities.Building);
        private BuildingModel model = new BuildingModel();

        public BuildingModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.lstRooms.Items.Clear();
                this.lstRooms.Items.AddRange((from RoomModel room in this.roomCntrlr.Read(new RoomModel() { BuildingName = model.BuildingName },new string[] { "BuildingName" }) select room.RoomName).ToArray());
                this.txtBuildingName.Select();
                this.txtBuildingName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }

        public BuildingForm() {
            InitializeComponent();
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtBuildingName.Text = selected;
            this.Model = (BuildingModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();

        }

        private void BuildingFormLoad(object sender, EventArgs e) {
            ViewWinform.Utils.FormsHelper.BindViewToModel(this.panel1,ref this.model);
        }
    }
}
