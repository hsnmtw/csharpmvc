using MVCHIS.Common;
using MVCHIS.Tools;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MVCHIS.Customers {
    [ForModel(Common.MODELS.Client)]
    public partial class ClientForm: ClientView {

        public ClientForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;;
            base.Controller   = (ClientController)DBControllersFactory.GetController(Common.MODELS.Client);

            Controllers = new System.Collections.Generic.Dictionary<string, IDBController> { 
                ["ct"]  = DBControllersFactory.GetController(Common.MODELS.ClientType),
                ["c"]   = DBControllersFactory.GetController(Common.MODELS.Contact),
                ["cc"]  = DBControllersFactory.GetController(Common.MODELS.ClientContact),
                ["i"]   = DBControllersFactory.GetController(Common.MODELS.Identification),
                ["ci"]  = DBControllersFactory.GetController(Common.MODELS.ClientIdentification),
                ["n"]   = DBControllersFactory.GetController(Common.MODELS.Country),
            };

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
            txtClientType.Text = Controllers["ct"].Find(new ClientTypeModel() { Id = int.Parse($"0{txtClientTypeId.Text}") }, "Id")?.ClientType;
        }

        private void BtnAddIdentification_Click(object sender, EventArgs e) {
            var form = ((IdentificationForm)DBViewsFactory.GetView(Common.MODELS.Identification));
            form.AfterSave = delegate() {
                _ = Controllers["ci"].Save(new ClientIdentificationModel() {
                    ClientId = this.Model.Id,
                    IdentificationId = form.Model.Id
                });
                form.DialogResult = DialogResult.OK;
                form.Close();
                RequeryIdentification();
            };
            form.Show();
        }

        private void RequeryIdentification() {
            var identifications = from record
                        in Controllers["ci"].Read(new ClientIdentificationModel() { ClientId = Model.Id }, "ClientId")
                                  select record.IdentificationId;
            var source = Controllers["i"].GetDataById<IdentificationModel>(identifications);
            this.lstIdentifications.DataSource = source;
            this.lstIdentifications.Requery();
        }

        private void RequeryContact() {
            var contacts = from record
                        in Controllers["cc"].Read(new ClientContactModel() { ClientId = Model.Id }, "ClientId")
                                  select record.ContactId;
            var source = Controllers["c"].GetDataById<ContactModel>(contacts);
            this.lstContacts.DataSource = source;
            this.lstContacts.Requery();
        }

        private void BtnAddContact_Click(object sender, EventArgs e) {
            var form = ((ContactForm)DBViewsFactory.GetView(Common.MODELS.Contact));
            form.AfterSave = delegate () {
                Controllers["cc"].Save(new ClientContactModel() {
                    ClientId  = Model.Id,
                    ContactId = form.Model.Id
                });
                form.DialogResult = DialogResult.OK;
                form.Close();
                RequeryContact();
            };
            form?.Show();
        }

        private void TxtNationalityCode_TextChanged(object sender, EventArgs e) {
            txtNationalityDesc.Text = Controllers["n"].Find(new CountryModel() { CountryCode = txtNationalityCode.Text }, "CountryCode")?.CountryEnglish;
        }

        private void BtnDateOfBirth_Click(object sender, EventArgs e) {

        }

        private void TxtDateOfBirth_Leave(object sender, EventArgs e) {
            ValidateDate(txtDateOfBirth);
        }
    }
    public class ClientView : BaseView<ClientModel, ClientController> { }
}
