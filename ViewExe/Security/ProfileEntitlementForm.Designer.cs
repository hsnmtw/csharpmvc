namespace MVCHIS.Security {
    partial class ProfileEntitlementForm {
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
        private void InitializeComponent(){
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUpdatedOn = new System.Windows.Forms.TextBox();
            this.txtUpdatedBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreatedOn = new System.Windows.Forms.TextBox();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntitlementName = new System.Windows.Forms.TextBox();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkAllowDelete = new System.Windows.Forms.CheckBox();
            this.chkAllowUpdate = new System.Windows.Forms.CheckBox();
            this.chkAllowRead = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.chkAllowCreate = new System.Windows.Forms.CheckBox();
            this.btnPLProfile = new MVCHIS.Common.PickListButton();
            this.btnPLEntitlement = new MVCHIS.Common.PickListButton();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPLProfileEntitlement = new MVCHIS.Common.PickListButton();
            this.txtEntitlementId = new System.Windows.Forms.TextBox();
            this.txtProfileId = new System.Windows.Forms.TextBox();
            this.btnSelectUnselectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(199, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.Enabled = false;
            this.txtUpdatedOn.Location = new System.Drawing.Point(236, 236);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 16;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.Enabled = false;
            this.txtUpdatedBy.Location = new System.Drawing.Point(161, 236);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 15;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Enabled = false;
            this.txtCreatedOn.Location = new System.Drawing.Point(236, 205);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 14;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Location = new System.Drawing.Point(161, 205);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 13;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Created by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Entitlement";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(161, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Record Id";
            // 
            // txtEntitlementName
            // 
            this.txtEntitlementName.Location = new System.Drawing.Point(203, 74);
            this.txtEntitlementName.Name = "txtEntitlementName";
            this.txtEntitlementName.ReadOnly = true;
            this.txtEntitlementName.Size = new System.Drawing.Size(151, 20);
            this.txtEntitlementName.TabIndex = 6;
            this.txtEntitlementName.TabStop = false;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(161, 267);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 17;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Read Only";
            // 
            // chkAllowDelete
            // 
            this.chkAllowDelete.AutoSize = true;
            this.chkAllowDelete.Location = new System.Drawing.Point(273, 129);
            this.chkAllowDelete.Name = "chkAllowDelete";
            this.chkAllowDelete.Size = new System.Drawing.Size(85, 17);
            this.chkAllowDelete.TabIndex = 11;
            this.chkAllowDelete.Text = "Allow Delete";
            this.chkAllowDelete.UseVisualStyleBackColor = true;
            // 
            // chkAllowUpdate
            // 
            this.chkAllowUpdate.AutoSize = true;
            this.chkAllowUpdate.Location = new System.Drawing.Point(273, 104);
            this.chkAllowUpdate.Name = "chkAllowUpdate";
            this.chkAllowUpdate.Size = new System.Drawing.Size(89, 17);
            this.chkAllowUpdate.TabIndex = 9;
            this.chkAllowUpdate.Text = "Allow Update";
            this.chkAllowUpdate.UseVisualStyleBackColor = true;
            // 
            // chkAllowRead
            // 
            this.chkAllowRead.AutoSize = true;
            this.chkAllowRead.Location = new System.Drawing.Point(161, 130);
            this.chkAllowRead.Name = "chkAllowRead";
            this.chkAllowRead.Size = new System.Drawing.Size(79, 17);
            this.chkAllowRead.TabIndex = 10;
            this.chkAllowRead.Text = "Allow Read";
            this.chkAllowRead.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Profile";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(204, 43);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.ReadOnly = true;
            this.txtProfileName.Size = new System.Drawing.Size(151, 20);
            this.txtProfileName.TabIndex = 3;
            this.txtProfileName.TabStop = false;
            // 
            // chkAllowCreate
            // 
            this.chkAllowCreate.AutoSize = true;
            this.chkAllowCreate.Location = new System.Drawing.Point(161, 105);
            this.chkAllowCreate.Name = "chkAllowCreate";
            this.chkAllowCreate.Size = new System.Drawing.Size(87, 17);
            this.chkAllowCreate.TabIndex = 8;
            this.chkAllowCreate.Text = "Allow Create";
            this.chkAllowCreate.UseVisualStyleBackColor = true;
            // 
            // btnPLProfile
            // 
            this.btnPLProfile.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLProfile.Location = new System.Drawing.Point(357, 42);
            this.btnPLProfile.Name = "btnPLProfile";
            this.btnPLProfile.Size = new System.Drawing.Size(22, 22);
            this.btnPLProfile.Source = "Profile";
            this.btnPLProfile.TabIndex = 4;
            this.btnPLProfile.TabStop = false;
            this.btnPLProfile.Text = "↓";
            // 
            // btnPLEntitlement
            // 
            this.btnPLEntitlement.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLEntitlement.Location = new System.Drawing.Point(356, 73);
            this.btnPLEntitlement.Name = "btnPLEntitlement";
            this.btnPLEntitlement.Size = new System.Drawing.Size(22, 22);
            this.btnPLEntitlement.Source = "Entitlement";
            this.btnPLEntitlement.TabIndex = 7;
            this.btnPLEntitlement.TabStop = false;
            this.btnPLEntitlement.Text = "↓";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(297, 308);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(101, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPLProfileEntitlement
            // 
            this.btnPLProfileEntitlement.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLProfileEntitlement.Location = new System.Drawing.Point(230, 11);
            this.btnPLProfileEntitlement.Name = "btnPLProfileEntitlement";
            this.btnPLProfileEntitlement.Size = new System.Drawing.Size(22, 22);
            this.btnPLProfileEntitlement.Source = "ProfileEntitlement";
            this.btnPLProfileEntitlement.TabIndex = 1;
            this.btnPLProfileEntitlement.TabStop = false;
            this.btnPLProfileEntitlement.Text = "↓";
            // 
            // txtEntitlementId
            // 
            this.txtEntitlementId.Location = new System.Drawing.Point(161, 74);
            this.txtEntitlementId.Name = "txtEntitlementId";
            this.txtEntitlementId.ReadOnly = true;
            this.txtEntitlementId.Size = new System.Drawing.Size(36, 20);
            this.txtEntitlementId.TabIndex = 5;
            this.txtEntitlementId.TextChanged += new System.EventHandler(this.TxtEntitlementId_TextChanged);
            // 
            // txtProfileId
            // 
            this.txtProfileId.Location = new System.Drawing.Point(161, 43);
            this.txtProfileId.Name = "txtProfileId";
            this.txtProfileId.ReadOnly = true;
            this.txtProfileId.Size = new System.Drawing.Size(36, 20);
            this.txtProfileId.TabIndex = 2;
            this.txtProfileId.TextChanged += new System.EventHandler(this.TxtProfileId_TextChanged);
            // 
            // btnSelectUnselectAll
            // 
            this.btnSelectUnselectAll.Location = new System.Drawing.Point(161, 161);
            this.btnSelectUnselectAll.Name = "btnSelectUnselectAll";
            this.btnSelectUnselectAll.Size = new System.Drawing.Size(144, 23);
            this.btnSelectUnselectAll.TabIndex = 12;
            this.btnSelectUnselectAll.Text = "Select / Unselect all";
            this.btnSelectUnselectAll.UseVisualStyleBackColor = true;
            this.btnSelectUnselectAll.Click += new System.EventHandler(this.BtnSelectUnselectAll_Click);
            // 
            // ProfileEntitlementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSelectUnselectAll);
            this.Controls.Add(this.btnPLEntitlement);
            this.Controls.Add(this.btnPLProfileEntitlement);
            this.Controls.Add(this.btnPLProfile);
            this.Controls.Add(this.chkAllowCreate);
            this.Controls.Add(this.chkAllowRead);
            this.Controls.Add(this.chkAllowUpdate);
            this.Controls.Add(this.chkAllowDelete);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtProfileId);
            this.Controls.Add(this.txtEntitlementId);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.txtEntitlementName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "ProfileEntitlementForm";
            this.Size = new System.Drawing.Size(392, 355);
            this.Load += new System.EventHandler(this.EntitlementFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUpdatedOn;
        private System.Windows.Forms.TextBox txtUpdatedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreatedOn;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntitlementName;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkAllowDelete;
        private System.Windows.Forms.CheckBox chkAllowUpdate;
        private System.Windows.Forms.CheckBox chkAllowRead;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.CheckBox chkAllowCreate;
        private Common.PickListButton btnPLProfile;
        private Common.PickListButton btnPLEntitlement;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private Common.PickListButton btnPLProfileEntitlement;
        private System.Windows.Forms.TextBox txtEntitlementId;
        private System.Windows.Forms.TextBox txtProfileId;
        private System.Windows.Forms.Button btnSelectUnselectAll;
    }
}