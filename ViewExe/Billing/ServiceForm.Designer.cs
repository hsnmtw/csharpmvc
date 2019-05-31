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
            this.lookUpButtonBillingCategory = new MVCHIS.Common.LookUpButton();
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
            this.lookUpButtonContract = new MVCHIS.Common.LookUpButton();
            this.txtContractId = new System.Windows.Forms.TextBox();
            this.txtBillingCategoryId = new System.Windows.Forms.TextBox();
            this.txtCurrencyId = new System.Windows.Forms.TextBox();
            this.lookUpButtonCurrency = new MVCHIS.Common.LookUpButton();
            this.txtCurrencyCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCurrencyEnglish = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 49);
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
            
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(152, 226);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 15;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedOn.Location = new System.Drawing.Point(227, 194);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 14;
            this.txtUpdatedOn.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Read Only";
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedBy.Location = new System.Drawing.Point(152, 196);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 13;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Record Id";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(289, 268);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Updated by";
            // 
            // lookUpButtonBillingCategory
            // 
            this.lookUpButtonBillingCategory.AssociatedControl = "txtBillingCategoryId";
            this.lookUpButtonBillingCategory.Controller = "BillingCategory";
            this.lookUpButtonBillingCategory.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonBillingCategory.Location = new System.Drawing.Point(345, 75);
            this.lookUpButtonBillingCategory.Name = "lookUpButtonBillingCategory";
            this.lookUpButtonBillingCategory.SelectedValueIndex = 1;
            this.lookUpButtonBillingCategory.ShowFieldsInLookUp.Add("BillingCategoryCode");
            this.lookUpButtonBillingCategory.ShowFieldsInLookUp.Add("Id");
            this.lookUpButtonBillingCategory.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonBillingCategory.TabIndex = 6;
            this.lookUpButtonBillingCategory.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(181, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtBillingCategoryCode
            // 
            this.txtBillingCategoryCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBillingCategoryCode.Location = new System.Drawing.Point(190, 76);
            this.txtBillingCategoryCode.Name = "txtBillingCategoryCode";
            this.txtBillingCategoryCode.ReadOnly = true;
            this.txtBillingCategoryCode.Size = new System.Drawing.Size(154, 20);
            this.txtBillingCategoryCode.TabIndex = 5;
            this.txtBillingCategoryCode.TabStop = false;
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedOn.Location = new System.Drawing.Point(227, 168);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 12;
            this.txtCreatedOn.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Created by";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(73, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Billing Category";
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedBy.Location = new System.Drawing.Point(152, 166);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 11;
            this.txtCreatedBy.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(152, 106);
            this.txtPrice.MaxLength = 6;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(55, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // txtContractCode
            // 
            this.txtContractCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContractCode.Location = new System.Drawing.Point(190, 46);
            this.txtContractCode.Name = "txtContractCode";
            this.txtContractCode.ReadOnly = true;
            this.txtContractCode.Size = new System.Drawing.Size(154, 20);
            this.txtContractCode.TabIndex = 2;
            this.txtContractCode.TabStop = false;
            // 
            // lookUpButtonContract
            // 
            this.lookUpButtonContract.AssociatedControl = "txtContractId";
            this.lookUpButtonContract.Controller = "Contract";
            this.lookUpButtonContract.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonContract.Location = new System.Drawing.Point(345, 45);
            this.lookUpButtonContract.Name = "lookUpButtonContract";
            this.lookUpButtonContract.SelectedValueIndex = 1;
            this.lookUpButtonContract.ShowFieldsInLookUp.Add("ContractCode");
            this.lookUpButtonContract.ShowFieldsInLookUp.Add("Id");
            this.lookUpButtonContract.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonContract.TabIndex = 3;
            this.lookUpButtonContract.TabStop = false;
            // 
            // txtContractId
            // 
            this.txtContractId.BackColor = System.Drawing.SystemColors.Window;
            this.txtContractId.Location = new System.Drawing.Point(152, 46);
            this.txtContractId.MaxLength = 4;
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.ReadOnly = true;
            this.txtContractId.Size = new System.Drawing.Size(35, 20);
            this.txtContractId.TabIndex = 1;
            this.txtContractId.TextChanged += new System.EventHandler(this.TxtContractId_TextChanged);
            // 
            // txtBillingCategoryId
            // 
            this.txtBillingCategoryId.BackColor = System.Drawing.SystemColors.Window;
            this.txtBillingCategoryId.Location = new System.Drawing.Point(152, 76);
            this.txtBillingCategoryId.MaxLength = 4;
            this.txtBillingCategoryId.Name = "txtBillingCategoryId";
            this.txtBillingCategoryId.ReadOnly = true;
            this.txtBillingCategoryId.Size = new System.Drawing.Size(35, 20);
            this.txtBillingCategoryId.TabIndex = 4;
            this.txtBillingCategoryId.TextChanged += new System.EventHandler(this.TxtBillingCategoryId_TextChanged);
            // 
            // txtCurrencyId
            // 
            this.txtCurrencyId.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrencyId.Location = new System.Drawing.Point(152, 136);
            this.txtCurrencyId.MaxLength = 4;
            this.txtCurrencyId.Name = "txtCurrencyId";
            this.txtCurrencyId.ReadOnly = true;
            this.txtCurrencyId.Size = new System.Drawing.Size(35, 20);
            this.txtCurrencyId.TabIndex = 8;
            this.txtCurrencyId.TextChanged += new System.EventHandler(this.TxtCurrencyId_TextChanged);
            // 
            // lookUpButtonCurrency
            // 
            this.lookUpButtonCurrency.AssociatedControl = "txtCurrencyId";
            this.lookUpButtonCurrency.Controller = "Currency";
            this.lookUpButtonCurrency.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonCurrency.Location = new System.Drawing.Point(345, 135);
            this.lookUpButtonCurrency.Name = "lookUpButtonCurrency";
            this.lookUpButtonCurrency.SelectedValueIndex = 3;
            this.lookUpButtonCurrency.ShowFieldsInLookUp.Add("CurrencyCode");
            this.lookUpButtonCurrency.ShowFieldsInLookUp.Add("CurrencyEnglish");
            this.lookUpButtonCurrency.ShowFieldsInLookUp.Add("CurrencyArabic");
            this.lookUpButtonCurrency.ShowFieldsInLookUp.Add("Id");
            this.lookUpButtonCurrency.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonCurrency.TabIndex = 10;
            this.lookUpButtonCurrency.TabStop = false;
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.BackColor = System.Drawing.SystemColors.Control;
            this.txtCurrencyCode.Location = new System.Drawing.Point(188, 136);
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.ReadOnly = true;
            this.txtCurrencyCode.Size = new System.Drawing.Size(43, 20);
            this.txtCurrencyCode.TabIndex = 9;
            this.txtCurrencyCode.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Currency";
            // 
            // txtCurrencyEnglish
            // 
            this.txtCurrencyEnglish.BackColor = System.Drawing.SystemColors.Control;
            this.txtCurrencyEnglish.Location = new System.Drawing.Point(232, 136);
            this.txtCurrencyEnglish.Name = "txtCurrencyEnglish";
            this.txtCurrencyEnglish.ReadOnly = true;
            this.txtCurrencyEnglish.Size = new System.Drawing.Size(112, 20);
            this.txtCurrencyEnglish.TabIndex = 9;
            this.txtCurrencyEnglish.TabStop = false;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCurrencyId);
            this.Controls.Add(this.lookUpButtonCurrency);
            this.Controls.Add(this.txtCurrencyEnglish);
            this.Controls.Add(this.txtCurrencyCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBillingCategoryId);
            this.Controls.Add(this.txtContractId);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lookUpButtonContract);
            this.Controls.Add(this.lookUpButtonBillingCategory);
            this.Controls.Add(this.txtContractCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBillingCategoryCode);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCreatedBy);
            this.Name = "ServiceForm";
            this.Size = new System.Drawing.Size(391, 311);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.TextBox txtUpdatedOn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdatedBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label6;
        private Common.LookUpButton lookUpButtonBillingCategory;
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
        private Common.LookUpButton lookUpButtonContract;
        private System.Windows.Forms.TextBox txtContractId;
        private System.Windows.Forms.TextBox txtBillingCategoryId;
        private System.Windows.Forms.TextBox txtCurrencyId;
        private Common.LookUpButton lookUpButtonCurrency;
        private System.Windows.Forms.TextBox txtCurrencyCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCurrencyEnglish;
    }
}
