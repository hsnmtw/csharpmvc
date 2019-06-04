using MVCHIS.Common;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.IdentificationType)]
    public partial class IdentificationTypeForm: IdentificationTypeView {

        public IdentificationTypeForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["IdentificationTypeCode"] = txtIdentificationTypeCode;
            Mapper["IdentificationTypeEnglish"] = txtIdentificationTypeEnglish;
            Mapper["IdentificationTypeArabic"] = txtIdentificationTypeArabic;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            Model = Controller.Find(new IdentificationTypeModel() { Id = txtIdentificationTypeCode.Text.ToInteger() }, "Id");
        }

        private void IdentificationTypeFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;

        }
    }
    
}
