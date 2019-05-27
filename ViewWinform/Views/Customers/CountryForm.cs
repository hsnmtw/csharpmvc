using MVCWinform.Common;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MVCWinform.Customers {
    [ForEntity(Entities.Country)]
    public partial class CountryForm : SingleForm {

        public IDBController Controller;
        private CountryModel model;

        public CountryForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.Country);
            model = new CountryModel();
            Utils.FormsHelper.BindViewToModel(this, ref this.model);
        }


        public CountryModel Model{
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

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
            
            this.Model = (CountryModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);
        }
    }
}
