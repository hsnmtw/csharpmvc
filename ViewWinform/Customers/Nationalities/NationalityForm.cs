using ControllerLibrary.Customers;
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

namespace ViewWinform.Customers.Nationalities {
    public partial class NationalityForm : Form {

        public NationalityForm() {
            InitializeComponent();
        }


        private NationalityController controller;
        private NationalityModel _model;


        public NationalityModel Model{
            get {
                _model.Id = int.Parse($"0{this.Id_TextBox.Text}");
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



        private void NationalityForm_Load(object sender, EventArgs e) {
            Utils.FormsHelper.registerEnterAsTab(this);
            this.controller = new NationalityController();
            this.Model = new NationalityModel();
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new NationalityModel();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.Save(this.Model);
            Utils.FormsHelper.successMessage("Successfully saved ...");
            Nationality_Code_TextBox_OnLookUpSelected(sender,new LookupEventArgs(this.Nationality_Code_TextBox.Text ));
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.Delete(this.Model);
            Utils.FormsHelper.successMessage("Successfully deleted ...");
            this.Model = new NationalityModel();
        }

        private void Nationality_Code_TextBox_OnLookUpSelected(object sender, EventArgs e) {
            this.Model = this.controller.Read(new NationalityModel() {
                Nationality_Code = ((LookupEventArgs)e).SelectedValueFromLookup,
            }, "Nationality_Code".Split(','))[0];
        }
    }
}
