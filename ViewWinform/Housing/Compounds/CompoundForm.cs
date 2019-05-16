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

namespace ViewWinform.Housing.Compounds {
    public partial class CompoundForm : Form {
        public CompoundForm() {
            InitializeComponent();
        }

        private CompoundController controller;
        private CompoundModel _model;

        public CompoundModel Model {
            get {
                _model.Id = "".Equals(this.Id_TextBox.Text) ? 0 : int.Parse(this.Id_TextBox.Text);
                _model.Compound_Name = this.Compound_Name_TextBox.Text;
                _model.Created_By = this.Created_By_TextBox.Text;
                _model.Updated_By = this.Updated_By_TextBox.Text;
                try {
                    _model.Created_On = DateTime.Parse(this.Created_On_TextBox.Text);
                    _model.Updated_On = DateTime.Parse(this.Updated_On_TextBox.Text);
                } catch { }
                return _model;
            }
            set {
                this._model = value;
                if (value == null) _model = new CompoundModel();
                this.Id_TextBox.Text = _model.Id.ToString();
                this.Compound_Name_TextBox.Text = _model.Compound_Name;
                this.Created_By_TextBox.Text = _model.Created_By;
                this.Updated_By_TextBox.Text = _model.Updated_By;
                this.Created_On_TextBox.Text = _model.Created_By == null || "".Equals(_model.Created_By) ? "" : _model.Created_On.ToString();
                this.Updated_On_TextBox.Text = _model.Updated_By == null || "".Equals(_model.Updated_By) ? "" : _model.Updated_On.ToString();

            }
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new CompoundModel();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.save(this.Model);
            Utils.FormsHelper.successMessage("Successfully saved ...");
            Compound_Code_TextBox_OnLookUpSelected(this.Model.Compound_Name);
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.delete(this.Model);
            Utils.FormsHelper.successMessage("Successfully deleted ...");
            this.Model = new CompoundModel();
        }

        private void Compound_Code_TextBox_OnLookUpSelected(string value) {
            this.Model = this.controller.selectModelsAsList(new CompoundModel() {
                Compound_Name = value,
            }, "Compound_Name".Split(','))[0];
        }

        private void CompoundForm_Load_1(object sender, EventArgs e) {
            Utils.FormsHelper.registerEnterAsTab(this);
            this.controller = new CompoundController();
            this.Model = new CompoundModel();
        }
    }
}
