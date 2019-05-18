using ControllerLibrary.Common;
using ControllerLibrary.Housing;
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
    public partial class BuildingForm : Form {

        private BaseController controller = new BuildingController();
        private BuildingModel _model = new BuildingModel();

        public BuildingModel Model {
            get {
                _model.Id = int.Parse($"0{this.txtId.Text}");
                _model.Compound_Name = this.txtCompoundName.Text;
                _model.Building_Name = this.txtBuildingName.Text;
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
                this.txtBuildingName.Text = _model.Building_Name;
                this.txtCompoundName.Text = _model.Compound_Name;
                this.txtId.Text = _model.Id.ToString();
                this.txtCreatedBy.Text = _model.Created_By;
                this.txtUpdatedBy.Text = _model.Updated_By;
                this.txtCreatedOn.Text = _model.Created_By == null || "".Equals(_model.Created_By) ? "" : _model.Created_On.ToString();
                this.txtUpdatedOn.Text = _model.Updated_By == null || "".Equals(_model.Updated_By) ? "" : _model.Updated_On.ToString();

            }
        }

        public BuildingForm() {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.Delete(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = new BuildingModel();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.Save(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = (BuildingModel)controller.Read(this.Model, new string[] {
                "Building_Name"
            }).First();
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new BuildingModel();
        }

        private void LookUpButton1_OnLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtBuildingName.Text = selected;
            this.Model = (BuildingModel)this.controller.Read(this.Model, new string[] { "Building_Name" }).First();

        }
    }
}
