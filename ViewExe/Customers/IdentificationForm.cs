using MVCHIS.Common;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.Identification)]
    public partial class IdentificationForm: IdentificationView {

        
        
        public IdentificationForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;;
            base.Controller = (IdentificationController)DBControllersFactory.GetController(Common.MODELS.Identification);
            Controllers = new System.Collections.Generic.Dictionary<string, IDBController> {
                ["c" ]  = DBControllersFactory.GetController(Common.MODELS.Country),
                ["it"] = DBControllersFactory.GetController(Common.MODELS.IdentificationType),
            };
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
            txtIdTypeEnglish.Text = Controllers["it"].Find(new IdentificationTypeModel() { Id = int.Parse(txtIdTypeId.Text) }, "Id")?.IdTypeEnglish;
        }

        private void TxtIssuingCountry_TextChanged(object sender, EventArgs e) {
            txtCountryEnglish.Text = Controllers["c"].Find(new CountryModel() { Id =int.Parse(txtCountryId.Text) }, "Id")?.CountryEnglish;
        }
    }
    
}
