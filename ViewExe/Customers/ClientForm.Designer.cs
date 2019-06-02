namespace MVCHIS.Customers {
    partial class ClientForm {
        /// <summaryClient
        /// Required designer variable.
        /// </summaryClient
        private System.ComponentModel.IContainer components = null;

        /// <summaryClient
        /// Clean up any resources being used.
        /// </summaryClient
        /// <param name="disposing"Clienttrue if managed resources should be disposed; otherwise, false.</paramClient
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summaryClient
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summaryClient
        private void InitializeComponent(){
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtUpdatedOn = new System.Windows.Forms.TextBox();
            this.txtUpdatedBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreatedOn = new System.Windows.Forms.TextBox();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.lookUpButtonShortName = new MVCHIS.Common.LookUpButton();
            this.chkReadOnly = new MVCHIS.Utils.ForcedFocusCheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblMetaDataCountryEnglish = new System.Windows.Forms.Label();
            this.txtBillingAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtClientTypeId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLongName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lookUpButtonClientType = new MVCHIS.Common.LookUpButton();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtNameArabic = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.chkIsActive = new MVCHIS.Utils.ForcedFocusCheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtClientTypeCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFaxNumber = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpIdentifications = new System.Windows.Forms.TabPage();
            this.lstIdentifications = new MVCHIS.Utils.FixedWidthListBox();
            this.btnUnassociateIdentification = new System.Windows.Forms.Button();
            this.btnAddIdentification = new System.Windows.Forms.Button();
            this.btnOpenIdentification = new System.Windows.Forms.Button();
            this.tpContacts = new System.Windows.Forms.TabPage();
            this.lstContacts = new MVCHIS.Utils.FixedWidthListBox();
            this.btnUnassociateContact = new System.Windows.Forms.Button();
            this.btnOpenContact = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.txtCountryId = new System.Windows.Forms.TextBox();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lookUpButtonNationality = new MVCHIS.Common.LookUpButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.btnDateOfBirth = new System.Windows.Forms.Button();
            this.txtCountryEnglish = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tpIdentifications.SuspendLayout();
            this.tpContacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(445, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(553, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(661, 357);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 26;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedOn.Location = new System.Drawing.Point(608, 301);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 23;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedBy.Location = new System.Drawing.Point(534, 301);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 22;
            this.txtUpdatedBy.TabStop = false;
            this.txtUpdatedBy.Tag = "UpdatedBy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedOn.Location = new System.Drawing.Point(608, 275);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 21;
            this.txtCreatedOn.TabStop = false;
            this.txtCreatedOn.Tag = "";
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedBy.Location = new System.Drawing.Point(534, 275);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 20;
            this.txtCreatedBy.TabStop = false;
            this.txtCreatedBy.Tag = "CreatedBy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Created by";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(161, 23);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            this.txtId.Tag = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Record Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Short Name";
            // 
            // txtShortName
            // 
            this.txtShortName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtShortName.Location = new System.Drawing.Point(161, 50);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(129, 20);
            this.txtShortName.TabIndex = 1;
            this.txtShortName.Tag = "ShortName";
            // 
            // lookUpButtonShortName
            // 
            this.lookUpButtonShortName.AssociatedControl = "txtShortName";
            this.lookUpButtonShortName.Controller = "Client";
            this.lookUpButtonShortName.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonShortName.Location = new System.Drawing.Point(290, 49);
            this.lookUpButtonShortName.Name = "lookUpButtonShortName";
            this.lookUpButtonShortName.SelectedValueIndex = 0;
            this.lookUpButtonShortName.ShowFieldsInLookUp.Add("ShortName");
            this.lookUpButtonShortName.ShowFieldsInLookUp.Add("LongName");
            this.lookUpButtonShortName.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonShortName.TabIndex = 2;
            this.lookUpButtonShortName.TabStop = false;
            this.lookUpButtonShortName.LookUpSelected += new System.EventHandler(this.LookUpButtonShortNameLookUpSelected);
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(534, 328);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 24;
            this.chkReadOnly.Tag = "ReadOnly";
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(406, 328);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Read Only";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(146, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(146, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "?";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(146, 133);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "?";
            // 
            // lblMetaDataCountryEnglish
            // 
            this.lblMetaDataCountryEnglish.AutoSize = true;
            this.lblMetaDataCountryEnglish.ForeColor = System.Drawing.Color.Red;
            this.lblMetaDataCountryEnglish.Location = new System.Drawing.Point(146, 80);
            this.lblMetaDataCountryEnglish.Name = "lblMetaDataCountryEnglish";
            this.lblMetaDataCountryEnglish.Size = new System.Drawing.Size(12, 13);
            this.lblMetaDataCountryEnglish.TabIndex = 48;
            this.lblMetaDataCountryEnglish.Text = "?";
            // 
            // txtBillingAddress
            // 
            this.txtBillingAddress.BackColor = System.Drawing.Color.White;
            this.txtBillingAddress.Location = new System.Drawing.Point(161, 155);
            this.txtBillingAddress.Multiline = true;
            this.txtBillingAddress.Name = "txtBillingAddress";
            this.txtBillingAddress.Size = new System.Drawing.Size(211, 75);
            this.txtBillingAddress.TabIndex = 8;
            this.txtBillingAddress.Tag = "BillingAddress";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Billing Address";
            // 
            // txtClientTypeId
            // 
            this.txtClientTypeId.BackColor = System.Drawing.Color.White;
            this.txtClientTypeId.Location = new System.Drawing.Point(161, 128);
            this.txtClientTypeId.Name = "txtClientTypeId";
            this.txtClientTypeId.ReadOnly = true;
            this.txtClientTypeId.Size = new System.Drawing.Size(33, 20);
            this.txtClientTypeId.TabIndex = 6;
            this.txtClientTypeId.Tag = "ClientTypeCode";
            this.txtClientTypeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClientTypeId.TextChanged += new System.EventHandler(this.TxtClientTypeId_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "Client Type";
            // 
            // txtLongName
            // 
            this.txtLongName.BackColor = System.Drawing.Color.White;
            this.txtLongName.Location = new System.Drawing.Point(161, 75);
            this.txtLongName.Name = "txtLongName";
            this.txtLongName.Size = new System.Drawing.Size(212, 20);
            this.txtLongName.TabIndex = 3;
            this.txtLongName.Tag = "LongName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Long Name";
            // 
            // lookUpButtonClientType
            // 
            this.lookUpButtonClientType.AssociatedControl = "txtClientTypeId";
            this.lookUpButtonClientType.Controller = "ClientType";
            this.lookUpButtonClientType.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonClientType.Location = new System.Drawing.Point(195, 127);
            this.lookUpButtonClientType.Name = "lookUpButtonClientType";
            this.lookUpButtonClientType.SelectedValueIndex = 1;
            this.lookUpButtonClientType.ShowFieldsInLookUp.Add("ClientTypeCode");
            this.lookUpButtonClientType.ShowFieldsInLookUp.Add("Id");
            this.lookUpButtonClientType.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonClientType.TabIndex = 5;
            this.lookUpButtonClientType.TabStop = false;
            // 
            // txtWebsite
            // 
            this.txtWebsite.BackColor = System.Drawing.Color.White;
            this.txtWebsite.Location = new System.Drawing.Point(161, 236);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(211, 20);
            this.txtWebsite.TabIndex = 9;
            this.txtWebsite.Tag = "PhoneNumber";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(31, 239);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 13);
            this.label28.TabIndex = 47;
            this.label28.Text = "Website";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(146, 240);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(12, 13);
            this.label27.TabIndex = 48;
            this.label27.Text = "?";
            // 
            // txtNameArabic
            // 
            this.txtNameArabic.BackColor = System.Drawing.Color.White;
            this.txtNameArabic.Location = new System.Drawing.Point(161, 101);
            this.txtNameArabic.Name = "txtNameArabic";
            this.txtNameArabic.Size = new System.Drawing.Size(212, 20);
            this.txtNameArabic.TabIndex = 4;
            this.txtNameArabic.Tag = "LongName";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(31, 104);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 47;
            this.label24.Text = "Name Arabic";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(146, 106);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(12, 13);
            this.label25.TabIndex = 48;
            this.label25.Text = "?";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(31, 317);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 13);
            this.label26.TabIndex = 11;
            this.label26.Text = "Is Active";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(161, 317);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(15, 14);
            this.chkIsActive.TabIndex = 12;
            this.chkIsActive.Tag = "ReadOnly";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(31, 343);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 13);
            this.label30.TabIndex = 47;
            this.label30.Text = "Date of Birth";
            // 
            // txtClientTypeCode
            // 
            this.txtClientTypeCode.Enabled = false;
            this.txtClientTypeCode.Location = new System.Drawing.Point(218, 128);
            this.txtClientTypeCode.Name = "txtClientTypeCode";
            this.txtClientTypeCode.Size = new System.Drawing.Size(154, 20);
            this.txtClientTypeCode.TabIndex = 7;
            this.txtClientTypeCode.Tag = "ClientTypeCode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(146, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.White;
            this.txtPhoneNumber.Location = new System.Drawing.Point(161, 262);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(211, 20);
            this.txtPhoneNumber.TabIndex = 10;
            this.txtPhoneNumber.Tag = "PhoneNumber";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(146, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Fax Number";
            // 
            // txtFaxNumber
            // 
            this.txtFaxNumber.BackColor = System.Drawing.Color.White;
            this.txtFaxNumber.Location = new System.Drawing.Point(161, 288);
            this.txtFaxNumber.Name = "txtFaxNumber";
            this.txtFaxNumber.Size = new System.Drawing.Size(211, 20);
            this.txtFaxNumber.TabIndex = 11;
            this.txtFaxNumber.Tag = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpIdentifications);
            this.tabControl1.Controls.Add(this.tpContacts);
            this.tabControl1.Location = new System.Drawing.Point(409, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 252);
            this.tabControl1.TabIndex = 19;
            // 
            // tpIdentifications
            // 
            this.tpIdentifications.Controls.Add(this.lstIdentifications);
            this.tpIdentifications.Controls.Add(this.btnUnassociateIdentification);
            this.tpIdentifications.Controls.Add(this.btnAddIdentification);
            this.tpIdentifications.Controls.Add(this.btnOpenIdentification);
            this.tpIdentifications.Location = new System.Drawing.Point(4, 22);
            this.tpIdentifications.Name = "tpIdentifications";
            this.tpIdentifications.Padding = new System.Windows.Forms.Padding(3);
            this.tpIdentifications.Size = new System.Drawing.Size(328, 226);
            this.tpIdentifications.TabIndex = 0;
            this.tpIdentifications.Text = "Identification";
            this.tpIdentifications.UseVisualStyleBackColor = true;
            // 
            // lstIdentifications
            // 
            this.lstIdentifications.DataSource = null;
            this.lstIdentifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstIdentifications.Filter = null;
            this.lstIdentifications.Location = new System.Drawing.Point(3, 3);
            this.lstIdentifications.Name = "lstIdentifications";
            this.lstIdentifications.ShownColumns.Add("IdNumber");
            this.lstIdentifications.ShownColumns.Add("IdTypeId");
            this.lstIdentifications.ShownColumns.Add("ExpiryDate");
            this.lstIdentifications.ShownColumns.Add("CityId");
            this.lstIdentifications.Size = new System.Drawing.Size(322, 180);
            this.lstIdentifications.TabIndex = 0;
            // 
            // btnUnassociateIdentification
            // 
            this.btnUnassociateIdentification.Location = new System.Drawing.Point(8, 192);
            this.btnUnassociateIdentification.Name = "btnUnassociateIdentification";
            this.btnUnassociateIdentification.Size = new System.Drawing.Size(130, 23);
            this.btnUnassociateIdentification.TabIndex = 3;
            this.btnUnassociateIdentification.Text = "Unassociate";
            this.btnUnassociateIdentification.UseVisualStyleBackColor = true;
            // 
            // btnAddIdentification
            // 
            this.btnAddIdentification.Location = new System.Drawing.Point(245, 192);
            this.btnAddIdentification.Name = "btnAddIdentification";
            this.btnAddIdentification.Size = new System.Drawing.Size(75, 23);
            this.btnAddIdentification.TabIndex = 1;
            this.btnAddIdentification.Text = "Add";
            this.btnAddIdentification.UseVisualStyleBackColor = true;
            this.btnAddIdentification.Click += new System.EventHandler(this.BtnAddIdentification_Click);
            // 
            // btnOpenIdentification
            // 
            this.btnOpenIdentification.Location = new System.Drawing.Point(154, 192);
            this.btnOpenIdentification.Name = "btnOpenIdentification";
            this.btnOpenIdentification.Size = new System.Drawing.Size(75, 23);
            this.btnOpenIdentification.TabIndex = 2;
            this.btnOpenIdentification.Text = "Open";
            this.btnOpenIdentification.UseVisualStyleBackColor = true;
            // 
            // tpContacts
            // 
            this.tpContacts.Controls.Add(this.lstContacts);
            this.tpContacts.Controls.Add(this.btnUnassociateContact);
            this.tpContacts.Controls.Add(this.btnOpenContact);
            this.tpContacts.Controls.Add(this.btnAddContact);
            this.tpContacts.Location = new System.Drawing.Point(4, 22);
            this.tpContacts.Name = "tpContacts";
            this.tpContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tpContacts.Size = new System.Drawing.Size(328, 226);
            this.tpContacts.TabIndex = 1;
            this.tpContacts.Text = "Contact";
            this.tpContacts.UseVisualStyleBackColor = true;
            // 
            // lstContacts
            // 
            this.lstContacts.DataSource = null;
            this.lstContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstContacts.Filter = null;
            this.lstContacts.Location = new System.Drawing.Point(3, 3);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.ShownColumns.Add("MobileNumber");
            this.lstContacts.ShownColumns.Add("FullName");
            this.lstContacts.ShownColumns.Add("PhoneNumber");
            this.lstContacts.Size = new System.Drawing.Size(322, 180);
            this.lstContacts.TabIndex = 6;
            // 
            // btnUnassociateContact
            // 
            this.btnUnassociateContact.Location = new System.Drawing.Point(8, 192);
            this.btnUnassociateContact.Name = "btnUnassociateContact";
            this.btnUnassociateContact.Size = new System.Drawing.Size(130, 23);
            this.btnUnassociateContact.TabIndex = 3;
            this.btnUnassociateContact.Text = "Unassociate";
            this.btnUnassociateContact.UseVisualStyleBackColor = true;
            // 
            // btnOpenContact
            // 
            this.btnOpenContact.Location = new System.Drawing.Point(154, 192);
            this.btnOpenContact.Name = "btnOpenContact";
            this.btnOpenContact.Size = new System.Drawing.Size(75, 23);
            this.btnOpenContact.TabIndex = 4;
            this.btnOpenContact.Text = "Open";
            this.btnOpenContact.UseVisualStyleBackColor = true;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(245, 192);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(75, 23);
            this.btnAddContact.TabIndex = 5;
            this.btnAddContact.Text = "Add";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            // 
            // txtCountryId
            // 
            this.txtCountryId.BackColor = System.Drawing.Color.White;
            this.txtCountryId.Location = new System.Drawing.Point(161, 366);
            this.txtCountryId.Name = "txtCountryId";
            this.txtCountryId.ReadOnly = true;
            this.txtCountryId.Size = new System.Drawing.Size(43, 20);
            this.txtCountryId.TabIndex = 15;
            this.txtCountryId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCountryId.TextChanged += new System.EventHandler(this.TxtNationalityCode_TextChanged);
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.BackColor = System.Drawing.SystemColors.Control;
            this.txtCountryCode.Enabled = false;
            this.txtCountryCode.Location = new System.Drawing.Point(205, 366);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(37, 20);
            this.txtCountryCode.TabIndex = 16;
            this.txtCountryCode.Tag = "";
            this.txtCountryCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 369);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Nationality";
            // 
            // lookUpButtonNationality
            // 
            this.lookUpButtonNationality.AssociatedControl = "txtCountryId";
            this.lookUpButtonNationality.Controller = "Country";
            this.lookUpButtonNationality.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonNationality.Location = new System.Drawing.Point(351, 365);
            this.lookUpButtonNationality.Name = "lookUpButtonNationality";
            this.lookUpButtonNationality.SelectedValueIndex = 3;
            this.lookUpButtonNationality.ShowFieldsInLookUp.Add("CountryCode");
            this.lookUpButtonNationality.ShowFieldsInLookUp.Add("CountryEnglish");
            this.lookUpButtonNationality.ShowFieldsInLookUp.Add("CountryArabic");
            this.lookUpButtonNationality.ShowFieldsInLookUp.Add("Id");
            this.lookUpButtonNationality.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonNationality.TabIndex = 18;
            this.lookUpButtonNationality.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(146, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "?";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.BackColor = System.Drawing.Color.White;
            this.txtDateOfBirth.Location = new System.Drawing.Point(161, 338);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(103, 20);
            this.txtDateOfBirth.TabIndex = 13;
            this.txtDateOfBirth.Tag = "yyyy-MM-dd";
            this.txtDateOfBirth.Leave += new System.EventHandler(this.TxtDateOfBirth_Leave);
            // 
            // btnDateOfBirth
            // 
            this.btnDateOfBirth.Enabled = false;
            this.btnDateOfBirth.Location = new System.Drawing.Point(264, 337);
            this.btnDateOfBirth.Name = "btnDateOfBirth";
            this.btnDateOfBirth.Size = new System.Drawing.Size(23, 22);
            this.btnDateOfBirth.TabIndex = 14;
            this.btnDateOfBirth.TabStop = false;
            this.btnDateOfBirth.Tag = "CALENDAR";
            this.btnDateOfBirth.Text = "📅";
            this.btnDateOfBirth.UseVisualStyleBackColor = true;
            this.btnDateOfBirth.Click += new System.EventHandler(this.BtnDateOfBirth_Click);
            // 
            // txtCountryEnglish
            // 
            this.txtCountryEnglish.BackColor = System.Drawing.SystemColors.Control;
            this.txtCountryEnglish.Enabled = false;
            this.txtCountryEnglish.Location = new System.Drawing.Point(243, 366);
            this.txtCountryEnglish.Name = "txtCountryEnglish";
            this.txtCountryEnglish.Size = new System.Drawing.Size(108, 20);
            this.txtCountryEnglish.TabIndex = 17;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDateOfBirth);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtFaxNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBillingAddress);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lblMetaDataCountryEnglish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtShortName);
            this.Controls.Add(this.lookUpButtonShortName);
            this.Controls.Add(this.lookUpButtonNationality);
            this.Controls.Add(this.lookUpButtonClientType);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameArabic);
            this.Controls.Add(this.txtLongName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCountryEnglish);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.txtCountryId);
            this.Controls.Add(this.txtClientTypeCode);
            this.Controls.Add(this.txtClientTypeId);
            this.Name = "ClientForm";
            this.Size = new System.Drawing.Size(771, 402);
            this.Load += new System.EventHandler(this.ClientTypeFormLoad);
            this.tabControl1.ResumeLayout(false);
            this.tpIdentifications.ResumeLayout(false);
            this.tpContacts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtUpdatedOn;
        private System.Windows.Forms.TextBox txtUpdatedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreatedOn;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShortName;
        private Common.LookUpButton lookUpButtonShortName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMetaDataCountryEnglish;
        private System.Windows.Forms.TextBox txtLongName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBillingAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtClientTypeId;
        private System.Windows.Forms.Label label17;
        private Common.LookUpButton lookUpButtonClientType;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNameArabic;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtClientTypeCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFaxNumber;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpIdentifications;
        private System.Windows.Forms.TabPage tpContacts;
        private System.Windows.Forms.Button btnUnassociateIdentification;
        private System.Windows.Forms.Button btnOpenIdentification;
        private System.Windows.Forms.Button btnAddIdentification;
        private MVCHIS.Utils.FixedWidthListBox lstIdentifications;
        private MVCHIS.Utils.FixedWidthListBox lstContacts;
        private System.Windows.Forms.Button btnUnassociateContact;
        private System.Windows.Forms.Button btnOpenContact;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.TextBox txtCountryId;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.Label label13;
        private Common.LookUpButton lookUpButtonNationality;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Button btnDateOfBirth;
        private System.Windows.Forms.TextBox txtCountryEnglish;
    }
}