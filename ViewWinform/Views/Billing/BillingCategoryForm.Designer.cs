namespace MVCWinform.Billing {
    partial class BillingCategoryForm {
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
        private void InitializeComponent() {
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
            this.txtBillingCategory = new System.Windows.Forms.TextBox();
            this.lookUpButtonAccomCategory = new MVCWinform.Common.LookUpButton();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.chkReservationOnly = new System.Windows.Forms.CheckBox();
            this.lookUpButtonFoodType = new MVCWinform.Common.LookUpButton();
            this.lookUpButtonFood = new MVCWinform.Common.LookUpButton();
            this.lookUpButtonAccommClass = new MVCWinform.Common.LookUpButton();
            this.txtFoodTypeCode = new System.Windows.Forms.TextBox();
            this.txtFoodClassCode = new System.Windows.Forms.TextBox();
            this.txtBillingCategoryDesc = new System.Windows.Forms.TextBox();
            this.txtAccommClassCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccommClassDesc = new System.Windows.Forms.TextBox();
            this.txtFoodClassDesc = new System.Windows.Forms.TextBox();
            this.txtFoodTypeDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(168, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(276, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(384, 288);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedOn.Location = new System.Drawing.Point(214, 230);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 14;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedBy.Location = new System.Drawing.Point(140, 231);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 13;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedOn.Location = new System.Drawing.Point(214, 204);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 12;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedBy.Location = new System.Drawing.Point(140, 204);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 11;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Created by";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(140, 15);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            this.txtId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Record Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Billing Category";
            // 
            // txtBillingCategory
            // 
            this.txtBillingCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBillingCategory.Location = new System.Drawing.Point(140, 42);
            this.txtBillingCategory.Name = "txtBillingCategory";
            this.txtBillingCategory.Size = new System.Drawing.Size(212, 20);
            this.txtBillingCategory.TabIndex = 1;
            // 
            // lookUpButtonAccomCategory
            // 
            this.lookUpButtonAccomCategory.AssociatedControl = "txtBillingCategory";
            this.lookUpButtonAccomCategory.Controller = "BillingCategory";
            this.lookUpButtonAccomCategory.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonAccomCategory.Location = new System.Drawing.Point(353, 41);
            this.lookUpButtonAccomCategory.Name = "lookUpButtonAccomCategory";
            this.lookUpButtonAccomCategory.SelectedValueIndex = 0;
            this.lookUpButtonAccomCategory.ShowFieldsInLookUp.Add("BillingCategory");
            this.lookUpButtonAccomCategory.ShowFieldsInLookUp.Add("BillingCategoryDesc");
            this.lookUpButtonAccomCategory.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonAccomCategory.TabIndex = 2;
            this.lookUpButtonAccomCategory.TabStop = false;
            this.lookUpButtonAccomCategory.LookUpSelected += new System.EventHandler(this.LookUpButton1LookUpSelected);
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(140, 261);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 10;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // chkReservationOnly
            // 
            this.chkReservationOnly.AutoSize = true;
            this.chkReservationOnly.Location = new System.Drawing.Point(140, 179);
            this.chkReservationOnly.Name = "chkReservationOnly";
            this.chkReservationOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReservationOnly.TabIndex = 10;
            this.chkReservationOnly.UseVisualStyleBackColor = true;
            // 
            // lookUpButtonFoodType
            // 
            this.lookUpButtonFoodType.AssociatedControl = "txtFoodTypeCode";
            this.lookUpButtonFoodType.Controller = "FoodType";
            this.lookUpButtonFoodType.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonFoodType.Location = new System.Drawing.Point(187, 149);
            this.lookUpButtonFoodType.Name = "lookUpButtonFoodType";
            this.lookUpButtonFoodType.SelectedValueIndex = 0;
            this.lookUpButtonFoodType.ShowFieldsInLookUp.Add("FoodTypeCode");
            this.lookUpButtonFoodType.ShowFieldsInLookUp.Add("FoodTypeDesc");
            this.lookUpButtonFoodType.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonFoodType.TabIndex = 9;
            this.lookUpButtonFoodType.TabStop = false;
            // 
            // lookUpButtonFood
            // 
            this.lookUpButtonFood.AssociatedControl = "txtFoodClassCode";
            this.lookUpButtonFood.Controller = "FoodClass";
            this.lookUpButtonFood.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonFood.Location = new System.Drawing.Point(187, 122);
            this.lookUpButtonFood.Name = "lookUpButtonFood";
            this.lookUpButtonFood.SelectedValueIndex = 0;
            this.lookUpButtonFood.ShowFieldsInLookUp.Add("FoodClassCode");
            this.lookUpButtonFood.ShowFieldsInLookUp.Add("FoodClassDesc");
            this.lookUpButtonFood.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonFood.TabIndex = 7;
            this.lookUpButtonFood.TabStop = false;
            // 
            // lookUpButtonAccommClass
            // 
            this.lookUpButtonAccommClass.AssociatedControl = "txtAccommClassCode";
            this.lookUpButtonAccommClass.Controller = "AccommClass";
            this.lookUpButtonAccommClass.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonAccommClass.Location = new System.Drawing.Point(187, 95);
            this.lookUpButtonAccommClass.Name = "lookUpButtonAccommClass";
            this.lookUpButtonAccommClass.SelectedValueIndex = 0;
            this.lookUpButtonAccommClass.ShowFieldsInLookUp.Add("AccommClassCode");
            this.lookUpButtonAccommClass.ShowFieldsInLookUp.Add("AccommClassDesc");
            this.lookUpButtonAccommClass.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonAccommClass.TabIndex = 5;
            this.lookUpButtonAccommClass.TabStop = false;
            // 
            // txtFoodTypeCode
            // 
            this.txtFoodTypeCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtFoodTypeCode.Location = new System.Drawing.Point(140, 150);
            this.txtFoodTypeCode.Name = "txtFoodTypeCode";
            this.txtFoodTypeCode.ReadOnly = true;
            this.txtFoodTypeCode.Size = new System.Drawing.Size(47, 20);
            this.txtFoodTypeCode.TabIndex = 8;
            this.txtFoodTypeCode.TextChanged += new System.EventHandler(this.TxtFoodTypeCode_TextChanged);
            // 
            // txtFoodClassCode
            // 
            this.txtFoodClassCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtFoodClassCode.Location = new System.Drawing.Point(140, 123);
            this.txtFoodClassCode.Name = "txtFoodClassCode";
            this.txtFoodClassCode.ReadOnly = true;
            this.txtFoodClassCode.Size = new System.Drawing.Size(47, 20);
            this.txtFoodClassCode.TabIndex = 6;
            this.txtFoodClassCode.TextChanged += new System.EventHandler(this.TxtFoodClassCode_TextChanged);
            // 
            // txtBillingCategoryDesc
            // 
            this.txtBillingCategoryDesc.Location = new System.Drawing.Point(140, 69);
            this.txtBillingCategoryDesc.Name = "txtBillingCategoryDesc";
            this.txtBillingCategoryDesc.Size = new System.Drawing.Size(433, 20);
            this.txtBillingCategoryDesc.TabIndex = 3;
            // 
            // txtAccommClassCode
            // 
            this.txtAccommClassCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccommClassCode.Location = new System.Drawing.Point(140, 96);
            this.txtAccommClassCode.Name = "txtAccommClassCode";
            this.txtAccommClassCode.ReadOnly = true;
            this.txtAccommClassCode.Size = new System.Drawing.Size(47, 20);
            this.txtAccommClassCode.TabIndex = 4;
            this.txtAccommClassCode.TextChanged += new System.EventHandler(this.TxtAccommClassCode_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Billing Category Desc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Food Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Read Only";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Reservation Only";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Food Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Accomm Class";
            // 
            // txtAccommClassDesc
            // 
            this.txtAccommClassDesc.Location = new System.Drawing.Point(209, 96);
            this.txtAccommClassDesc.Name = "txtAccommClassDesc";
            this.txtAccommClassDesc.ReadOnly = true;
            this.txtAccommClassDesc.Size = new System.Drawing.Size(179, 20);
            this.txtAccommClassDesc.TabIndex = 4;
            // 
            // txtFoodClassDesc
            // 
            this.txtFoodClassDesc.Location = new System.Drawing.Point(209, 123);
            this.txtFoodClassDesc.Name = "txtFoodClassDesc";
            this.txtFoodClassDesc.ReadOnly = true;
            this.txtFoodClassDesc.Size = new System.Drawing.Size(179, 20);
            this.txtFoodClassDesc.TabIndex = 6;
            // 
            // txtFoodTypeDesc
            // 
            this.txtFoodTypeDesc.Location = new System.Drawing.Point(209, 150);
            this.txtFoodTypeDesc.Name = "txtFoodTypeDesc";
            this.txtFoodTypeDesc.ReadOnly = true;
            this.txtFoodTypeDesc.Size = new System.Drawing.Size(179, 20);
            this.txtFoodTypeDesc.TabIndex = 8;
            // 
            // BillingCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 351);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.chkReservationOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.lookUpButtonFoodType);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lookUpButtonFood);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lookUpButtonAccommClass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFoodTypeDesc);
            this.Controls.Add(this.txtFoodTypeCode);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.lookUpButtonAccomCategory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtFoodClassDesc);
            this.Controls.Add(this.txtFoodClassCode);
            this.Controls.Add(this.txtBillingCategoryDesc);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.txtAccommClassDesc);
            this.Controls.Add(this.txtAccommClassCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBillingCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "BillingCategoryForm";
            this.Text = "Billing Categories";
            this.Load += new System.EventHandler(this.AccomCategoryFormLoad);
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
        private System.Windows.Forms.TextBox txtBillingCategory;
        private Common.LookUpButton lookUpButtonAccomCategory;
        private Common.LookUpButton lookUpButtonFood;
        private Common.LookUpButton lookUpButtonAccommClass;
        private System.Windows.Forms.TextBox txtFoodClassCode;
        private System.Windows.Forms.TextBox txtAccommClassCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillingCategoryDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkReservationOnly;
        private System.Windows.Forms.Label label8;
        private Common.LookUpButton lookUpButtonFoodType;
        private System.Windows.Forms.TextBox txtFoodTypeCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAccommClassDesc;
        private System.Windows.Forms.TextBox txtFoodClassDesc;
        private System.Windows.Forms.TextBox txtFoodTypeDesc;
    }
}