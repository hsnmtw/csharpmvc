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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfileDesc = new System.Windows.Forms.TextBox();
            this.ProfileNameLookup = new MVCHIS.Common.LookUpButton();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstEntitlements = new System.Windows.Forms.ListBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAllowAll = new System.Windows.Forms.Button();
            this.btnUnallowAll = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEntitelmentsGroup = new System.Windows.Forms.ComboBox();
            this.btnInitializeEntitlements = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(392, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(392, 247);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            
            this.txtUpdatedOn.Location = new System.Drawing.Point(201, 470);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(182, 20);
            this.txtUpdatedOn.TabIndex = 15;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            
            this.txtUpdatedBy.Location = new System.Drawing.Point(126, 470);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 14;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            
            this.txtCreatedOn.Location = new System.Drawing.Point(201, 444);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(182, 20);
            this.txtCreatedOn.TabIndex = 13;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            
            this.txtCreatedBy.Location = new System.Drawing.Point(126, 444);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 12;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 450);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Entitlements";
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
            this.txtProfileDesc.Size = new System.Drawing.Size(341, 20);
            this.txtProfileDesc.TabIndex = 3;
            // 
            // ProfileNameLookup
            // 
            this.ProfileNameLookup.AssociatedControl = "txtProfileName";
            this.ProfileNameLookup.Tag = null;
            this.ProfileNameLookup.Controller = "Profile";
            //new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.ProfileNameLookup.Location = new System.Drawing.Point(342, 35);
            this.ProfileNameLookup.Name = "ProfileNameLookup";
            this.ProfileNameLookup.SelectedValueIndex = 0;
            this.ProfileNameLookup.ShowFieldsInLookUp.Add("ProfileName");
            this.ProfileNameLookup.Size = new System.Drawing.Size(22, 22);
            this.ProfileNameLookup.TabIndex = 2;
            this.ProfileNameLookup.TabStop = false;
            this.ProfileNameLookup.LookUpSelected += new System.EventHandler(this.ProfileNameLookupLookUpSelected);
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(126, 36);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(215, 20);
            this.txtProfileName.TabIndex = 1;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(126, 499);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 16;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Read Only";
            // 
            // lstEntitlements
            // 
            //new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEntitlements.FormattingEnabled = true;
            this.lstEntitlements.Location = new System.Drawing.Point(126, 118);
            this.lstEntitlements.Name = "lstEntitlements";
            this.lstEntitlements.Size = new System.Drawing.Size(257, 316);
            this.lstEntitlements.TabIndex = 5;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(392, 118);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnAllowAll
            // 
            this.btnAllowAll.Location = new System.Drawing.Point(392, 161);
            this.btnAllowAll.Name = "btnAllowAll";
            this.btnAllowAll.Size = new System.Drawing.Size(75, 23);
            this.btnAllowAll.TabIndex = 7;
            this.btnAllowAll.Text = "&Allow All";
            this.btnAllowAll.UseVisualStyleBackColor = true;
            this.btnAllowAll.Click += new System.EventHandler(this.BtnAllowAll_Click);
            // 
            // btnUnallowAll
            // 
            this.btnUnallowAll.Location = new System.Drawing.Point(392, 204);
            this.btnUnallowAll.Name = "btnUnallowAll";
            this.btnUnallowAll.Size = new System.Drawing.Size(75, 23);
            this.btnUnallowAll.TabIndex = 8;
            this.btnUnallowAll.Text = "&Unallow All";
            this.btnUnallowAll.UseVisualStyleBackColor = true;
            this.btnUnallowAll.Click += new System.EventHandler(this.BtnUnallowAll_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            //new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Legend:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            //new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(398, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "R: Read";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            //new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(398, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "U: Update";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            //new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(398, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "D: Delete";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            //new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(398, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "C: Create";
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
            // cmbEntitelmentsGroup
            // 
            this.cmbEntitelmentsGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntitelmentsGroup.FormattingEnabled = true;
            this.cmbEntitelmentsGroup.Location = new System.Drawing.Point(126, 89);
            this.cmbEntitelmentsGroup.Name = "cmbEntitelmentsGroup";
            this.cmbEntitelmentsGroup.Size = new System.Drawing.Size(341, 21);
            this.cmbEntitelmentsGroup.TabIndex = 4;
            this.cmbEntitelmentsGroup.SelectedIndexChanged += new System.EventHandler(this.CmbEntitelmentsGroup_SelectedIndexChanged);
            // 
            // btnInitializeEntitlements
            // 
            this.btnInitializeEntitlements.Location = new System.Drawing.Point(370, 34);
            this.btnInitializeEntitlements.Name = "btnInitializeEntitlements";
            this.btnInitializeEntitlements.Size = new System.Drawing.Size(97, 23);
            this.btnInitializeEntitlements.TabIndex = 6;
            this.btnInitializeEntitlements.Text = "&Initialize";
            this.btnInitializeEntitlements.UseVisualStyleBackColor = true;
            this.btnInitializeEntitlements.Click += new System.EventHandler(this.BtnInitializeEntitlements_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 527);
            this.Controls.Add(this.cmbEntitelmentsGroup);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUnallowAll);
            this.Controls.Add(this.btnAllowAll);
            this.Controls.Add(this.btnInitializeEntitlements);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lstEntitlements);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ProfileNameLookup);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProfileDesc);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label13);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfileDesc;
        private Common.LookUpButton ProfileNameLookup;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstEntitlements;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAllowAll;
        private System.Windows.Forms.Button btnUnallowAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbEntitelmentsGroup;
        private System.Windows.Forms.Button btnInitializeEntitlements;
    }
}