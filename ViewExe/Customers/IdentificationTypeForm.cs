using MVCHIS.Common;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.IdentificationType)]
    public partial class IdentificationTypeForm: IdentificationTypeView {

        
        
        public IdentificationTypeForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;;
            base.Controller = (IdentificationTypeController)DBControllersFactory.GetController(Common.MODELS.IdentificationType);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["IdTypeCode"] = txtIdTypeCode;
            Mapper["IdTypeEnglish"] = txtIdTypeEnglish;
            Mapper["IdTypeArabic"] = txtIdTypeArabic;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new IdentificationTypeModel() { IdTypeCode = selected }, "IdTypeCode");
        }

        private void IdentificationTypeFormLoad(object sender, EventArgs e) {
        }
    }
    
}
