namespace MVCHIS.Billing {
    partial class CurrencyForm {
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
            this.txtCurrencyCode = new System.Windows.Forms.TextBox();
            this.txtCurrencyEnglish = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPLCurrency = new MVCHIS.Common.PickListButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrencyArabic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCurrencySymbol = new System.Windows.Forms.TextBox();
            this.btnPLCountry = new MVCHIS.Common.PickListButton();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.txtCountryId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(60, 307);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(168, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(276, 307);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.Location = new System.Drawing.Point(214, 233);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 12;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.Location = new System.Drawing.Point(140, 234);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 11;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Location = new System.Drawing.Point(214, 205);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 10;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(140, 205);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 9;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Created by";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(140, 28);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Currency Code";
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.Location = new System.Drawing.Point(140, 57);
            this.txtCurrencyCode.MaxLength = 3;
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.Size = new System.Drawing.Size(41, 20);
            this.txtCurrencyCode.TabIndex = 1;
            // 
            // txtCurrencyEnglish
            // 
            this.txtCurrencyEnglish.Location = new System.Drawing.Point(140, 86);
            this.txtCurrencyEnglish.MaxLength = 50;
            this.txtCurrencyEnglish.Name = "txtCurrencyEnglish";
            this.txtCurrencyEnglish.Size = new System.Drawing.Size(211, 20);
            this.txtCurrencyEnglish.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Currency English";
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(140, 263);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 13;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Read Only";
            // 
            // btnPLCurrency
            // 
            this.btnPLCurrency.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLCurrency.Location = new System.Drawing.Point(209, 27);
            this.btnPLCurrency.Name = "btnPLCurrency";
            this.btnPLCurrency.Size = new System.Drawing.Size(22, 22);
            this.btnPLCurrency.Source = "Currency";
            this.btnPLCurrency.TabIndex = 2;
            this.btnPLCurrency.TabStop = false;
            this.btnPLCurrency.Text = "↓";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Currency Arabic";
            // 
            // txtCurrencyArabic
            // 
            this.txtCurrencyArabic.Location = new System.Drawing.Point(140, 115);
            this.txtCurrencyArabic.MaxLength = 50;
            this.txtCurrencyArabic.Name = "txtCurrencyArabic";
            this.txtCurrencyArabic.Size = new System.Drawing.Size(211, 20);
            this.txtCurrencyArabic.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Currency Symbol";
            // 
            // txtCurrencySymbol
            // 
            this.txtCurrencySymbol.Location = new System.Drawing.Point(140, 144);
            this.txtCurrencySymbol.MaxLength = 2;
            this.txtCurrencySymbol.Name = "txtCurrencySymbol";
            this.txtCurrencySymbol.Size = new System.Drawing.Size(27, 20);
            this.txtCurrencySymbol.TabIndex = 5;
            // 
            // btnPLCountry
            // 
            this.btnPLCountry.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLCountry.Location = new System.Drawing.Point(329, 171);
            this.btnPLCountry.Name = "btnPLCountry";
            this.btnPLCountry.Size = new System.Drawing.Size(22, 22);
            this.btnPLCountry.Source = "Country";
            this.btnPLCountry.TabIndex = 8;
            this.btnPLCountry.TabStop = false;
            this.btnPLCountry.Text = "↓";
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Enabled = false;
            this.txtCountryCode.Location = new System.Drawing.Point(188, 172);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.ReadOnly = true;
            this.txtCountryCode.Size = new System.Drawing.Size(140, 20);
            this.txtCountryCode.TabIndex = 7;
            this.txtCountryCode.Tag = "";
            this.txtCountryCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCountryId
            // 
            this.txtCountryId.Location = new System.Drawing.Point(140, 172);
            this.txtCountryId.Name = "txtCountryId";
            this.txtCountryId.ReadOnly = true;
            this.txtCountryId.Size = new System.Drawing.Size(43, 20);
            this.txtCountryId.TabIndex = 6;
            this.txtCountryId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCountryId.TextChanged += new System.EventHandler(this.TxtCountryId_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Country";
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPLCountry);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.txtCountryId);
            this.Controls.Add(this.txtCurrencySymbol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCurrencyArabic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCurrencyEnglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPLCurrency);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCurrencyCode);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCreatedBy);
            this.Name = "CurrencyForm";
            this.Size = new System.Drawing.Size(378, 356);
            this.Load += new System.EventHandler(this.CurrencyFormLoad);
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
        private System.Windows.Forms.TextBox txtCurrencyCode;
        private Common.PickListButton btnPLCurrency;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCurrencyEnglish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrencyArabic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCurrencySymbol;
        private Common.PickListButton btnPLCountry;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.TextBox txtCountryId;
        private System.Windows.Forms.Label label8;
    }
}