using MVCWinform.Common;
using MVCWinform.Utils;
using System;
using ViewWinform.Common;

namespace MVCWinform.Customers {
    [ForEntity(Entities.Contact)]
    public partial class ContactForm: ContactView {

         
        
        public ContactForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (ContactController)DBControllersFactory.GetController(Entities.Contact);
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
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            //this.txtMobileNumber.Text = selected;
            Model = Controller.Find(new ContactModel() { MobileNumber=selected }, "MobileNumber");
        }

        private void ContactFormLoad(object sender, EventArgs e) {
        }
    }
    public class ContactView : BaseView<ContactModel, ContactController> { }
}
