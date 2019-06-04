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
        }

        public override void LoadForeignKeys(ForeignKeys FK) {
            FK.Put(DBControllersFactory.GetController<CityModel>());
            FK.Put(DBControllersFactory.GetController<IdentificationTypeModel>());
            base.LoadForeignKeys(FK);
        }

        private void ClientTypeFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        private void LookUpButtonShortNameLookUpSelected(object sender, EventArgs e) {
            Model = Controller.Find(new IdentificationModel() { Id = txtIdentificationNumber.Text.ToInteger() }, "Id");
        }

        private void TxtIssueDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtIssueDate);
        }

        private void TxtExpiryDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtExpiryDate);
        }

        private void TxtIdentificationType_TextChanged(object sender, EventArgs e) {
            txtIdentificationTypeEnglish.Text = ForeignKeys.Instance[MODELS.IdentificationType, txtIdentificationTypeId.Text];
        }

        private void TxtCityId_TextChanged(object sender, EventArgs e) {
            txtCityEnglish.Text = ForeignKeys.Instance[MODELS.City, txtCityId.Text];
        }
    }
    
}
