using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using ViewWinform.Common;

namespace MVCHIS.Customers {
    [ForEntity(Entities.IdentificationType)]
    public partial class IdentificationTypeForm: IdentificationTypeView {

        
        
        public IdentificationTypeForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (IdentificationTypeController)DBControllersFactory.GetController(Entities.IdentificationType);
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
    public class IdentificationTypeView : BaseView<IdentificationTypeModel, IdentificationTypeController> { }
}
