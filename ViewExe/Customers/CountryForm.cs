using MVCHIS.Common;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.Country)]
    public partial class CountryForm: CountryView {

        

        public CountryForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;
            base.Controller = (CountryController)DBControllersFactory.GetController(Common.MODELS.Country);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["CountryCode"] = txtCountryCode;
            Mapper["CountryArabic"] = txtCountryArabic;
            Mapper["CountryEnglish"] = txtCountryEnglish;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void CountryFormLoad(object sender, EventArgs e) {
            Label[] fieldsmarkers = { lblMetaDataCountryArabic,lblMetaDataCountryCode,lblMetaDataCountryEnglish };

            foreach(var required in fieldsmarkers) {
                string field = required.Name.Replace("lblMetaData", "");
                if (this.Controller.GetMetaData().RequiredFields.Contains(field)) {
                    required.Text = "*";
                } else {
                    required.Text = "";
                }
            }
        }

        private void CountryCodeTextBoxLookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new CountryModel() { CountryCode = selected }, "CountryCode");
        }
    }
    
}
