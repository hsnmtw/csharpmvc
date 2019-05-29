namespace MVCHIS.Customers {
    partial class ProjectForm {
        /// <summaryProject
        /// Required designer variable.
        /// </summaryProject
        private System.ComponentModel.IContainer components = null;

        /// <summaryProject
        /// Clean up any resources being used.
        /// </summaryProject
        /// <param name="disposing"Projecttrue if managed resources should be disposed; otherwise, false.</paramProject
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summaryProject
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summaryProject
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
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lookUpButtonClient = new MVCHIS.Common.LookUpButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstContracts = new System.Windows.Forms.ListBox();
            this.lblRowHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMetaDataCountryEnglish = new System.Windows.Forms.Label();
            this.txtClientShortName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lookUpButtonProjectName = new MVCHIS.Common.LookUpButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(72, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(180, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(288, 241);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedOn.Location = new System.Drawing.Point(226, 157);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 8;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedBy.Location = new System.Drawing.Point(151, 157);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 7;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedOn.Location = new System.Drawing.Point(226, 130);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 6;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedBy.Location = new System.Drawing.Point(151, 130);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 5;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 133);
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
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Record Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Project Name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtProjectName.Location = new System.Drawing.Point(151, 67);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(186, 20);
            this.txtProjectName.TabIndex = 1;
            // 
            // lookUpButtonClient
            // 
            this.lookUpButtonClient.AssociatedControl = "txtClientShortName";
            this.lookUpButtonClient.Controller = "Client";
            this.lookUpButtonClient.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonClient.Location = new System.Drawing.Point(341, 93);
            this.lookUpButtonClient.Name = "lookUpButtonClient";
            this.lookUpButtonClient.ShowFieldsInLookUp.Add("ShortName");
            this.lookUpButtonClient.ShowFieldsInLookUp.Add("LongName");
            this.lookUpButtonClient.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonClient.TabIndex = 4;
            this.lookUpButtonClient.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstContracts);
            this.panel2.Controls.Add(this.lblRowHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(413, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(265, 298);
            this.panel2.TabIndex = 1;
            // 
            // lstContracts
            // 
            this.lstContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstContracts.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContracts.FormattingEnabled = true;
            this.lstContracts.Location = new System.Drawing.Point(3, 20);
            this.lstContracts.Name = "lstContracts";
            this.lstContracts.Size = new System.Drawing.Size(259, 275);
            this.lstContracts.TabIndex = 0;
            // 
            // lblRowHeader
            // 
            this.lblRowHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRowHeader.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowHeader.Location = new System.Drawing.Point(3, 3);
            this.lblRowHeader.Name = "lblRowHeader";
            this.lblRowHeader.Size = new System.Drawing.Size(259, 17);
            this.lblRowHeader.TabIndex = 1;
            this.lblRowHeader.Text = "Contract";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkReadOnly);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblMetaDataCountryEnglish);
            this.panel1.Controls.Add(this.txtClientShortName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lookUpButtonProjectName);
            this.panel1.Controls.Add(this.lookUpButtonClient);
            this.panel1.Controls.Add(this.txtProjectName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCreatedBy);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtCreatedOn);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.txtUpdatedBy);
            this.panel1.Controls.Add(this.txtUpdatedOn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 298);
            this.panel1.TabIndex = 0;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(153, 190);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 49;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Read Only";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(137, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "?";
            // 
            // lblMetaDataCountryEnglish
            // 
            this.lblMetaDataCountryEnglish.AutoSize = true;
            this.lblMetaDataCountryEnglish.ForeColor = System.Drawing.Color.Red;
            this.lblMetaDataCountryEnglish.Location = new System.Drawing.Point(137, 97);
            this.lblMetaDataCountryEnglish.Name = "lblMetaDataCountryEnglish";
            this.lblMetaDataCountryEnglish.Size = new System.Drawing.Size(12, 13);
            this.lblMetaDataCountryEnglish.TabIndex = 48;
            this.lblMetaDataCountryEnglish.Text = "?";
            // 
            // txtClientShortName
            // 
            this.txtClientShortName.BackColor = System.Drawing.Color.White;
            this.txtClientShortName.Location = new System.Drawing.Point(151, 94);
            this.txtClientShortName.Name = "txtClientShortName";
            this.txtClientShortName.ReadOnly = true;
            this.txtClientShortName.Size = new System.Drawing.Size(186, 20);
            this.txtClientShortName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Client";
            // 
            // lookUpButtonProjectName
            // 
            this.lookUpButtonProjectName.AssociatedControl = "txtProjectName";
            this.lookUpButtonProjectName.Controller = "Project";
            this.lookUpButtonProjectName.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonProjectName.Location = new System.Drawing.Point(341, 67);
            this.lookUpButtonProjectName.Name = "lookUpButtonProjectName";
            this.lookUpButtonProjectName.ShowFieldsInLookUp.Add("ProjectName");
            this.lookUpButtonProjectName.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonProjectName.TabIndex = 2;
            this.lookUpButtonProjectName.TabStop = false;
            this.lookUpButtonProjectName.LookUpSelected += new System.EventHandler(this.LookUpButtonProjectNameLookUpSelected);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 298);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectForm";
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.ProjectTypeFormLoad);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtProjectName;
        private Common.LookUpButton lookUpButtonClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstContracts;
        private System.Windows.Forms.Label lblRowHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMetaDataCountryEnglish;
        private System.Windows.Forms.TextBox txtClientShortName;
        private System.Windows.Forms.Label label2;
        private Common.LookUpButton lookUpButtonProjectName;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label4;
    }
}