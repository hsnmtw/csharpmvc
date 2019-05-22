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

namespace ViewWinform.Housing.BuildingTypes {
    public partial class BuildingTypeForm : SingleForm {

        private BaseController bldgCntrlr = ControllersFactory.GetController(Entities.Building);
        public BaseController Controller => ControllersFactory.GetController(Entities.BuildingType);
        private BuildingTypeModel model = new BuildingTypeModel();

        public BuildingTypeModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.lstBuildings.Items.Clear();
                this.lstBuildings.Items.AddRange((from BuildingModel building in bldgCntrlr.Read(new BuildingModel() { BuildingType = model.BuildingType },new string[] { "BuildingType" }) select building.BuildingName).ToArray());

                this.txtBuildingType.Select();
                this.txtBuildingType.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public BuildingTypeForm() {
            InitializeComponent();
        }


        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtBuildingType.Text = selected;
            this.Model = (BuildingTypeModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();

        }

        private void BuildingTypeFormLoad(object sender, EventArgs e) {
            ViewWinform.Utils.FormsHelper.BindViewToModel(this.panel1,ref this.model);
        }
    }
}
