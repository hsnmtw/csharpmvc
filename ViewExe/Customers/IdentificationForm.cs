using MVCHIS.Common;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.Identification)]
    public partial class IdentificationForm: IdentificationView {

        private CountryController CntrlCY;//= (CountryController)DBControllersFactory.GetController<CountryModel>();
        private CityController CntrlCT;//= (CountryController)DBControllersFactory.GetController<CountryModel>();

        private IdentificationTypeController CntrlIT;// = (IdentificationTypeController)DBControllersFactory.GetController<IdentificationTypeModel>();


        public IdentificationForm() {
            InitializeComponent();
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["ExpiryDate"] = txtExpiryDate;
            Mapper["IssueDate"] = txtIssueDate;
            Mapper["CityId"] = txtCityId;
            Mapper["IdNumber"] = txtIdNumber;
            Mapper["IdTypeId"] = txtIdTypeId;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void ClientTypeFormLoad(object sender, EventArgs e) { if (DesignMode) return;
            CntrlCT = (CityController)DBControllersFactory.GetController<CityModel>();
            CntrlCY = (CountryController)DBControllersFactory.GetController<CountryModel>();
            CntrlIT = (IdentificationTypeController)DBControllersFactory.GetController<IdentificationTypeModel>();

        }

        private void LookUpButtonShortNameLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new IdentificationModel() { IdNumber = selected }, "IdNumber");
        }

        private void TxtIssueDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtIssueDate);
        }

        private void TxtExpiryDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtExpiryDate);
        }

        private void TxtIdType_TextChanged(object sender, EventArgs e) {
            int.TryParse(txtIdTypeId.Text,out int id);
            txtIdTypeEnglish.Text = CntrlIT.Find(new IdentificationTypeModel() { Id = id }, "Id")?.IdTypeEnglish;
        }

        private void TxtIssuingCountry_TextChanged(object sender, EventArgs e) {
            int.TryParse(txtCityId.Text, out int id);
            var city = CntrlCT.Find(new CityModel() { Id = id }, "Id");
            txtCityEnglish.Text = city?.CityEnglish;
            int.TryParse($"{city?.CountryId}", out id);
            txtCountryEnglish.Text = CntrlCY.Find(new CountryModel() { Id = id }, "Id")?.CountryEnglish;
        }
    }
    
}
