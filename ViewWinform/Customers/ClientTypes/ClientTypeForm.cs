using ControllerLibrary.Common;
using ControllerLibrary.Customers;
using ModelLibrary.Common;
using ModelLibrary.Customers;
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

namespace ViewWinform.Customers.ClientTypes {
    public partial class ClientTypeForm : Form {

        //private BaseController bldgCntrlr = ControllersFactory.GetController(Entities.Client);
        private BaseController controller = ControllersFactory.GetController(Entities.ClientType);
        private ClientTypeModel _model = new ClientTypeModel();

        public ClientTypeModel Model {
            get {
                _model.Id = int.Parse($"0{this.txtId.Text}");
                _model.Client_Type = this.txtClientType.Text;
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
                this.txtClientType.Text = _model.Client_Type;
                this.txtId.Text = _model.Id.ToString();
                this.txtCreatedBy.Text = _model.Created_By;
                this.txtUpdatedBy.Text = _model.Updated_By;
                this.txtCreatedOn.Text = _model.Created_By == null || "".Equals(_model.Created_By) ? "" : _model.Created_On.ToString();
                this.txtUpdatedOn.Text = _model.Updated_By == null || "".Equals(_model.Updated_By) ? "" : _model.Updated_On.ToString();
                this.listBox1.Items.Clear();
                //this.listBox1.Items.AddRange((from ClientModel building in bldgCntrlr.Read(new ClientModel() { Client_Type = _model.Client_Type },new string[] { "Client_Type" }) select building.Client_Type).ToArray());

                this.txtClientType.Select();
                this.txtClientType.Focus();
            }
        }

        public ClientTypeForm() {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.Delete(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = new ClientTypeModel();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.Save(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = (ClientTypeModel)controller.Read(this.Model, new string[] {
                "Client_Type"
            }).First();
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new ClientTypeModel();
        }

        private void LookUpButton1_OnLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtClientType.Text = selected;
            this.Model = (ClientTypeModel)this.controller.Read(this.Model, new string[] { "Client_Type" }).First();

        }

        private void ClientTypeForm_Load(object sender, EventArgs e) {
            ViewWinform.Utils.FormsHelper.registerEnterAsTab(this.panel1);
        }
    }
}
