using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using ViewWinform.Common;

namespace MVCHIS.Customers {
    [ForModel(Common.MODELS.Identification)]
    public partial class IdentificationForm: IdentificationView {

        
        
        public IdentificationForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            base.Controller = (IdentificationController)DBControllersFactory.GetController(Common.MODELS.Identification);
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
            Mapper["IssuingCountry"] = txtIssuingCountry;
            Mapper["IdNumber"] = txtIdNumber;
            Mapper["IdType"] = txtIdType;
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
    }
    public class IdentificationView : BaseView<IdentificationModel, IdentificationController> { }
}
