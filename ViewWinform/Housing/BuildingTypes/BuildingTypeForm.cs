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
        private BaseController controller = ControllersFactory.GetController(Entities.BuildingType);
        private BuildingTypeModel _model = new BuildingTypeModel();

        public BuildingTypeModel Model {
            get {
                _model.Id = int.Parse($"0{this.txtId.Text}");
                _model.Building_Type = this.txtBuildingType.Text;
                _model.Created_By = this.txtCreatedBy.Text;
                _model.Updated_By = this.txtUpdatedBy.Text;
                try {
                    _model.Created_On = DateTime.Parse(this.txtCreatedOn.Text);
                    _model.Updated_On = DateTime.Parse(this.txtUpdatedOn.Text);
                } catch { }
                return _model;
            }
            set {
                this._model = value;
                this.txtBuildingType.Text = _model.Building_Type;
                this.txtId.Text = _model.Id.ToString();
                this.txtCreatedBy.Text = _model.Created_By;
                this.txtUpdatedBy.Text = _model.Updated_By;
                this.txtCreatedOn.Text = _model.Created_By == null || "".Equals(_model.Created_By) ? "" : _model.Created_On.ToString();
                this.txtUpdatedOn.Text = _model.Updated_By == null || "".Equals(_model.Updated_By) ? "" : _model.Updated_On.ToString();
                this.listBox1.Items.Clear();
                this.listBox1.Items.AddRange((from BuildingModel building in bldgCntrlr.Read(new BuildingModel() { Building_Type = _model.Building_Type },new string[] { "Building_Type" }) select building.Building_Name).ToArray());

                this.txtBuildingType.Select();
                this.txtBuildingType.Focus();
            }
        }

        public BuildingTypeForm() {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.Delete(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = new BuildingTypeModel();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.Save(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = (BuildingTypeModel)controller.Read(this.Model, this.controller.GetMetaData().GetUniqueKeyFields).First();
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new BuildingTypeModel();
        }

        private void LookUpButton1_LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtBuildingType.Text = selected;
            this.Model = (BuildingTypeModel)this.controller.Read(this.Model, this.controller.GetMetaData().GetUniqueKeyFields).First();

        }

        private void BuildingTypeForm_Load(object sender, EventArgs e) {
            ViewWinform.Utils.FormsHelper.registerEnterAsTab(this.panel1);
        }
    }
}
