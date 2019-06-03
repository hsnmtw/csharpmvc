namespace MVCHIS.Billing {
    partial class CurrencyFXRateForm {
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
            this.chkReadOnly = new MVCHIS.Utils.ForcedFocusCheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFXDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnFromDate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lookUpButtonCurrency = new MVCHIS.Common.LookUpButton();
            this.txtFromCurrencyEnglish = new System.Windows.Forms.TextBox();
            this.txtFromCurrencyId = new System.Windows.Forms.TextBox();
            this.lblFXDateHijri = new System.Windows.Forms.Label();
            this.lookUpButton1 = new MVCHIS.Common.LookUpButton();
            this.txtToCurrencyEnglish = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToCurrencyId = new System.Windows.Forms.TextBox();
            this.lookUpButtonRecordId = new MVCHIS.Common.LookUpButton();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(60, 262);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(168, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(276, 262);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            
            this.txtUpdatedOn.Location = new System.Drawing.Point(214, 204);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 15;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            
            this.txtUpdatedBy.Location = new System.Drawing.Point(141, 205);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 14;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            
            this.txtCreatedOn.Location = new System.Drawing.Point(214, 176);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 13;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            
            this.txtCreatedBy.Location = new System.Drawing.Point(141, 176);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 12;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Created by";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(141, 28);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Record Id";
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(141, 234);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 16;
            this.chkReadOnly.TabStop = false;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Read Only";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "FX Date";
            // 
            // txtFXDate
            // 
            this.txtFXDate.Location = new System.Drawing.Point(141, 116);
            this.txtFXDate.MaxLength = 10;
            this.txtFXDate.Name = "txtFXDate";
            this.txtFXDate.Size = new System.Drawing.Size(85, 20);
            this.txtFXDate.TabIndex = 8;
            this.txtFXDate.Tag = "yyyy-MM-dd";
            this.txtFXDate.Leave += new System.EventHandler(this.TxtFromDate_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Rate";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(141, 142);
            this.txtRate.MaxLength = 6;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(47, 20);
            this.txtRate.TabIndex = 11;
            // 
            // btnFromDate
            // 
            this.btnFromDate.Enabled = false;
            this.btnFromDate.Location = new System.Drawing.Point(229, 115);
            this.btnFromDate.Name = "btnFromDate";
            this.btnFromDate.Size = new System.Drawing.Size(23, 22);
            this.btnFromDate.TabIndex = 9;
            this.btnFromDate.TabStop = false;
            this.btnFromDate.Tag = "CALENDAR";
            this.btnFromDate.Text = "📅";
            this.btnFromDate.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "From Currency";
            // 
            // lookUpButtonCurrency
            // 
            this.lookUpButtonCurrency.AssociatedControl = "txtFromCurrencyId";
            this.lookUpButtonCurrency.Controller = "Currency";
            this.lookUpButtonCurrency.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonCurrency.Location = new System.Drawing.Point(329, 63);
            this.lookUpButtonCurrency.Name = "lookUpButtonCurrency";
            this.lookUpButtonCurrency.SelectedValueIndex = 0;
            this.lookUpButtonCurrency.ShowFieldsInLookUp.Add("Id");
            this.lookUpButtonCurrency.ShowFieldsInLookUp.Add("CurrencyCode");
            this.lookUpButtonCurrency.ShowFieldsInLookUp.Add("CurrencyEnglish");
            this.lookUpButtonCurrency.ShowFieldsInLookUp.Add("CurrencySymbol");
            this.lookUpButtonCurrency.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonCurrency.TabIndex = 4;
            this.lookUpButtonCurrency.TabStop = false;
            // 
            // txtFromCurrencyEnglish
            // 
            this.txtFromCurrencyEnglish.Enabled = false;
            this.txtFromCurrencyEnglish.Location = new System.Drawing.Point(174, 64);
            this.txtFromCurrencyEnglish.MaxLength = 50;
            this.txtFromCurrencyEnglish.Name = "txtFromCurrencyEnglish";
            this.txtFromCurrencyEnglish.Size = new System.Drawing.Size(154, 20);
            this.txtFromCurrencyEnglish.TabIndex = 3;
            this.txtFromCurrencyEnglish.TabStop = false;
            // 
            // txtFromCurrencyId
            // 
            this.txtFromCurrencyId.Location = new System.Drawing.Point(141, 64);
            this.txtFromCurrencyId.MaxLength = 2;
            this.txtFromCurrencyId.Name = "txtFromCurrencyId";
            this.txtFromCurrencyId.ReadOnly = true;
            this.txtFromCurrencyId.Size = new System.Drawing.Size(31, 20);
            this.txtFromCurrencyId.TabIndex = 2;
            this.txtFromCurrencyId.TextChanged += new System.EventHandler(this.TxtFromCurrencyId_TextChanged);
            // 
            // lblFXDateHijri
            // 
            this.lblFXDateHijri.AutoSize = true;
            this.lblFXDateHijri.Location = new System.Drawing.Point(258, 119);
            this.lblFXDateHijri.Name = "lblFXDateHijri";
            this.lblFXDateHijri.Size = new System.Drawing.Size(11, 13);
            this.lblFXDateHijri.TabIndex = 10;
            this.lblFXDateHijri.Text = "-";
            // 
            // lookUpButton1
            // 
            this.lookUpButton1.AssociatedControl = "txtToCurrencyId";
            this.lookUpButton1.Controller = "Currency";
            this.lookUpButton1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButton1.Location = new System.Drawing.Point(329, 89);
            this.lookUpButton1.Name = "lookUpButton1";
            this.lookUpButton1.SelectedValueIndex = 0;
            this.lookUpButton1.ShowFieldsInLookUp.Add("Id");
            this.lookUpButton1.ShowFieldsInLookUp.Add("CurrencyCode");
            this.lookUpButton1.ShowFieldsInLookUp.Add("CurrencyEnglish");
            this.lookUpButton1.ShowFieldsInLookUp.Add("CurrencySymbol");
            this.lookUpButton1.Size = new System.Drawing.Size(22, 22);
            this.lookUpButton1.TabIndex = 7;
            this.lookUpButton1.TabStop = false;
            // 
            // txtToCurrencyEnglish
            // 
            this.txtToCurrencyEnglish.Enabled = false;
            this.txtToCurrencyEnglish.Location = new System.Drawing.Point(174, 90);
            this.txtToCurrencyEnglish.MaxLength = 50;
            this.txtToCurrencyEnglish.Name = "txtToCurrencyEnglish";
            this.txtToCurrencyEnglish.Size = new System.Drawing.Size(154, 20);
            this.txtToCurrencyEnglish.TabIndex = 6;
            this.txtToCurrencyEnglish.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "To Currency";
            // 
            // txtToCurrencyId
            // 
            this.txtToCurrencyId.Location = new System.Drawing.Point(141, 90);
            this.txtToCurrencyId.MaxLength = 2;
            this.txtToCurrencyId.Name = "txtToCurrencyId";
            this.txtToCurrencyId.ReadOnly = true;
            this.txtToCurrencyId.Size = new System.Drawing.Size(31, 20);
            this.txtToCurrencyId.TabIndex = 5;
            this.txtToCurrencyId.TextChanged += new System.EventHandler(this.TxtToCurrencyId_TextChanged);
            // 
            // lookUpButtonRecordId
            // 
            this.lookUpButtonRecordId.AssociatedControl = "txtId";
            this.lookUpButtonRecordId.Controller = "CurrencyFXRate";
            this.lookUpButtonRecordId.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonRecordId.Location = new System.Drawing.Point(210, 27);
            this.lookUpButtonRecordId.Name = "lookUpButtonRecordId";
            this.lookUpButtonRecordId.SelectedValueIndex = 0;
            this.lookUpButtonRecordId.ShowFieldsInLookUp.Add("Id");
            this.lookUpButtonRecordId.ShowFieldsInLookUp.Add("FromCurrencyId");
            this.lookUpButtonRecordId.ShowFieldsInLookUp.Add("ToCurrencyId");
            this.lookUpButtonRecordId.ShowFieldsInLookUp.Add("FXDate");
            this.lookUpButtonRecordId.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonRecordId.TabIndex = 1;
            this.lookUpButtonRecordId.TabStop = false;
            this.lookUpButtonRecordId.LookUpSelected += new System.EventHandler(this.LookUpButtonRecordId_LookUpSelected);
            // 
            // CurrencyFXRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFromDate);
            this.Controls.Add(this.txtToCurrencyId);
            this.Controls.Add(this.txtFromCurrencyId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFXDate);
            this.Controls.Add(this.lblFXDateHijri);
            this.Controls.Add(this.txtToCurrencyEnglish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFromCurrencyEnglish);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lookUpButton1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lookUpButtonRecordId);
            this.Controls.Add(this.lookUpButtonCurrency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCreatedBy);
            this.Name = "CurrencyFXRateForm";
            this.Size = new System.Drawing.Size(378, 303);
            this.Load += new System.EventHandler(this.CurrencyFXRateFormLoad);
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFXDate;
        private Utils.ForcedFocusCheckBox chkReadOnly;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnFromDate;
        private System.Windows.Forms.Label label12;
        private Common.LookUpButton lookUpButtonCurrency;
        private System.Windows.Forms.TextBox txtFromCurrencyEnglish;
        private System.Windows.Forms.TextBox txtFromCurrencyId;
        private System.Windows.Forms.Label lblFXDateHijri;
        private Common.LookUpButton lookUpButton1;
        private System.Windows.Forms.TextBox txtToCurrencyEnglish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToCurrencyId;
        private Common.LookUpButton lookUpButtonRecordId;
    }
}