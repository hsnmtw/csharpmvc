namespace MVCHIS.Customers {
    partial class IdentificationForm {
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
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.lookUpButtonShortName = new MVCHIS.Common.LookUpButton();
            this.btnExpiryDate = new System.Windows.Forms.Button();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtIdType = new System.Windows.Forms.TextBox();
            this.lookUpButtonIdentificationType = new MVCHIS.Common.LookUpButton();
            this.lookUpButtonCountryOfIssue = new MVCHIS.Common.LookUpButton();
            this.txtIssuingCountry = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnIssueDateCalendar = new System.Windows.Forms.Button();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblIdTypeEnglish = new System.Windows.Forms.Label();
            this.lblIssueDateHG = new System.Windows.Forms.Label();
            this.lblExpiryDateHG = new System.Windows.Forms.Label();
            this.lblIssuingCountryEnglish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(70, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(178, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(286, 295);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedOn.Location = new System.Drawing.Point(233, 233);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 19;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedBy.Location = new System.Drawing.Point(159, 233);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 18;
            this.txtUpdatedBy.TabStop = false;
            this.txtUpdatedBy.Tag = "UpdatedBy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedOn.Location = new System.Drawing.Point(233, 206);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 17;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedBy.Location = new System.Drawing.Point(159, 206);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 16;
            this.txtCreatedBy.TabStop = false;
            this.txtCreatedBy.Tag = "CreatedBy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Created by";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(159, 23);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            this.txtId.Tag = "Id";
            this.txtId.Text = "0";
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
            // txtIdNumber
            // 
            this.txtIdNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdNumber.Location = new System.Drawing.Point(159, 50);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(103, 20);
            this.txtIdNumber.TabIndex = 1;
            this.txtIdNumber.Tag = "ShortName";
            // 
            // lookUpButtonShortName
            // 
            this.lookUpButtonShortName.AssociatedControl = "txtIdNumber";
            this.lookUpButtonShortName.Controller = "Identification";
            this.lookUpButtonShortName.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonShortName.Location = new System.Drawing.Point(265, 49);
            this.lookUpButtonShortName.Name = "lookUpButtonShortName";
            this.lookUpButtonShortName.SelectedValueIndex = 0;
            this.lookUpButtonShortName.ShowFieldsInLookUp.Add("IdNumber");
            this.lookUpButtonShortName.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonShortName.TabIndex = 2;
            this.lookUpButtonShortName.TabStop = false;
            this.lookUpButtonShortName.LookUpSelected += new System.EventHandler(this.LookUpButtonShortNameLookUpSelected);
            // 
            // btnExpiryDate
            // 
            this.btnExpiryDate.Enabled = false;
            this.btnExpiryDate.Location = new System.Drawing.Point(264, 130);
            this.btnExpiryDate.Name = "btnExpiryDate";
            this.btnExpiryDate.Size = new System.Drawing.Size(23, 22);
            this.btnExpiryDate.TabIndex = 10;
            this.btnExpiryDate.TabStop = false;
            this.btnExpiryDate.Tag = "txtExpiryDate";
            this.btnExpiryDate.Text = "📅";
            this.btnExpiryDate.UseVisualStyleBackColor = true;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(159, 260);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 20;
            this.chkReadOnly.Tag = "ReadOnly";
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 260);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Read Only";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(145, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "?";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(31, 130);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "Expiry Date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(31, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Type";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Number";
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.BackColor = System.Drawing.Color.White;
            this.txtExpiryDate.Location = new System.Drawing.Point(159, 131);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(103, 20);
            this.txtExpiryDate.TabIndex = 9;
            this.txtExpiryDate.Tag = "yyyy-MM-dd";
            this.txtExpiryDate.Leave += new System.EventHandler(this.TxtExpiryDate_Leave);
            // 
            // txtIdType
            // 
            this.txtIdType.BackColor = System.Drawing.Color.White;
            this.txtIdType.Location = new System.Drawing.Point(159, 77);
            this.txtIdType.Name = "txtIdType";
            this.txtIdType.ReadOnly = true;
            this.txtIdType.Size = new System.Drawing.Size(55, 20);
            this.txtIdType.TabIndex = 3;
            this.txtIdType.Tag = "PhoneNumber";
            this.txtIdType.TextChanged += new System.EventHandler(this.TxtIdType_TextChanged);
            // 
            // lookUpButtonIdentificationType
            // 
            this.lookUpButtonIdentificationType.AssociatedControl = "txtIdType";
            this.lookUpButtonIdentificationType.Controller = "IdentificationType";
            this.lookUpButtonIdentificationType.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonIdentificationType.Location = new System.Drawing.Point(217, 76);
            this.lookUpButtonIdentificationType.Name = "lookUpButtonIdentificationType";
            this.lookUpButtonIdentificationType.SelectedValueIndex = 0;
            this.lookUpButtonIdentificationType.ShowFieldsInLookUp.Add("IdTypeCode");
            this.lookUpButtonIdentificationType.ShowFieldsInLookUp.Add("IdTypeEnglish");
            this.lookUpButtonIdentificationType.ShowFieldsInLookUp.Add("IdTypeArabic");
            this.lookUpButtonIdentificationType.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonIdentificationType.TabIndex = 4;
            this.lookUpButtonIdentificationType.TabStop = false;
            this.lookUpButtonIdentificationType.Tag = "lblIdTypeEnglish";
            // 
            // lookUpButtonCountryOfIssue
            // 
            this.lookUpButtonCountryOfIssue.AssociatedControl = "txtIssuingCountry";
            this.lookUpButtonCountryOfIssue.Controller = "Country";
            this.lookUpButtonCountryOfIssue.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonCountryOfIssue.Location = new System.Drawing.Point(217, 155);
            this.lookUpButtonCountryOfIssue.Name = "lookUpButtonCountryOfIssue";
            this.lookUpButtonCountryOfIssue.SelectedValueIndex = 0;
            this.lookUpButtonCountryOfIssue.ShowFieldsInLookUp.Add("CountryCode");
            this.lookUpButtonCountryOfIssue.ShowFieldsInLookUp.Add("CountryEnglish");
            this.lookUpButtonCountryOfIssue.ShowFieldsInLookUp.Add("CountryArabic");
            this.lookUpButtonCountryOfIssue.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonCountryOfIssue.TabIndex = 13;
            this.lookUpButtonCountryOfIssue.TabStop = false;
            this.lookUpButtonCountryOfIssue.Tag = "lblIssuingCountryEnglish";
            // 
            // txtIssuingCountry
            // 
            this.txtIssuingCountry.BackColor = System.Drawing.Color.White;
            this.txtIssuingCountry.Location = new System.Drawing.Point(159, 156);
            this.txtIssuingCountry.Name = "txtIssuingCountry";
            this.txtIssuingCountry.ReadOnly = true;
            this.txtIssuingCountry.Size = new System.Drawing.Size(55, 20);
            this.txtIssuingCountry.TabIndex = 12;
            this.txtIssuingCountry.Tag = "PhoneNumber";
            this.txtIssuingCountry.TextChanged += new System.EventHandler(this.TxtIssuingCountry_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(31, 156);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "Coutry of Issue";
            // 
            // btnIssueDateCalendar
            // 
            this.btnIssueDateCalendar.Enabled = false;
            this.btnIssueDateCalendar.Location = new System.Drawing.Point(264, 103);
            this.btnIssueDateCalendar.Name = "btnIssueDateCalendar";
            this.btnIssueDateCalendar.Size = new System.Drawing.Size(23, 22);
            this.btnIssueDateCalendar.TabIndex = 7;
            this.btnIssueDateCalendar.TabStop = false;
            this.btnIssueDateCalendar.Tag = "txtIssueDate";
            this.btnIssueDateCalendar.Text = "📅";
            this.btnIssueDateCalendar.UseVisualStyleBackColor = true;
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.BackColor = System.Drawing.Color.White;
            this.txtIssueDate.Location = new System.Drawing.Point(159, 104);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(103, 20);
            this.txtIssueDate.TabIndex = 6;
            this.txtIssueDate.Tag = "yyyy-MM-dd";
            this.txtIssueDate.Leave += new System.EventHandler(this.TxtIssueDate_Leave);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(31, 104);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 13);
            this.label29.TabIndex = 47;
            this.label29.Text = "Issue Date";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(31, 182);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 13);
            this.label26.TabIndex = 50;
            this.label26.Text = "Is Active";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Enabled = false;
            this.chkIsActive.Location = new System.Drawing.Point(159, 185);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(15, 14);
            this.chkIsActive.TabIndex = 15;
            this.chkIsActive.Tag = "ReadOnly";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblIdTypeEnglish
            // 
            this.lblIdTypeEnglish.AutoSize = true;
            this.lblIdTypeEnglish.Location = new System.Drawing.Point(243, 81);
            this.lblIdTypeEnglish.Name = "lblIdTypeEnglish";
            this.lblIdTypeEnglish.Size = new System.Drawing.Size(11, 13);
            this.lblIdTypeEnglish.TabIndex = 51;
            this.lblIdTypeEnglish.Text = "-";
            // 
            // lblIssueDateHG
            // 
            this.lblIssueDateHG.AutoSize = true;
            this.lblIssueDateHG.Location = new System.Drawing.Point(293, 108);
            this.lblIssueDateHG.Name = "lblIssueDateHG";
            this.lblIssueDateHG.Size = new System.Drawing.Size(11, 13);
            this.lblIssueDateHG.TabIndex = 51;
            this.lblIssueDateHG.Text = "-";
            // 
            // lblExpiryDateHG
            // 
            this.lblExpiryDateHG.AutoSize = true;
            this.lblExpiryDateHG.Location = new System.Drawing.Point(293, 135);
            this.lblExpiryDateHG.Name = "lblExpiryDateHG";
            this.lblExpiryDateHG.Size = new System.Drawing.Size(11, 13);
            this.lblExpiryDateHG.TabIndex = 51;
            this.lblExpiryDateHG.Text = "-";
            // 
            // lblIssuingCountryEnglish
            // 
            this.lblIssuingCountryEnglish.AutoSize = true;
            this.lblIssuingCountryEnglish.Location = new System.Drawing.Point(242, 159);
            this.lblIssuingCountryEnglish.Name = "lblIssuingCountryEnglish";
            this.lblIssuingCountryEnglish.Size = new System.Drawing.Size(11, 13);
            this.lblIssuingCountryEnglish.TabIndex = 51;
            this.lblIssuingCountryEnglish.Text = "-";
            // 
            // IdentificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 343);
            this.Controls.Add(this.lblIssuingCountryEnglish);
            this.Controls.Add(this.lblExpiryDateHG);
            this.Controls.Add(this.lblIssueDateHG);
            this.Controls.Add(this.lblIdTypeEnglish);
            this.Controls.Add(this.btnIssueDateCalendar);
            this.Controls.Add(this.btnExpiryDate);
            this.Controls.Add(this.txtIdType);
            this.Controls.Add(this.txtIssuingCountry);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtIssueDate);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lookUpButtonCountryOfIssue);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lookUpButtonIdentificationType);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdNumber);
            this.Controls.Add(this.lookUpButtonShortName);
            this.Controls.Add(this.txtId);
            this.Name = "IdentificationForm";
            this.Text = "Identification";
            this.Load += new System.EventHandler(this.ClientTypeFormLoad);
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
        private Common.LookUpButton lookUpButtonShortName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtIdType;
        private System.Windows.Forms.TextBox txtIdNumber;
        private Common.LookUpButton lookUpButtonIdentificationType;
        private System.Windows.Forms.Button btnExpiryDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtIssuingCountry;
        private Common.LookUpButton lookUpButtonCountryOfIssue;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnIssueDateCalendar;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblIdTypeEnglish;
        private System.Windows.Forms.Label lblIssueDateHG;
        private System.Windows.Forms.Label lblExpiryDateHG;
        private System.Windows.Forms.Label lblIssuingCountryEnglish;
    }
}