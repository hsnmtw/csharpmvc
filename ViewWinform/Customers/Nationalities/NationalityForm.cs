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

namespace ViewWinform.Customers.Nationalities {
    public partial class NationalityForm : Form {

        private ControllerLibrary.Customers.NationalityController controller;
        private NationalityModel _model;

        public NationalityModel Model{
            get {
                _model.Id = "".Equals(this.Id_TextBox.Text) ? 0 : int.Parse(this.Id_TextBox.Text);
                _model.Nationality_Code = this.Nationality_Code_TextBox.Text;
                _model.Nationality_Desc = this.Nationality_Desc_TextBox.Text;
                _model.Nationality_Arabic = this.Nationality_Arabic_TextBox.Text;
                _model.Created_By  = this.Created_By_TextBox.Text  ;
                _model.Updated_By = this.Updated_By_TextBox.Text;
                try {
                    _model.Created_On = DateTime.Parse(this.Created_On_TextBox.Text);
                    _model.Updated_On = DateTime.Parse(this.Updated_On_TextBox.Text);
                } catch { }
                return _model;
            }
            set {
                this._model = value;
                if (value == null) _model = new NationalityModel();
                this.Id_TextBox.Text = _model.Id.ToString();
                this.Nationality_Code_TextBox.Text = _model.Nationality_Code;
                this.Nationality_Desc_TextBox.Text = _model.Nationality_Desc;
                this.Nationality_Arabic_TextBox.Text = _model.Nationality_Arabic;
                this.Created_By_TextBox.Text = _model.Created_By;
                this.Updated_By_TextBox.Text = _model.Updated_By;
                this.Created_On_TextBox.Text = _model.Created_By == null || "".Equals(_model.Created_By) ? "" : _model.Created_On.ToString();
                this.Updated_On_TextBox.Text = _model.Updated_By == null || "".Equals(_model.Updated_By) ? "" : _model.Updated_On.ToString();
                
            }
        }

        public NationalityForm() {
            InitializeComponent();
            this.controller = new ControllerLibrary.Customers.NationalityController();
            this.Model = new NationalityModel();
        }

        

        private void NationalityForm_Load(object sender, EventArgs e) {
            Utils.FormsHelper.registerEnterAsTab(this);
            this.Nationality_Code_TextBox.LostFocus += new EventHandler(Nationality_Code_TextBox_Lostfocus);
        }

        private void Nationality_Code_TextBox_Lostfocus(object sender, EventArgs e) {
        }


        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new ModelLibrary.Customers.NationalityModel();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.save(this.Model);
            Utils.FormsHelper.successMessage("Successful");
            this.Model = this.controller.selectAsList(this.controller.fields, new NationalityModel() {
                Nationality_Code = this.Model.Nationality_Code,
            }, "Nationality_Code".Split(','))[0];
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.delete(this.Model);
            Utils.FormsHelper.successMessage("Successful");
            this.Model = new NationalityModel();
        }

        private void Button1_Click(object sender, EventArgs e) {
            var selectedFields = "Nationality_Code,Nationality_Desc".Split(',');
            var lookup = new Common.LookUp(this.controller.selectAsDataTable(
                selectedFields,
                new ModelLibrary.Customers.NationalityModel(),
                new string[] { }
            ));
            if (lookup.ShowDialog() == DialogResult.OK) {

                this.Model = this.controller.selectAsList(this.controller.fields, new NationalityModel() {
                    Nationality_Code = lookup.SelectedValue[0],
                }, "Nationality_Code".Split(','))[0];
            }
        }
    }
}
