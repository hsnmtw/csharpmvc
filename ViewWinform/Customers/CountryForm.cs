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

namespace ViewWinform.Customers {
    public partial class CountryForm : SingleForm {

        public IDBController Controller;
        private CountryModel model;

        public CountryForm() {
            InitializeComponent(); if (DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.Country);
            model = new CountryModel();
            Utils.FormsHelper.BindViewToModel(this, ref this.model);
        }


        public CountryModel Model{
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtCountryCode.Select();
                this.txtCountryCode.Focus();

            }
        }
        public override void UpdateModel() { var _ = Model; }


        private void CountryFormLoad(object sender, EventArgs e) {
            Label[] fieldsmarkers = { lblMetaDataCountryArabic,lblMetaDataCountryCode,lblMetaDataCountryEnglish };

            foreach(var required in fieldsmarkers) {
                string field = required.Name.Replace("lblMetaData", "");
                if (this.Controller.GetMetaData().GetRequiredFields.Contains(field)) {
                    required.Text = "*";
                } else {
                    required.Text = "";
                }
            }
        }

        private void CountryCodeTextBoxLookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtCountryCode.Text = selected;
            
            this.Model = (CountryModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }
    }
}
