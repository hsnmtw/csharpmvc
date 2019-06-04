using MVCHIS.Common;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.Contact)]
    public partial class ContactForm: ContactView {

        public ContactForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["Email"] = txtEmail;
            Mapper["FaxNumber"] = txtFaxNumber;
            Mapper["PhoneNumber"] = txtPhoneNumber;
            Mapper["MobileNumber"] = txtMobileNumber;
            Mapper["FullName"] = txtFullName;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;

        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            Model = Controller.Find(new ContactModel() { MobileNumber = txtMobileNumber.Text }, "MobileNumber");
        }

        private void ContactFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }
    }
    
}
