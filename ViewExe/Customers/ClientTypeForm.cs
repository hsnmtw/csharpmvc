using MVCHIS.Common;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.ClientType)]
    public partial class ClientTypeForm: ClientTypeView {

         
        
        public ClientTypeForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //base.Controller = (ClientTypeController)DBControllersFactory.GetController(Common.MODELS.ClientType);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["ClientTypeCode"] = txtClientTypeCode;
            Mapper["ClientTypeEnglish"] = txtClientTypeEnglish;
            Mapper["ClientTypeArabic"] = txtClientTypeArabic;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            Model = Controller.Find(new ClientTypeModel() { Id = txtClientTypeCode.Text.ToInteger() }, "Id");

        }

        private void ClientTypeFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }
    }
    
}
