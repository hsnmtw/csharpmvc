﻿using ControllerLibrary.Common;
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

namespace ViewWinform.Customers.Nationalities {
    public partial class NationalityForm : SingleForm {

        public NationalityForm() {
            InitializeComponent();
        }


        private BaseController controller;
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

                this.Nationality_Code_TextBox.Select();
                this.Nationality_Code_TextBox.Focus();

            }
        }



        private void NationalityForm_Load(object sender, EventArgs e) {
            Utils.FormsHelper.registerEnterAsTab(this);
            this.controller = ControllersFactory.GetController(Entities.Nationality);
            this.Model = new NationalityModel();

            Label[] fieldsmarkers = { lblMetaData_Nationality_Arabic,lblMetaData_Nationality_Code,lblMetaData_Nationality_Desc };

            foreach(var required in fieldsmarkers) {
                string field = required.Name.Replace("lblMetaData_", "");
                if (this.controller.GetMetaData().GetRequiredFields.Contains(field)) {
                    required.Text = "*";
                } else {
                    required.Text = "";
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new NationalityModel();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.Save(this.Model);
            Utils.FormsHelper.successMessage("Successfully saved ...");
            Nationality_Code_TextBox_LookUpSelected(sender,new LookupEventArgs(this.Nationality_Code_TextBox.Text ));
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.Delete(this.Model);
            Utils.FormsHelper.successMessage("Successfully deleted ...");
            this.Model = new NationalityModel();
        }

        private void Nationality_Code_TextBox_LookUpSelected(object sender, EventArgs e) {
            this.Model = (NationalityModel)this.controller.Read(this.Model, this.controller.GetMetaData().GetUniqueKeyFields).First();
        }
    }
}
