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
        private List<ModelLibrary.Customers.NationalityModel> models;

        public NationalityForm() {
            InitializeComponent();
            this.controller = new ControllerLibrary.Customers.NationalityController();
            this.models = new List<ModelLibrary.Customers.NationalityModel>(){ new ModelLibrary.Customers.NationalityModel() };
            this.bindingSource1.DataSource = this.models;
            this.Id_TextBox.DataBindings.Add("Text", this.bindingSource1, "Id");
            this.Nationality_Code_TextBox.DataBindings.Add("Text", this.bindingSource1, "Nationality_Code");
            this.Nationality_Arabic_TextBox.DataBindings.Add("Text", this.bindingSource1, "Nationality_Arabic");
            this.Nationality_Desc_TextBox.DataBindings.Add("Text", this.bindingSource1, "Nationality_Desc");
        }

        private void NationalityForm_Load(object sender, EventArgs e) {
            Utils.FormsHelper.registerEnterAsTab(this);
            this.Nationality_Code_TextBox.LostFocus += new EventHandler(Nationality_Code_TextBox_Lostfocus);
        }

        private void Nationality_Code_TextBox_Lostfocus(object sender, EventArgs e) {
            var search = controller.search(new ModelLibrary.Customers.NationalityModel() {
                Nationality_Code = Nationality_Code_TextBox.Text
            }, "Nationality_Code".Split(','));

            if (search.Count == 1) {
                this.models = search;
                this.bindingSource1.DataSource = this.models;
            }
            //this.bindingSource1.ResetCurrentItem();
            //this.bindingSource1.MoveFirst();
        }


        private void Button2_Click(object sender, EventArgs e) {
            this.bindingSource1.DataSource = new List<ModelLibrary.Customers.NationalityModel>() {
                new ModelLibrary.Customers.NationalityModel()
            };
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.save(this.models[0]);
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.delete(this.models[0]);
        }
    }
}
