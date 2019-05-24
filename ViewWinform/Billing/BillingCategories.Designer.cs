namespace ViewWinform.Billing {
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
            this.btnRemove = new System.Windows.Forms.Button();
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
            this.lookUpButtonAccomCategory = new ViewWinform.Common.LookUpButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.chkReservationOnly = new System.Windows.Forms.CheckBox();
            this.lookUpButtonFoodType = new ViewWinform.Common.LookUpButton();
            this.lookUpButtonFood = new ViewWinform.Common.LookUpButton();
            this.lookUpButtonAccommClass = new ViewWinform.Common.LookUpButton();
            this.txtFoodType = new System.Windows.Forms.TextBox();
            this.txtFoodClass = new System.Windows.Forms.TextBox();
            this.txtBillingCategoryDesc = new System.Windows.Forms.TextBox();
            this.txtAccomClass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(72, 289);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(287, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(395, 289);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedOn.Location = new System.Drawing.Point(225, 231);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 14;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedBy.Location = new System.Drawing.Point(151, 232);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 13;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedOn.Location = new System.Drawing.Point(225, 205);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 12;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedBy.Location = new System.Drawing.Point(151, 205);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 11;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Created by";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(151, 16);
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
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Record Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Billing Category";
            // 
            // txtBillingCategory
            // 
            this.txtBillingCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBillingCategory.Location = new System.Drawing.Point(151, 43);
            this.txtBillingCategory.Name = "txtBillingCategory";
            this.txtBillingCategory.Size = new System.Drawing.Size(212, 20);
            this.txtBillingCategory.TabIndex = 1;
            // 
            // lookUpButtonAccomCategory
            // 
            this.lookUpButtonAccomCategory.AssociatedControl = "txtBillingCategory";
            this.lookUpButtonAccomCategory.Controller = "BillingCategory";
            this.lookUpButtonAccomCategory.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonAccomCategory.Location = new System.Drawing.Point(364, 42);
            this.lookUpButtonAccomCategory.Name = "lookUpButtonAccomCategory";
            this.lookUpButtonAccomCategory.ShowFieldsInLookUp.Add("BillingCategory");
            this.lookUpButtonAccomCategory.ShowFieldsInLookUp.Add("BillingCategoryDesc");
            this.lookUpButtonAccomCategory.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonAccomCategory.TabIndex = 2;
            this.lookUpButtonAccomCategory.TabStop = false;
            this.lookUpButtonAccomCategory.LookUpSelected += new System.EventHandler(this.LookUpButton1LookUpSelected);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkReadOnly);
            this.panel1.Controls.Add(this.chkReservationOnly);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lookUpButtonFoodType);
            this.panel1.Controls.Add(this.lookUpButtonFood);
            this.panel1.Controls.Add(this.lookUpButtonAccommClass);
            this.panel1.Controls.Add(this.txtFoodType);
            this.panel1.Controls.Add(this.lookUpButtonAccomCategory);
            this.panel1.Controls.Add(this.txtFoodClass);
            this.panel1.Controls.Add(this.txtBillingCategoryDesc);
            this.panel1.Controls.Add(this.txtAccomClass);
            this.panel1.Controls.Add(this.txtBillingCategory);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCreatedBy);
            this.panel1.Controls.Add(this.btnDuplicate);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.txtCreatedOn);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.txtUpdatedBy);
            this.panel1.Controls.Add(this.txtUpdatedOn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 351);
            this.panel1.TabIndex = 0;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(151, 262);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 10;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // chkReservationOnly
            // 
            this.chkReservationOnly.AutoSize = true;
            this.chkReservationOnly.Location = new System.Drawing.Point(151, 180);
            this.chkReservationOnly.Name = "chkReservationOnly";
            this.chkReservationOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReservationOnly.TabIndex = 10;
            this.chkReservationOnly.UseVisualStyleBackColor = true;
            // 
            // lookUpButtonFoodType
            // 
            this.lookUpButtonFoodType.AssociatedControl = "txtFoodType";
            this.lookUpButtonFoodType.Controller = "FoodType";
            this.lookUpButtonFoodType.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonFoodType.Location = new System.Drawing.Point(256, 150);
            this.lookUpButtonFoodType.Name = "lookUpButtonFoodType";
            this.lookUpButtonFoodType.ShowFieldsInLookUp.Add("FoodType");
            this.lookUpButtonFoodType.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonFoodType.TabIndex = 9;
            this.lookUpButtonFoodType.TabStop = false;
            // 
            // lookUpButtonFood
            // 
            this.lookUpButtonFood.AssociatedControl = "txtFoodClass";
            this.lookUpButtonFood.Controller = "FoodClass";
            this.lookUpButtonFood.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonFood.Location = new System.Drawing.Point(256, 123);
            this.lookUpButtonFood.Name = "lookUpButtonFood";
            this.lookUpButtonFood.ShowFieldsInLookUp.Add("FoodClass");
            this.lookUpButtonFood.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonFood.TabIndex = 7;
            this.lookUpButtonFood.TabStop = false;
            // 
            // lookUpButtonAccommClass
            // 
            this.lookUpButtonAccommClass.AssociatedControl = "txtAccomClass";
            this.lookUpButtonAccommClass.Controller = "AccomClass";
            this.lookUpButtonAccommClass.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonAccommClass.Location = new System.Drawing.Point(210, 96);
            this.lookUpButtonAccommClass.Name = "lookUpButtonAccommClass";
            this.lookUpButtonAccommClass.ShowFieldsInLookUp.Add("AccomClass");
            this.lookUpButtonAccommClass.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonAccommClass.TabIndex = 5;
            this.lookUpButtonAccommClass.TabStop = false;
            // 
            // txtFoodType
            // 
            this.txtFoodType.BackColor = System.Drawing.SystemColors.Window;
            this.txtFoodType.Location = new System.Drawing.Point(151, 151);
            this.txtFoodType.Name = "txtFoodType";
            this.txtFoodType.ReadOnly = true;
            this.txtFoodType.Size = new System.Drawing.Size(103, 20);
            this.txtFoodType.TabIndex = 8;
            // 
            // txtFoodClass
            // 
            this.txtFoodClass.BackColor = System.Drawing.SystemColors.Window;
            this.txtFoodClass.Location = new System.Drawing.Point(151, 124);
            this.txtFoodClass.Name = "txtFoodClass";
            this.txtFoodClass.ReadOnly = true;
            this.txtFoodClass.Size = new System.Drawing.Size(103, 20);
            this.txtFoodClass.TabIndex = 6;
            // 
            // txtBillingCategoryDesc
            // 
            this.txtBillingCategoryDesc.BackColor = System.Drawing.SystemColors.Window;
            this.txtBillingCategoryDesc.Location = new System.Drawing.Point(151, 70);
            this.txtBillingCategoryDesc.Name = "txtBillingCategoryDesc";
            this.txtBillingCategoryDesc.Size = new System.Drawing.Size(433, 20);
            this.txtBillingCategoryDesc.TabIndex = 3;
            // 
            // txtAccomClass
            // 
            this.txtAccomClass.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccomClass.Location = new System.Drawing.Point(151, 97);
            this.txtAccomClass.Name = "txtAccomClass";
            this.txtAccomClass.ReadOnly = true;
            this.txtAccomClass.Size = new System.Drawing.Size(57, 20);
            this.txtAccomClass.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Billing Category Desc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Food Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Read Only";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Reservation Only";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Food Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Accomm Class";
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Location = new System.Drawing.Point(179, 289);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(75, 23);
            this.btnDuplicate.TabIndex = 17;
            this.btnDuplicate.Text = "Duplicate";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            // 
            // BillingCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 351);
            this.Controls.Add(this.panel1);
            this.Name = "BillingCategoryForm";
            this.Text = "Billing Categories";
            this.Load += new System.EventHandler(this.AccomCategoryFormLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
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
        private System.Windows.Forms.Panel panel1;
        private Common.LookUpButton lookUpButtonFood;
        private Common.LookUpButton lookUpButtonAccommClass;
        private System.Windows.Forms.TextBox txtFoodClass;
        private System.Windows.Forms.TextBox txtAccomClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillingCategoryDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkReservationOnly;
        private System.Windows.Forms.Label label8;
        private Common.LookUpButton lookUpButtonFoodType;
        private System.Windows.Forms.TextBox txtFoodType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDuplicate;
    }
}