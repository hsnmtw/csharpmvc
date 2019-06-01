using MVCHIS.Common;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.Identification)]
    public partial class IdentificationForm: IdentificationView {

        private CountryController CntrlCY;//= (CountryController)DBControllersFactory.GetController<CountryModel>();
        private IdentificationTypeController CntrlIT;// = (IdentificationTypeController)DBControllersFactory.GetController<IdentificationTypeModel>();


        public IdentificationForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;;
            CntrlCY = (CountryController)DBControllersFactory.GetController<CountryModel>();
            CntrlIT = (IdentificationTypeController)DBControllersFactory.GetController<IdentificationTypeModel>();

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
            Mapper["CountryId"] = txtCountryId;
            Mapper["IdNumber"] = txtIdNumber;
            Mapper["IdTypeId"] = txtIdTypeId;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void ClientTypeFormLoad(object sender, EventArgs e) {
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
            txtIdTypeEnglish.Text = CntrlIT.Find(new IdentificationTypeModel() { Id = int.Parse(txtIdTypeId.Text) }, "Id")?.IdTypeEnglish;
        }

        private void TxtIssuingCountry_TextChanged(object sender, EventArgs e) {
            txtCountryEnglish.Text = CntrlCY.Find(new CountryModel() { Id =int.Parse(txtCountryId.Text) }, "Id")?.CountryEnglish;
        }
    }
    
}
