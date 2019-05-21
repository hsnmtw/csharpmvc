namespace ViewWinform.Billing.AccomodationCategories {
    partial class AccomodationCategoryForm {
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
            this.txtAccomodationCateogy = new System.Windows.Forms.TextBox();
            this.lookUpButtonAccomCategory = new ViewWinform.Common.LookUpButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lookUpButtonFood = new ViewWinform.Common.LookUpButton();
            this.lookUpButtonAccommClass = new ViewWinform.Common.LookUpButton();
            this.txtFoodClass = new System.Windows.Forms.TextBox();
            this.txtAcommClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(71, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(287, 267);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedOn.Location = new System.Drawing.Point(225, 217);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 10;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedBy.Location = new System.Drawing.Point(151, 217);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 9;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedOn.Location = new System.Drawing.Point(225, 191);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 8;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedBy.Location = new System.Drawing.Point(151, 191);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 7;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Created by";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(151, 40);
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
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Accomm Category";
            // 
            // txtAccomodationCateogy
            // 
            this.txtAccomodationCateogy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAccomodationCateogy.Location = new System.Drawing.Point(151, 73);
            this.txtAccomodationCateogy.Name = "txtAccomodationCateogy";
            this.txtAccomodationCateogy.ReadOnly = true;
            this.txtAccomodationCateogy.Size = new System.Drawing.Size(481, 20);
            this.txtAccomodationCateogy.TabIndex = 1;
            // 
            // lookUpButtonAccomCategory
            // 
            this.lookUpButtonAccomCategory.AssociatedControl = "txtAccomodationCateogy";
            this.lookUpButtonAccomCategory.Controller = "AccomCategory";
            this.lookUpButtonAccomCategory.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonAccomCategory.Location = new System.Drawing.Point(634, 72);
            this.lookUpButtonAccomCategory.Name = "lookUpButtonAccomCategory";
            this.lookUpButtonAccomCategory.ShowFieldsInLookUp.Add("Accom_Category");
            this.lookUpButtonAccomCategory.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonAccomCategory.TabIndex = 2;
            this.lookUpButtonAccomCategory.TabStop = false;
            this.lookUpButtonAccomCategory.LookUpSelected += new System.EventHandler(this.LookUpButton1_LookUpSelected);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lookUpButtonFood);
            this.panel1.Controls.Add(this.lookUpButtonAccommClass);
            this.panel1.Controls.Add(this.lookUpButtonAccomCategory);
            this.panel1.Controls.Add(this.txtFoodClass);
            this.panel1.Controls.Add(this.txtAcommClass);
            this.panel1.Controls.Add(this.txtAccomodationCateogy);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCreatedBy);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtCreatedOn);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.txtUpdatedBy);
            this.panel1.Controls.Add(this.txtUpdatedOn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 311);
            this.panel1.TabIndex = 0;
            // 
            // lookUpButtonFood
            // 
            this.lookUpButtonFood.AssociatedControl = "txtFoodClass";
            this.lookUpButtonFood.Controller = "FoodClass";
            this.lookUpButtonFood.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonFood.Location = new System.Drawing.Point(256, 126);
            this.lookUpButtonFood.Name = "lookUpButtonFood";
            this.lookUpButtonFood.ShowFieldsInLookUp.Add("Food_Class");
            this.lookUpButtonFood.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonFood.TabIndex = 6;
            this.lookUpButtonFood.TabStop = false;
            this.lookUpButtonFood.LookUpSelected += new System.EventHandler(this.LookUpButton1_LookUpSelected);
            // 
            // lookUpButtonAccommClass
            // 
            this.lookUpButtonAccommClass.AssociatedControl = "txtAcommClass";
            this.lookUpButtonAccommClass.Controller = "AccomClass";
            this.lookUpButtonAccommClass.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonAccommClass.Location = new System.Drawing.Point(210, 99);
            this.lookUpButtonAccommClass.Name = "lookUpButtonAccommClass";
            this.lookUpButtonAccommClass.ShowFieldsInLookUp.Add("Accom_Class");
            this.lookUpButtonAccommClass.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonAccommClass.TabIndex = 4;
            this.lookUpButtonAccommClass.TabStop = false;
            this.lookUpButtonAccommClass.LookUpSelected += new System.EventHandler(this.LookUpButton1_LookUpSelected);
            // 
            // txtFoodClass
            // 
            this.txtFoodClass.BackColor = System.Drawing.SystemColors.Window;
            this.txtFoodClass.Location = new System.Drawing.Point(151, 127);
            this.txtFoodClass.Name = "txtFoodClass";
            this.txtFoodClass.ReadOnly = true;
            this.txtFoodClass.Size = new System.Drawing.Size(103, 20);
            this.txtFoodClass.TabIndex = 5;
            // 
            // txtAcommClass
            // 
            this.txtAcommClass.BackColor = System.Drawing.SystemColors.Window;
            this.txtAcommClass.Location = new System.Drawing.Point(151, 100);
            this.txtAcommClass.Name = "txtAcommClass";
            this.txtAcommClass.ReadOnly = true;
            this.txtAcommClass.Size = new System.Drawing.Size(57, 20);
            this.txtAcommClass.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Food Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Accomm Class";
            // 
            // AccomodationCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 311);
            this.Controls.Add(this.panel1);
            this.Name = "AccomodationCategoryForm";
            this.Text = "Accomodation Categories";
            this.Load += new System.EventHandler(this.AccomCategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtAccomodationCateogy;
        private Common.LookUpButton lookUpButtonAccomCategory;
        private System.Windows.Forms.Panel panel1;
        private Common.LookUpButton lookUpButtonFood;
        private Common.LookUpButton lookUpButtonAccommClass;
        private System.Windows.Forms.TextBox txtFoodClass;
        private System.Windows.Forms.TextBox txtAcommClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}