﻿namespace MVCHIS.Customers {
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
            this.txtIdentificationNumber = new System.Windows.Forms.TextBox();
            this.btnPLIdentification = new MVCHIS.Common.PickListButton();
            this.btnExpiryDate = new System.Windows.Forms.Button();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtIdentificationTypeId = new System.Windows.Forms.TextBox();
            this.btnPLIdentificationType = new MVCHIS.Common.PickListButton();
            this.btnPLCity = new MVCHIS.Common.PickListButton();
            this.txtCityId = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnIssueDateCalendar = new System.Windows.Forms.Button();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblIssueDateHG = new System.Windows.Forms.Label();
            this.lblExpiryDateHG = new System.Windows.Forms.Label();
            this.txtCityEnglish = new System.Windows.Forms.TextBox();
            this.txtIdentificationTypeEnglish = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(70, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(178, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(286, 321);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.Location = new System.Drawing.Point(233, 259);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 19;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.Location = new System.Drawing.Point(159, 259);
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
            this.label6.Location = new System.Drawing.Point(19, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Location = new System.Drawing.Point(233, 232);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 17;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(159, 232);
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
            this.label5.Location = new System.Drawing.Point(19, 234);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Record Id";
            // 
            // txtIdentificationNumber
            // 
            this.txtIdentificationNumber.Location = new System.Drawing.Point(159, 50);
            this.txtIdentificationNumber.Name = "txtIdentificationNumber";
            this.txtIdentificationNumber.Size = new System.Drawing.Size(211, 20);
            this.txtIdentificationNumber.TabIndex = 1;
            this.txtIdentificationNumber.Tag = "ShortName";
            // 
            // btnPLIdentification
            // 
            this.btnPLIdentification.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLIdentification.Location = new System.Drawing.Point(229, 22);
            this.btnPLIdentification.Name = "btnPLIdentification";
            this.btnPLIdentification.Size = new System.Drawing.Size(22, 22);
            this.btnPLIdentification.Source = "Identification";
            this.btnPLIdentification.TabIndex = 2;
            this.btnPLIdentification.TabStop = false;
            this.btnPLIdentification.Text = "↓";
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
            this.chkReadOnly.Location = new System.Drawing.Point(159, 286);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 20;
            this.chkReadOnly.Tag = "ReadOnly";
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 286);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Read Only";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 135);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "Expiry Date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Identification Type";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Identification Number";
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(159, 131);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(103, 20);
            this.txtExpiryDate.TabIndex = 9;
            this.txtExpiryDate.Tag = "yyyy-MM-dd";
            this.txtExpiryDate.Leave += new System.EventHandler(this.TxtExpiryDate_Leave);
            // 
            // txtIdentificationTypeId
            // 
            this.txtIdentificationTypeId.Location = new System.Drawing.Point(159, 77);
            this.txtIdentificationTypeId.Name = "txtIdentificationTypeId";
            this.txtIdentificationTypeId.ReadOnly = true;
            this.txtIdentificationTypeId.Size = new System.Drawing.Size(36, 20);
            this.txtIdentificationTypeId.TabIndex = 3;
            this.txtIdentificationTypeId.Tag = "PhoneNumber";
            this.txtIdentificationTypeId.TextChanged += new System.EventHandler(this.TxtIdentificationType_TextChanged);
            // 
            // btnPLIdentificationType
            // 
            this.btnPLIdentificationType.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLIdentificationType.Location = new System.Drawing.Point(348, 76);
            this.btnPLIdentificationType.Name = "btnPLIdentificationType";
            this.btnPLIdentificationType.Size = new System.Drawing.Size(22, 22);
            this.btnPLIdentificationType.Source = "IdentificationType";
            this.btnPLIdentificationType.TabIndex = 4;
            this.btnPLIdentificationType.TabStop = false;
            this.btnPLIdentificationType.Tag = "lblIdentificationTypeEnglish";
            this.btnPLIdentificationType.Text = "↓";
            // 
            // btnPLCity
            // 
            this.btnPLCity.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLCity.Location = new System.Drawing.Point(348, 155);
            this.btnPLCity.Name = "btnPLCity";
            this.btnPLCity.Size = new System.Drawing.Size(22, 22);
            this.btnPLCity.Source = "City";
            this.btnPLCity.TabIndex = 13;
            this.btnPLCity.TabStop = false;
            this.btnPLCity.Tag = "";
            this.btnPLCity.Text = "↓";
            // 
            // txtCityId
            // 
            this.txtCityId.Location = new System.Drawing.Point(159, 156);
            this.txtCityId.Name = "txtCityId";
            this.txtCityId.ReadOnly = true;
            this.txtCityId.Size = new System.Drawing.Size(36, 20);
            this.txtCityId.TabIndex = 12;
            this.txtCityId.Tag = "";
            this.txtCityId.TextChanged += new System.EventHandler(this.TxtCityId_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(19, 159);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "Issued at";
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
            this.label29.Location = new System.Drawing.Point(19, 108);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 13);
            this.label29.TabIndex = 47;
            this.label29.Text = "Issue Date";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(19, 184);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 13);
            this.label26.TabIndex = 50;
            this.label26.Text = "Is Active";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(159, 184);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(15, 14);
            this.chkIsActive.TabIndex = 15;
            this.chkIsActive.Tag = "ReadOnly";
            this.chkIsActive.UseVisualStyleBackColor = true;
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
            // txtCityEnglish
            // 
            this.txtCityEnglish.Location = new System.Drawing.Point(199, 156);
            this.txtCityEnglish.Name = "txtCityEnglish";
            this.txtCityEnglish.ReadOnly = true;
            this.txtCityEnglish.Size = new System.Drawing.Size(146, 20);
            this.txtCityEnglish.TabIndex = 53;
            this.txtCityEnglish.TabStop = false;
            // 
            // txtIdentificationTypeEnglish
            // 
            this.txtIdentificationTypeEnglish.Location = new System.Drawing.Point(198, 77);
            this.txtIdentificationTypeEnglish.Name = "txtIdentificationTypeEnglish";
            this.txtIdentificationTypeEnglish.ReadOnly = true;
            this.txtIdentificationTypeEnglish.Size = new System.Drawing.Size(147, 20);
            this.txtIdentificationTypeEnglish.TabIndex = 52;
            this.txtIdentificationTypeEnglish.TabStop = false;
            // 
            // IdentificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCityEnglish);
            this.Controls.Add(this.txtIdentificationTypeEnglish);
            this.Controls.Add(this.lblExpiryDateHG);
            this.Controls.Add(this.lblIssueDateHG);
            this.Controls.Add(this.btnIssueDateCalendar);
            this.Controls.Add(this.btnExpiryDate);
            this.Controls.Add(this.txtIdentificationTypeId);
            this.Controls.Add(this.txtCityId);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtIssueDate);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPLCity);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnPLIdentificationType);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdentificationNumber);
            this.Controls.Add(this.btnPLIdentification);
            this.Controls.Add(this.txtId);
            this.Name = "IdentificationForm";
            this.Size = new System.Drawing.Size(384, 359);
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
        private Common.PickListButton btnPLIdentification;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtIdentificationTypeId;
        private System.Windows.Forms.TextBox txtIdentificationNumber;
        private Common.PickListButton btnPLIdentificationType;
        private System.Windows.Forms.Button btnExpiryDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtCityId;
        private Common.PickListButton btnPLCity;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnIssueDateCalendar;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblIssueDateHG;
        private System.Windows.Forms.Label lblExpiryDateHG;
        private System.Windows.Forms.TextBox txtCityEnglish;
        private System.Windows.Forms.TextBox txtIdentificationTypeEnglish;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.CheckBox chkIsActive;
    }
}