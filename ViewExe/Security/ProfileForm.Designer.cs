namespace MVCHIS.Security {
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfileDesc = new System.Windows.Forms.TextBox();
            this.btnPLProfile = new MVCHIS.Common.PickListButton();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lstProfileEntitlements = new MVCHIS.Utils.ListViewControl();
            this.txtEntitlementGroupId = new System.Windows.Forms.TextBox();
            this.txtEntitlementGroupName = new System.Windows.Forms.TextBox();
            this.btnPLEntitlementGroup = new MVCHIS.Common.PickListButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPE = new System.Windows.Forms.Button();
            this.btnEditPE = new System.Windows.Forms.Button();
            this.btnDeletePE = new System.Windows.Forms.Button();
            this.lstUsers = new MVCHIS.Utils.ListViewControl();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(71, 529);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(173, 529);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(270, 529);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.Location = new System.Drawing.Point(201, 477);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(144, 20);
            this.txtUpdatedOn.TabIndex = 14;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.Location = new System.Drawing.Point(126, 477);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 13;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Location = new System.Drawing.Point(201, 451);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(144, 20);
            this.txtCreatedOn.TabIndex = 12;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(126, 451);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 11;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Created by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Profile Name";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(126, 8);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            this.txtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Record Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Description";
            // 
            // txtProfileDesc
            // 
            this.txtProfileDesc.Location = new System.Drawing.Point(126, 62);
            this.txtProfileDesc.Name = "txtProfileDesc";
            this.txtProfileDesc.Size = new System.Drawing.Size(219, 20);
            this.txtProfileDesc.TabIndex = 3;
            // 
            // btnPLProfile
            // 
            this.btnPLProfile.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLProfile.Location = new System.Drawing.Point(197, 7);
            this.btnPLProfile.Name = "btnPLProfile";
            this.btnPLProfile.Size = new System.Drawing.Size(22, 22);
            this.btnPLProfile.Source = "Profile";
            this.btnPLProfile.TabIndex = 1;
            this.btnPLProfile.TabStop = false;
            this.btnPLProfile.Text = "↓";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(126, 36);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(219, 20);
            this.txtProfileName.TabIndex = 2;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(126, 506);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 15;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 506);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Read Only";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Entitlement Group";
            // 
            // lstProfileEntitlements
            // 
            this.lstProfileEntitlements.Filter = null;
            this.lstProfileEntitlements.FullRowSelect = true;
            this.lstProfileEntitlements.GridLines = true;
            this.lstProfileEntitlements.HideSelection = false;
            this.lstProfileEntitlements.LabelWrap = false;
            this.lstProfileEntitlements.Location = new System.Drawing.Point(19, 141);
            this.lstProfileEntitlements.MultiSelect = false;
            this.lstProfileEntitlements.Name = "lstProfileEntitlements";
            this.lstProfileEntitlements.Size = new System.Drawing.Size(326, 304);
            this.lstProfileEntitlements.TabIndex = 7;
            this.lstProfileEntitlements.UseCompatibleStateImageBehavior = false;
            this.lstProfileEntitlements.View = System.Windows.Forms.View.Details;
            this.lstProfileEntitlements.SelectedIndexChanged += new System.EventHandler(this.LstProfileEntitlements_SelectedIndexChanged);
            // 
            // txtEntitlementGroupId
            // 
            this.txtEntitlementGroupId.Location = new System.Drawing.Point(126, 90);
            this.txtEntitlementGroupId.Name = "txtEntitlementGroupId";
            this.txtEntitlementGroupId.ReadOnly = true;
            this.txtEntitlementGroupId.Size = new System.Drawing.Size(40, 20);
            this.txtEntitlementGroupId.TabIndex = 4;
            this.txtEntitlementGroupId.TextChanged += new System.EventHandler(this.TxtEntitlementGroupId_TextChanged);
            // 
            // txtEntitlementGroupName
            // 
            this.txtEntitlementGroupName.Location = new System.Drawing.Point(172, 90);
            this.txtEntitlementGroupName.Name = "txtEntitlementGroupName";
            this.txtEntitlementGroupName.ReadOnly = true;
            this.txtEntitlementGroupName.Size = new System.Drawing.Size(148, 20);
            this.txtEntitlementGroupName.TabIndex = 5;
            // 
            // btnPLEntitlementGroup
            // 
            this.btnPLEntitlementGroup.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLEntitlementGroup.Location = new System.Drawing.Point(322, 89);
            this.btnPLEntitlementGroup.Name = "btnPLEntitlementGroup";
            this.btnPLEntitlementGroup.Size = new System.Drawing.Size(22, 22);
            this.btnPLEntitlementGroup.Source = "EntitlementGroup";
            this.btnPLEntitlementGroup.TabIndex = 6;
            this.btnPLEntitlementGroup.TabStop = false;
            this.btnPLEntitlementGroup.Text = "↓";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Entitlements";
            // 
            // btnAddPE
            // 
            this.btnAddPE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPE.Enabled = false;
            this.btnAddPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPE.Location = new System.Drawing.Point(351, 223);
            this.btnAddPE.Name = "btnAddPE";
            this.btnAddPE.Size = new System.Drawing.Size(32, 28);
            this.btnAddPE.TabIndex = 10;
            this.btnAddPE.TabStop = false;
            this.btnAddPE.Text = "➕";
            this.btnAddPE.UseVisualStyleBackColor = true;
            this.btnAddPE.Click += new System.EventHandler(this.BtnAddPE_Click);
            // 
            // btnEditPE
            // 
            this.btnEditPE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPE.Enabled = false;
            this.btnEditPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditPE.Location = new System.Drawing.Point(351, 182);
            this.btnEditPE.Name = "btnEditPE";
            this.btnEditPE.Size = new System.Drawing.Size(32, 28);
            this.btnEditPE.TabIndex = 9;
            this.btnEditPE.TabStop = false;
            this.btnEditPE.Text = "✎";
            this.btnEditPE.UseVisualStyleBackColor = true;
            this.btnEditPE.Click += new System.EventHandler(this.BtnEditPE_Click);
            // 
            // btnDeletePE
            // 
            this.btnDeletePE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePE.Enabled = false;
            this.btnDeletePE.ForeColor = System.Drawing.Color.Red;
            this.btnDeletePE.Location = new System.Drawing.Point(351, 141);
            this.btnDeletePE.Name = "btnDeletePE";
            this.btnDeletePE.Size = new System.Drawing.Size(32, 28);
            this.btnDeletePE.TabIndex = 8;
            this.btnDeletePE.TabStop = false;
            this.btnDeletePE.Text = "✖";
            this.btnDeletePE.UseVisualStyleBackColor = true;
            this.btnDeletePE.Click += new System.EventHandler(this.BtnDeletePE_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.Filter = null;
            this.lstUsers.FullRowSelect = true;
            this.lstUsers.GridLines = true;
            this.lstUsers.HideSelection = false;
            this.lstUsers.LabelWrap = false;
            this.lstUsers.Location = new System.Drawing.Point(397, 141);
            this.lstUsers.MultiSelect = false;
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(215, 304);
            this.lstUsers.TabIndex = 50;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Users";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.btnAddPE);
            this.Controls.Add(this.btnEditPE);
            this.Controls.Add(this.btnDeletePE);
            this.Controls.Add(this.lstProfileEntitlements);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPLEntitlementGroup);
            this.Controls.Add(this.btnPLProfile);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEntitlementGroupName);
            this.Controls.Add(this.txtEntitlementGroupId);
            this.Controls.Add(this.txtProfileDesc);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ProfileForm";
            this.Size = new System.Drawing.Size(622, 560);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfileDesc;
        private Common.PickListButton btnPLProfile;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private Utils.ListViewControl lstProfileEntitlements;
        private System.Windows.Forms.TextBox txtEntitlementGroupId;
        private System.Windows.Forms.TextBox txtEntitlementGroupName;
        private Common.PickListButton btnPLEntitlementGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPE;
        private System.Windows.Forms.Button btnEditPE;
        private System.Windows.Forms.Button btnDeletePE;
        private Utils.ListViewControl lstUsers;
        private System.Windows.Forms.Label label7;
    }
}