namespace MVCHIS.Billing {
    partial class ServiceForm {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.txtUpdatedOn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdatedBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPLBillingCategory = new MVCHIS.Common.PickListButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBillingCategoryCode = new System.Windows.Forms.TextBox();
            this.txtCreatedOn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtContractCode = new System.Windows.Forms.TextBox();
            this.btnPLContract = new MVCHIS.Common.PickListButton();
            this.txtContractId = new System.Windows.Forms.TextBox();
            this.txtBillingCategoryId = new System.Windows.Forms.TextBox();
            this.txtCurrencyId = new System.Windows.Forms.TextBox();
            this.btnPLCurrency = new MVCHIS.Common.PickListButton();
            this.txtCurrencyCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEffectiveFromDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkExpired = new System.Windows.Forms.CheckBox();
            this.btnDateOfBirth = new System.Windows.Forms.Button();
            this.lblVAT = new System.Windows.Forms.Label();
            this.txtVATCode = new System.Windows.Forms.TextBox();
            this.btnPLVAT = new MVCHIS.Common.PickListButton();
            this.txtVATId = new System.Windows.Forms.TextBox();
            this.btnPLService = new MVCHIS.Common.PickListButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Contract";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(152, 16);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            this.txtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(152, 299);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 20;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.Location = new System.Drawing.Point(227, 269);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 19;
            this.txtUpdatedOn.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Read Only";
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.Location = new System.Drawing.Point(152, 270);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 18;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Record Id";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(289, 339);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Updated by";
            // 
            // btnPLBillingCategory
            // 
            this.btnPLBillingCategory.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLBillingCategory.Location = new System.Drawing.Point(345, 73);
            this.btnPLBillingCategory.Name = "btnPLBillingCategory";
            this.btnPLBillingCategory.Size = new System.Drawing.Size(22, 22);
            this.btnPLBillingCategory.Source = "BillingCategory";
            this.btnPLBillingCategory.TabIndex = 6;
            this.btnPLBillingCategory.TabStop = false;
            this.btnPLBillingCategory.Text = "↓";
            
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(181, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtBillingCategoryCode
            // 
            this.txtBillingCategoryCode.Location = new System.Drawing.Point(188, 74);
            this.txtBillingCategoryCode.Name = "txtBillingCategoryCode";
            this.txtBillingCategoryCode.ReadOnly = true;
            this.txtBillingCategoryCode.Size = new System.Drawing.Size(156, 20);
            this.txtBillingCategoryCode.TabIndex = 5;
            this.txtBillingCategoryCode.TabStop = false;
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Location = new System.Drawing.Point(227, 243);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 17;
            this.txtCreatedOn.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Created by";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(73, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Billing Category";
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(152, 241);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 16;
            this.txtCreatedBy.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(152, 103);
            this.txtPrice.MaxLength = 6;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(55, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // txtContractCode
            // 
            this.txtContractCode.Location = new System.Drawing.Point(188, 45);
            this.txtContractCode.Name = "txtContractCode";
            this.txtContractCode.ReadOnly = true;
            this.txtContractCode.Size = new System.Drawing.Size(156, 20);
            this.txtContractCode.TabIndex = 2;
            this.txtContractCode.TabStop = false;
            // 
            // btnPLContract
            // 
            this.btnPLContract.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLContract.Location = new System.Drawing.Point(345, 44);
            this.btnPLContract.Name = "btnPLContract";
            this.btnPLContract.Size = new System.Drawing.Size(22, 22);
            this.btnPLContract.Source = "Contract";
            this.btnPLContract.TabIndex = 3;
            this.btnPLContract.TabStop = false;
            this.btnPLContract.Text = "↓";
            
            // 
            // txtContractId
            // 
            this.txtContractId.Location = new System.Drawing.Point(152, 45);
            this.txtContractId.MaxLength = 4;
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.ReadOnly = true;
            this.txtContractId.Size = new System.Drawing.Size(35, 20);
            this.txtContractId.TabIndex = 1;
            this.txtContractId.TextChanged += new System.EventHandler(this.TxtContractId_TextChanged);
            // 
            // txtBillingCategoryId
            // 
            this.txtBillingCategoryId.Location = new System.Drawing.Point(152, 74);
            this.txtBillingCategoryId.MaxLength = 4;
            this.txtBillingCategoryId.Name = "txtBillingCategoryId";
            this.txtBillingCategoryId.ReadOnly = true;
            this.txtBillingCategoryId.Size = new System.Drawing.Size(35, 20);
            this.txtBillingCategoryId.TabIndex = 4;
            this.txtBillingCategoryId.TextChanged += new System.EventHandler(this.TxtBillingCategoryId_TextChanged);
            // 
            // txtCurrencyId
            // 
            this.txtCurrencyId.Location = new System.Drawing.Point(152, 160);
            this.txtCurrencyId.MaxLength = 4;
            this.txtCurrencyId.Name = "txtCurrencyId";
            this.txtCurrencyId.ReadOnly = true;
            this.txtCurrencyId.Size = new System.Drawing.Size(35, 20);
            this.txtCurrencyId.TabIndex = 8;
            this.txtCurrencyId.TextChanged += new System.EventHandler(this.TxtCurrencyId_TextChanged);
            // 
            // btnPLCurrency
            // 
            this.btnPLCurrency.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLCurrency.Location = new System.Drawing.Point(345, 159);
            this.btnPLCurrency.Name = "btnPLCurrency";
            this.btnPLCurrency.Size = new System.Drawing.Size(22, 22);
            this.btnPLCurrency.Source = "Currency";
            this.btnPLCurrency.TabIndex = 11;
            this.btnPLCurrency.TabStop = false;
            this.btnPLCurrency.Text = "↓";
            
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.Location = new System.Drawing.Point(188, 160);
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.ReadOnly = true;
            this.txtCurrencyCode.Size = new System.Drawing.Size(156, 20);
            this.txtCurrencyCode.TabIndex = 9;
            this.txtCurrencyCode.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Currency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Effective From Date";
            // 
            // txtEffectiveFromDate
            // 
            this.txtEffectiveFromDate.Location = new System.Drawing.Point(152, 189);
            this.txtEffectiveFromDate.MaxLength = 10;
            this.txtEffectiveFromDate.Name = "txtEffectiveFromDate";
            this.txtEffectiveFromDate.Size = new System.Drawing.Size(79, 20);
            this.txtEffectiveFromDate.TabIndex = 12;
            this.txtEffectiveFromDate.Tag = "yyyy-MM-dd";
            this.txtEffectiveFromDate.Leave += new System.EventHandler(this.TxtEffectiveFromDate_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Expired";
            // 
            // chkExpired
            // 
            this.chkExpired.AutoSize = true;
            this.chkExpired.Location = new System.Drawing.Point(152, 218);
            this.chkExpired.Name = "chkExpired";
            this.chkExpired.Size = new System.Drawing.Size(15, 14);
            this.chkExpired.TabIndex = 14;
            this.chkExpired.UseVisualStyleBackColor = true;
            // 
            // btnDateOfBirth
            // 
            this.btnDateOfBirth.Enabled = false;
            this.btnDateOfBirth.Location = new System.Drawing.Point(232, 188);
            this.btnDateOfBirth.Name = "btnDateOfBirth";
            this.btnDateOfBirth.Size = new System.Drawing.Size(23, 22);
            this.btnDateOfBirth.TabIndex = 13;
            this.btnDateOfBirth.TabStop = false;
            this.btnDateOfBirth.Tag = "CALENDAR";
            this.btnDateOfBirth.Text = "📅";
            this.btnDateOfBirth.UseVisualStyleBackColor = true;
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(27, 134);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(84, 13);
            this.lblVAT.TabIndex = 71;
            this.lblVAT.Text = "VAT Percentage";
            // 
            // txtVATCode
            // 
            this.txtVATCode.Location = new System.Drawing.Point(188, 131);
            this.txtVATCode.Name = "txtVATCode";
            this.txtVATCode.ReadOnly = true;
            this.txtVATCode.Size = new System.Drawing.Size(156, 20);
            this.txtVATCode.TabIndex = 9;
            this.txtVATCode.TabStop = false;
            // 
            // btnPLVAT
            // 
            this.btnPLVAT.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLVAT.Location = new System.Drawing.Point(345, 130);
            this.btnPLVAT.Name = "btnPLVAT";
            this.btnPLVAT.Size = new System.Drawing.Size(22, 22);
            this.btnPLVAT.Source = "Currency";
            this.btnPLVAT.TabIndex = 11;
            this.btnPLVAT.TabStop = false;
            this.btnPLVAT.Text = "↓";
            
            // 
            // txtVATId
            // 
            this.txtVATId.Location = new System.Drawing.Point(152, 131);
            this.txtVATId.MaxLength = 4;
            this.txtVATId.Name = "txtVATId";
            this.txtVATId.ReadOnly = true;
            this.txtVATId.Size = new System.Drawing.Size(35, 20);
            this.txtVATId.TabIndex = 8;
            this.txtVATId.TextChanged += new System.EventHandler(this.TxtVATId_TextChanged);
            // 
            // btnPLService
            // 
            this.btnPLService.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLService.Location = new System.Drawing.Point(222, 15);
            this.btnPLService.Name = "btnPLService";
            this.btnPLService.Size = new System.Drawing.Size(22, 22);
            this.btnPLService.Source = "Service";
            this.btnPLService.TabIndex = 3;
            this.btnPLService.TabStop = false;
            this.btnPLService.Text = "↓";
            
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDateOfBirth);
            this.Controls.Add(this.txtVATId);
            this.Controls.Add(this.btnPLVAT);
            this.Controls.Add(this.txtCurrencyId);
            this.Controls.Add(this.txtVATCode);
            this.Controls.Add(this.btnPLCurrency);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.txtCurrencyCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBillingCategoryId);
            this.Controls.Add(this.txtContractId);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.chkExpired);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEffectiveFromDate);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPLService);
            this.Controls.Add(this.btnPLContract);
            this.Controls.Add(this.btnPLBillingCategory);
            this.Controls.Add(this.txtContractCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBillingCategoryCode);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCreatedBy);
            this.Name = "ServiceForm";
            this.Size = new System.Drawing.Size(391, 394);
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUpdatedOn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdatedBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label6;
        private Common.PickListButton btnPLBillingCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBillingCategoryCode;
        private System.Windows.Forms.TextBox txtCreatedOn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtContractCode;
        private Common.PickListButton btnPLContract;
        private System.Windows.Forms.TextBox txtContractId;
        private System.Windows.Forms.TextBox txtBillingCategoryId;
        private System.Windows.Forms.TextBox txtCurrencyId;
        private Common.PickListButton btnPLCurrency;
        private System.Windows.Forms.TextBox txtCurrencyCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEffectiveFromDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDateOfBirth;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.CheckBox chkExpired;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.TextBox txtVATCode;
        private Common.PickListButton btnPLVAT;
        private System.Windows.Forms.TextBox txtVATId;
        private Common.PickListButton btnPLService;
    }
}
