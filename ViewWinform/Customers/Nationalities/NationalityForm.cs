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
                _model.Id = int.Parse(this.Id_TextBox.Text);
                _model.Nationality_Code = this.Nationality_Code_TextBox.Text;
                _model.Nationality_Desc = this.Nationality_Desc_TextBox.Text;
                _model.Nationality_Arabic = this.Nationality_Arabic_TextBox.Text;
                return _model;
            }
            set {
                this._model = value;
                if (value == null) _model = new NationalityModel();
                this.Id_TextBox.Text = value.Id.ToString();
                this.Nationality_Code_TextBox.Text = _model.Nationality_Code;
                this.Nationality_Desc_TextBox.Text = _model.Nationality_Desc;
                this.Nationality_Arabic_TextBox.Text = _model.Nationality_Arabic;
            }
        }

        public NationalityForm() {
            InitializeComponent();
            this.controller = new ControllerLibrary.Customers.NationalityController();
        }

        

        private void NationalityForm_Load(object sender, EventArgs e) {
            Utils.FormsHelper.registerEnterAsTab(this);
            this.Nationality_Code_TextBox.LostFocus += new EventHandler(Nationality_Code_TextBox_Lostfocus);
        }

        private void Nationality_Code_TextBox_Lostfocus(object sender, EventArgs e) {
            //var search = controller.search(new ModelLibrary.Customers.NationalityModel() {
            //    Nationality_Code = Nationality_Code_TextBox.Text
            //}, "Nationality_Code".Split(','));

            //if (search.Count == 1) {
            //    this.models = search;
            //    this.bindingSource1.DataSource = this.models;
            //}
            //this.bindingSource1.ResetCurrentItem();
            //this.bindingSource1.MoveFirst();
        }


        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new ModelLibrary.Customers.NationalityModel();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.save(this.Model);
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.delete(this.Model);
        }

        private void Button1_Click(object sender, EventArgs e) {
            var selectedFields = "Nationality_Code,Nationality_Desc,Nationality_Arabic,Id".Split(',');
            var lookup = new Common.LookUp(this.controller.selectAsDataTable(
                selectedFields,
                new ModelLibrary.Customers.NationalityModel(),
                new string[] { }
            ));
            if (lookup.ShowDialog() == DialogResult.OK) {

                this.Model = new NationalityModel() {
                    Nationality_Code = lookup.SelectedValue[0],
                    Nationality_Desc = lookup.SelectedValue[1],
                    Nationality_Arabic = lookup.SelectedValue[2],
                    Id = int.Parse(lookup.SelectedValue[3])
                };
            }
        }
    }
}
