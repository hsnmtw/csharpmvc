using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLibrary.Customers;
using ControllerLibrary.Customers;

namespace ViewWinform.Customers.Nationalities {
    public partial class NationalityFormView : UserControl, BaseView<NationalityModel> {

        public NationalityFormView() {
            InitializeComponent();
            Utils.FormsHelper.registerEnterAsTab(this);
        }

        private NationalityModel _model = new NationalityModel();
        public NationalityModel model {
            get {
                _model.Id = int.Parse(this.Id_TextBox.Text);
                _model.Nationality_Code = this.Nationality_Code_TextBox.Text;
                _model.Nationality_Desc = this.Nationality_Desc_TextBox.Text;
                _model.Nationality_Arabic = this.Nationality_Arabic_TextBox.Text;
                return _model;
            }
            set {
                _model = value;
                //this.auditView1.setModel(_model);
                this.Id_TextBox.Text = _model == null ? "" : _model.Id.ToString();
                this.Nationality_Code_TextBox.Text = _model == null ? "" : _model.Nationality_Code;
                this.Nationality_Desc_TextBox.Text = _model == null ? "" : _model.Nationality_Desc;
                this.Nationality_Arabic_TextBox.Text = _model == null ? "" : _model.Nationality_Arabic;
            }
        }
    }
}
