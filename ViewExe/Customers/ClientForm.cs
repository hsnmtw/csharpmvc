using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Windows.Forms;
using ViewWinform.Common;

namespace MVCHIS.Customers {
    [ForEntity(Entities.Client)]
    public partial class ClientForm: ClientView {

        private ClientTypeController ctController;
        private ClientIdentificationController ciController;
        private IdentificationController iController;
        private ContactController cController;
        private ClientContactController ccController;
        private CountryController nController;


        public ClientForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller   = (ClientController)              DBControllersFactory.GetController(Entities.Client);
            ctController = (ClientTypeController)          DBControllersFactory.GetController(Entities.ClientType);
            cController  = (ContactController)             DBControllersFactory.GetController(Entities.Contact);
            ccController = (ClientContactController)       DBControllersFactory.GetController(Entities.ClientContact);
            iController  = (IdentificationController)      DBControllersFactory.GetController(Entities.Identification);
            ciController = (ClientIdentificationController)DBControllersFactory.GetController(Entities.ClientIdentification);
            nController  = (CountryController)             DBControllersFactory.GetController(Entities.Country);

            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["ClientTypeId"  ] = txtClientTypeId;
            Mapper["ShortName"     ] = txtShortName;
            Mapper["LongName"      ] = txtLongName;
            Mapper["NameArabic"    ] = txtNameArabic;
            Mapper["DateOfBirth"   ] = txtDateOfBirth;
            Mapper["IsActive"      ] = chkIsActive;
            Mapper["BillingAddress"] = txtBillingAddress;
            Mapper["PhoneNumber"   ] = txtPhoneNumber;
            Mapper["FaxNumber"     ] = txtFaxNumber;
            Mapper["Website"       ] = txtWebsite;
            Mapper["Nationality"   ] = txtNationalityCode;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            ModelChanged = delegate () {
                RequeryIdentification();
                RequeryContact(); 
            };
        }

        private void ClientTypeFormLoad(object sender, EventArgs e) {
            foreach(Control tab in this.tabControl1.TabPages) FormsHelper.ApplyLanguageLocalization(tab);
        }

        private void LookUpButtonShortNameLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new ClientModel() { ShortName = selected }, "ShortName");
        }

        private void TxtClientTypeId_TextChanged(object sender, EventArgs e) {
           // txtClientType.Text = "";
            txtClientType.Text = ctController.Find(new ClientTypeModel() { Id = int.Parse($"0{txtClientTypeId.Text}") }, "Id")?.ClientType;
        }

        private void BtnAddIdentification_Click(object sender, EventArgs e) {
            var form = ((IdentificationForm)DBViewsFactory.GetView(Entities.Identification));
            form.AfterSave = delegate() {
                _ = ciController.Save(new ClientIdentificationModel() {
                    ClientId = this.Model.Id,
                    IdentificationId = form.Model.Id
                });
                form.DialogResult = DialogResult.OK;
                form.Close();
            };
            if (form.ShowDialog() == DialogResult.OK) {
                RequeryIdentification();
            }
        }

        private void RequeryIdentification() {
            var identifications = from record
                        in ciController.Read(new ClientIdentificationModel() { ClientId = Model.Id }, "ClientId")
                                  select record.IdentificationId;
            var source = iController.GetDataById<IdentificationModel>(identifications);
            this.lstIdentifications.DataSource = source;
            this.lstIdentifications.Requery();
        }

        private void RequeryContact() {
            var contacts = from record
                        in ccController.Read(new ClientContactModel() { ClientId = Model.Id }, "ClientId")
                                  select record.ContactId;
            var source = cController.GetDataById<ContactModel>(contacts);
            this.lstContacts.DataSource = source;
            this.lstContacts.Requery();
        }

        private void BtnAddContact_Click(object sender, EventArgs e) {
            var form = ((ContactForm)DBViewsFactory.GetView(Entities.Contact));
            form.AfterSave = delegate () {
                _ = ccController.Save(new ClientContactModel() {
                    ClientId = this.Model.Id,
                    ContactId = form.Model.Id
                });
                form.DialogResult = DialogResult.OK;
                form.Close();
            };
            if (form.ShowDialog() == DialogResult.OK) {
                RequeryContact();
            }
        }

        private void TxtNationalityCode_TextChanged(object sender, EventArgs e) {
            txtNationalityDesc.Text = nController.Find(new CountryModel() { CountryCode = txtNationalityCode.Text }, "CountryCode")?.CountryEnglish;
        }
    }
    public class ClientView : BaseView<ClientModel, ClientController> { }
}
