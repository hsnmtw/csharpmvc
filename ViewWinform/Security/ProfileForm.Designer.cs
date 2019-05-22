namespace ViewWinform.Security.Profiles {
    partial class ProfileForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstNotSelectedEntitlements = new System.Windows.Forms.ListBox();
            this.lstSelectedEntitlements = new System.Windows.Forms.ListBox();
            this.btnSelectEntitlement = new System.Windows.Forms.Button();
            this.btnUnSelectEntitlement = new System.Windows.Forms.Button();
            this.btnUnSelectAllEntitlements = new System.Windows.Forms.Button();
            this.btnSelectAllEntitlements = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfileDesc = new System.Windows.Forms.TextBox();
            this.ProfileNameLookup = new ViewWinform.Common.LookUpButton();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(283, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(391, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(499, 359);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedOn.Location = new System.Drawing.Point(233, 308);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 13;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedBy.Location = new System.Drawing.Point(158, 308);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 12;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedOn.Location = new System.Drawing.Point(233, 282);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 11;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedBy.Location = new System.Drawing.Point(158, 282);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 10;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Created by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Profile Name";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(158, 12);
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
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Entitlements";
            // 
            // lstNotSelectedEntitlements
            // 
            this.lstNotSelectedEntitlements.FormattingEnabled = true;
            this.lstNotSelectedEntitlements.Location = new System.Drawing.Point(158, 95);
            this.lstNotSelectedEntitlements.Name = "lstNotSelectedEntitlements";
            this.lstNotSelectedEntitlements.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstNotSelectedEntitlements.Size = new System.Drawing.Size(182, 173);
            this.lstNotSelectedEntitlements.TabIndex = 4;
            // 
            // lstSelectedEntitlements
            // 
            this.lstSelectedEntitlements.FormattingEnabled = true;
            this.lstSelectedEntitlements.Location = new System.Drawing.Point(393, 95);
            this.lstSelectedEntitlements.Name = "lstSelectedEntitlements";
            this.lstSelectedEntitlements.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSelectedEntitlements.Size = new System.Drawing.Size(182, 173);
            this.lstSelectedEntitlements.TabIndex = 9;
            // 
            // btnSelectEntitlement
            // 
            this.btnSelectEntitlement.Location = new System.Drawing.Point(346, 151);
            this.btnSelectEntitlement.Name = "btnSelectEntitlement";
            this.btnSelectEntitlement.Size = new System.Drawing.Size(41, 23);
            this.btnSelectEntitlement.TabIndex = 6;
            this.btnSelectEntitlement.Text = ">";
            this.btnSelectEntitlement.UseVisualStyleBackColor = true;
            this.btnSelectEntitlement.Click += new System.EventHandler(this.Button1Click);
            // 
            // btnUnSelectEntitlement
            // 
            this.btnUnSelectEntitlement.Location = new System.Drawing.Point(346, 191);
            this.btnUnSelectEntitlement.Name = "btnUnSelectEntitlement";
            this.btnUnSelectEntitlement.Size = new System.Drawing.Size(41, 23);
            this.btnUnSelectEntitlement.TabIndex = 7;
            this.btnUnSelectEntitlement.Text = "<";
            this.btnUnSelectEntitlement.UseVisualStyleBackColor = true;
            this.btnUnSelectEntitlement.Click += new System.EventHandler(this.Button5Click);
            // 
            // btnUnSelectAllEntitlements
            // 
            this.btnUnSelectAllEntitlements.Location = new System.Drawing.Point(346, 230);
            this.btnUnSelectAllEntitlements.Name = "btnUnSelectAllEntitlements";
            this.btnUnSelectAllEntitlements.Size = new System.Drawing.Size(41, 23);
            this.btnUnSelectAllEntitlements.TabIndex = 8;
            this.btnUnSelectAllEntitlements.Text = "<<";
            this.btnUnSelectAllEntitlements.UseVisualStyleBackColor = true;
            this.btnUnSelectAllEntitlements.Click += new System.EventHandler(this.Button7Click);
            // 
            // btnSelectAllEntitlements
            // 
            this.btnSelectAllEntitlements.Location = new System.Drawing.Point(346, 108);
            this.btnSelectAllEntitlements.Name = "btnSelectAllEntitlements";
            this.btnSelectAllEntitlements.Size = new System.Drawing.Size(41, 23);
            this.btnSelectAllEntitlements.TabIndex = 5;
            this.btnSelectAllEntitlements.Text = ">>";
            this.btnSelectAllEntitlements.UseVisualStyleBackColor = true;
            this.btnSelectAllEntitlements.Click += new System.EventHandler(this.Button8Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Description";
            // 
            // txtProfileDesc
            // 
            this.txtProfileDesc.Location = new System.Drawing.Point(158, 66);
            this.txtProfileDesc.Name = "txtProfileDesc";
            this.txtProfileDesc.Size = new System.Drawing.Size(416, 20);
            this.txtProfileDesc.TabIndex = 3;
            this.txtProfileDesc.TabStop = false;
            // 
            // ProfileNameLookup
            // 
            this.ProfileNameLookup.AssociatedControl = "ProfileNameTextBox";
            this.ProfileNameLookup.Controller = "Profile";
            this.ProfileNameLookup.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.ProfileNameLookup.Location = new System.Drawing.Point(359, 37);
            this.ProfileNameLookup.Name = "ProfileNameLookup";
            this.ProfileNameLookup.ShowFieldsInLookUp.Add("ProfileName");
            this.ProfileNameLookup.Size = new System.Drawing.Size(22, 22);
            this.ProfileNameLookup.TabIndex = 2;
            this.ProfileNameLookup.LookUpSelected += new System.EventHandler(this.ProfileNameLookupLookUpSelected);
            // 
            // txtProfileName
            // 
            this.txtProfileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtProfileName.Location = new System.Drawing.Point(158, 38);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(199, 20);
            this.txtProfileName.TabIndex = 1;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(158, 337);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 48;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Read Only";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 404);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ProfileNameLookup);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.btnUnSelectAllEntitlements);
            this.Controls.Add(this.btnUnSelectEntitlement);
            this.Controls.Add(this.btnSelectAllEntitlements);
            this.Controls.Add(this.btnSelectEntitlement);
            this.Controls.Add(this.lstSelectedEntitlements);
            this.Controls.Add(this.lstNotSelectedEntitlements);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProfileDesc);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ProfileForm";
            this.Text = "Profiles";
            this.Load += new System.EventHandler(this.ProfileFormLoad);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstNotSelectedEntitlements;
        private System.Windows.Forms.ListBox lstSelectedEntitlements;
        private System.Windows.Forms.Button btnSelectEntitlement;
        private System.Windows.Forms.Button btnUnSelectEntitlement;
        private System.Windows.Forms.Button btnUnSelectAllEntitlements;
        private System.Windows.Forms.Button btnSelectAllEntitlements;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfileDesc;
        private Common.LookUpButton ProfileNameLookup;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label10;
    }
}