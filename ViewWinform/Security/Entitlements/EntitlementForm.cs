using ControllerLibrary.Security;
using ModelLibrary.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinform.Security.Entitlements {
    public partial class EntitlementForm : Form {
        public EntitlementForm() {
            InitializeComponent();
        }


        private EntitlementController controller;
        private EntitlementModel _model;

        public EntitlementModel Model {
            get {
                _model.Id = "".Equals(this.Id_TextBox.Text) ? 0 : int.Parse(this.Id_TextBox.Text);
                _model.Entitlement_Name = this.Entitlement_Name_TextBox.Text;
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
                if (value == null) _model = new EntitlementModel();
                this.Id_TextBox.Text = _model.Id.ToString();
                this.Entitlement_Name_TextBox.Text = _model.Entitlement_Name;
                this.Created_By_TextBox.Text = _model.Created_By;
                this.Updated_By_TextBox.Text = _model.Updated_By;
                this.Created_On_TextBox.Text = _model.Created_By == null || "".Equals(_model.Created_By) ? "" : _model.Created_On.ToString();
                this.Updated_On_TextBox.Text = _model.Updated_By == null || "".Equals(_model.Updated_By) ? "" : _model.Updated_On.ToString();

            }
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new EntitlementModel();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.save(this.Model);
            Utils.FormsHelper.successMessage("Successfully saved ...");
            Entitlement_Code_TextBox_OnLookUpSelected(this.Model.Entitlement_Name);
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.delete(this.Model);
            Utils.FormsHelper.successMessage("Successfully deleted ...");
            this.Model = new EntitlementModel();
        }

        private void Entitlement_Code_TextBox_OnLookUpSelected(string value) {
            this.Model = this.controller.selectModelsAsList(this.controller.fields, new EntitlementModel() {
                Entitlement_Name = value,
            }, "Entitlement_Name".Split(','))[0];
        }

        private void EntitlementForm_Load(object sender, EventArgs e) {
            Utils.FormsHelper.registerEnterAsTab(this);
            this.controller = new EntitlementController();
            this.Model = new EntitlementModel();
        }
    }
}
