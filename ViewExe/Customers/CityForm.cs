using MVCHIS.Common;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.City)]
    public partial class CityForm: CityView {

        private CountryController CntrlCY;

        public CityForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["CountryId"] = txtCountryId;
            Mapper["CityArabic"] = txtCityArabic;
            Mapper["CityEnglish"] = txtCityEnglish;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void CityFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            CntrlCY = (CountryController)DBControllersFactory.GetController(MODELS.Country);

            Label[] fieldsmarkers = { lblMetaDataCityArabic,lblMetaDataCityCode,lblMetaDataCityEnglish };

            foreach(var required in fieldsmarkers) {
                string field = required.Name.Replace("lblMetaData", "");
                if (this.Controller.GetMetaData().RequiredFields.Contains(field)) {
                    required.Text = "*";
                } else {
                    required.Text = "";
                }
            }
        }

        private void CityCodeTextBoxLookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new CityModel() { CityEnglish = selected }, "CityEnglish");
        }

        private void TxtCountryId_TextChanged(object sender, EventArgs e) {
            int.TryParse($"0{txtCountryId.Text}", out int id);
            var country = CntrlCY.Find(new CountryModel() { Id = id }, "Id");
            txtCountryCode.Text = country?.CountryCode;
            txtCountryEnglish.Text = country?.CountryEnglish;
        }
    }
    
}
