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

namespace ViewWinform.Customers.Clients {
    public partial class ClientForm : SingleForm {

        //private BaseController bldgCntrlr = ControllersFactory.GetController(Entities.Client);
        private BaseController controller = ControllersFactory.GetController(Entities.Client);
        private ClientModel _model = new ClientModel();

        public ClientModel Model {
            get {
                _model.Client_Type     = txtClientType.Text;
                _model.Short_Name      = txtShortName.Text;
                _model.Long_Name       = txtLongName.Text;
                _model.Email           = txtEmailAddress.Text;
                _model.Fax_Number      = txtFaxNumber.Text;
                _model.Billing_Address = txtBillingAddress.Text;
                _model.Phone_Number    = txtPhoneNumber.Text;
                _model.Contact_Person  = txtContactPerson.Text;

                 //all models share the same
                _model.Id              = int.Parse($"0{this.txtId.Text}");
                _model.Created_By      = this.txtCreatedBy.Text;
                _model.Updated_By      = this.txtUpdatedBy.Text;
                try {
                    _model.Created_On  = DateTime.Parse(this.txtCreatedOn.Text);
                    _model.Updated_On  = DateTime.Parse(this.txtUpdatedOn.Text);
                } catch { }
                return _model;
            }
            set {
                this._model = value;
                
                txtClientType.Text     = _model.Client_Type     ;
                txtShortName.Text      = _model.Short_Name      ;
                txtLongName.Text       = _model.Long_Name       ;
                txtEmailAddress.Text   = _model.Email           ;
                txtFaxNumber.Text      = _model.Fax_Number      ;
                txtBillingAddress.Text = _model.Billing_Address ;
                txtPhoneNumber.Text    = _model.Phone_Number    ;
                txtContactPerson.Text  = _model.Contact_Person  ;

                //all models share the same
                this.txtId.Text = _model.Id.ToString();
                this.txtCreatedBy.Text = _model.Created_By;
                this.txtUpdatedBy.Text = _model.Updated_By;
                this.txtCreatedOn.Text = _model.Created_By == null || "".Equals(_model.Created_By) ? "" : _model.Created_On.ToString();
                this.txtUpdatedOn.Text = _model.Updated_By == null || "".Equals(_model.Updated_By) ? "" : _model.Updated_On.ToString();
                this.lstProjects.Items.Clear();
                //this.listBox1.Items.AddRange((from ClientModel building in bldgCntrlr.Read(new ClientModel() { Client_Type = _model.Client_Type },new string[] { "Client_Type" }) select building.Client_Type).ToArray());

                this.txtShortName.Select();
                this.txtShortName.Focus();
            }
        }

        public ClientForm() {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.Delete(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = new ClientModel();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.Save(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = (ClientModel)controller.Read(this.Model, this.controller.GetMetaData().GetUniqueKeyFields).First();
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new ClientModel();
        }

        private void ClientTypeForm_Load(object sender, EventArgs e) {
            ViewWinform.Utils.FormsHelper.registerEnterAsTab(this.panel1);
        }

        private void LookUpButtonShortName_LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtShortName.Text = selected;
            this.Model = (ClientModel)this.controller.Read(this.Model, this.controller.GetMetaData().GetUniqueKeyFields).First();
        }
    }
}
