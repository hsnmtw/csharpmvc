using MVCHIS.Common;
using MVCHIS.Tools;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.Client)]
    public partial class ClientForm: ClientView {

        private ClientTypeController            CntrlCT;
        private ContactController               CntrlCO;
        private ClientContactController         CntrlCC;
        private IdentificationController        CntrlID;
        private ClientIdentificationController  CntrlCI;
        private CountryController               CntrlCY;


        public ClientForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["ClientTypeId"] = txtClientTypeId;
            Mapper["ShortName"] = txtShortName;
            Mapper["LongName"] = txtLongName;
            Mapper["NameArabic"] = txtNameArabic;
            Mapper["DateOfBirth"] = txtDateOfBirth;
            Mapper["IsActive"] = chkIsActive;
            Mapper["BillingAddress"] = txtBillingAddress;
            Mapper["PhoneNumber"] = txtPhoneNumber;
            Mapper["FaxNumber"] = txtFaxNumber;
            Mapper["Website"] = txtWebsite;
            Mapper["CountryId"] = txtCountryId;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void ClientTypeFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;

            CntrlCT = (ClientTypeController)DBControllersFactory.GetController<ClientTypeModel>();
            CntrlCO = (ContactController)DBControllersFactory.GetController<ContactModel>();
            CntrlCC = (ClientContactController)DBControllersFactory.GetController<ClientContactModel>();
            CntrlID = (IdentificationController)DBControllersFactory.GetController<IdentificationModel>();
            CntrlCI = (ClientIdentificationController)DBControllersFactory.GetController<ClientIdentificationModel>();
            CntrlCY = (CountryController)DBControllersFactory.GetController<CountryModel>();

            ModelChanged = delegate () {
                RequeryIdentification();
                RequeryContact();
            };

            foreach (Control tab in this.tabControl1.TabPages) FormsHelper.ApplyLanguageLocalization(tab);
        }

        private void LookUpButtonShortNameLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new ClientModel() { ShortName = selected }, "ShortName");
        }

        private void TxtClientTypeId_TextChanged(object sender, EventArgs e) {
           // txtClientType.Text = "";
            txtClientTypeCode.Text = CntrlCT.Find(new ClientTypeModel() { Id = int.Parse($"0{txtClientTypeId.Text}") }, "Id")?.ClientTypeCode;
        }

        private void BtnAddIdentification_Click(object sender, EventArgs e) {
            var form = new Form();
            var view = ((IdentificationForm)DBViewsFactory.GetView(Common.MODELS.Identification));
            view.AfterSave = delegate(bool status) {
                CntrlCI.Save(new ClientIdentificationModel() {
                    ClientId = this.Model.Id,
                    IdentificationId = view.Model.Id
                });
                form.DialogResult = DialogResult.OK;
                form.Close();
                RequeryIdentification();
            };
            form.Controls.Add(view);
            form.Size = new System.Drawing.Size(430, 430);
            form.Show();
        }

        private void RequeryIdentification() {
            var identifications = from record
                        in CntrlCI.Read(new ClientIdentificationModel() { ClientId = Model.Id }, "ClientId")
                                  select record.IdentificationId;
            var source = CntrlID.GetDataById(identifications);
            this.lstIdentifications.DataSource = source;
            this.lstIdentifications.Requery();
        }

        private void RequeryContact() {
            var contacts = from record
                        in CntrlCC.Read(new ClientContactModel() { ClientId = Model.Id }, "ClientId")
                                  select record.ContactId;
            var source = CntrlCO.GetDataById(contacts);
            this.lstContacts.DataSource = source;
            this.lstContacts.Requery();
        }

        private ContactForm ContactFormView;
        private void BtnAddContact_Click(object sender, EventArgs e) {
            var form = new Form() { Text = "Add Contact" };
            ContactFormView = ((ContactForm)DBViewsFactory.GetView(Common.MODELS.Contact));
            ContactFormView.AfterSave = AfterModelSave;
            ContactFormView.Dock = DockStyle.Fill;
            form.Controls.Add(ContactFormView);
            form.Size = new System.Drawing.Size(430, 430);
            form.Show();
        }

        private void AfterModelSave(bool status) {
            if (!status) return;
            CntrlCC.Save(new ClientContactModel() {
                ClientId = Model.Id,
                ContactId = ContactFormView.Model.Id
            });
            RequeryContact();
        }

        private void TxtNationalityCode_TextChanged(object sender, EventArgs e) {
            var country = CntrlCY.FindById(new int[] { int.Parse($"0{txtCountryId.Text}") } ).FirstOrDefault();
            txtCountryCode.Text = country?.CountryCode;
            txtCountryEnglish.Text = country?.CountryEnglish;
        }

        private void BtnDateOfBirth_Click(object sender, EventArgs e) {

        }

        private void TxtDateOfBirth_Leave(object sender, EventArgs e) {
            ValidateDate(txtDateOfBirth);
        }
    }
    
}
