using MVCHIS.Common;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.Identification)]
    public partial class IdentificationForm: IdentificationView {

        public IdentificationForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
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
            Mapper["IdentificationNumber"] = txtIdentificationNumber;
            Mapper["IdentificationTypeId"] = txtIdentificationTypeId;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            //pick lists
            PickList[btnPLCity] = txtCityId;
            PickList[btnPLIdentification] = txtId;
            PickList[btnPLIdentificationType] = txtIdentificationTypeId;
        }

        private void ClientTypeFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        private void PickListButtonShortNameLookUpSelected(int id) {
        }

        private void TxtIssueDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtIssueDate);
        }

        private void TxtExpiryDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtExpiryDate);
        }

        private void TxtIdentificationType_TextChanged(object sender, EventArgs e) {
            txtIdentificationTypeEnglish.Text = DBControllersFactory.FK(MODELS.IdentificationType, txtIdentificationTypeId.Text);
        }

        private void TxtCityId_TextChanged(object sender, EventArgs e) {
            txtCityEnglish.Text = DBControllersFactory.FK(MODELS.City, txtCityId.Text);
        }

        
    }
    
}
