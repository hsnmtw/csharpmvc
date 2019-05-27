namespace MVCWinform.Housing.Buildings {
    partial class BuildingForm {
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
            this.txtCompoundName = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
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
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.lookUpButton1 = new MVCWinform.Common.LookUpButton();
            this.lookupComound = new MVCWinform.Common.LookUpButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.lblRowHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lookUpButtonBuildingType = new MVCWinform.Common.LookUpButton();
            this.txtBuildingType = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCompoundName
            // 
            this.txtCompoundName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCompoundName.Location = new System.Drawing.Point(151, 131);
            this.txtCompoundName.Name = "txtCompoundName";
            this.txtCompoundName.ReadOnly = true;
            this.txtCompoundName.Size = new System.Drawing.Size(154, 20);
            this.txtCompoundName.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(71, 267);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(287, 267);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedOn.Location = new System.Drawing.Point(225, 200);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 10;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedBy.Location = new System.Drawing.Point(151, 200);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 9;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedOn.Location = new System.Drawing.Point(225, 174);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 8;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedBy.Location = new System.Drawing.Point(151, 174);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 7;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Created by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Comound Name";
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
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Record Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Building Name";
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBuildingName.Location = new System.Drawing.Point(151, 73);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(154, 20);
            this.txtBuildingName.TabIndex = 1;
            // 
            // lookUpButton1
            // 
            this.lookUpButton1.AssociatedControl = "txtBuildingName";
            this.lookUpButton1.Controller = "Building";
            this.lookUpButton1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButton1.Location = new System.Drawing.Point(306, 72);
            this.lookUpButton1.Name = "lookUpButton1";
            this.lookUpButton1.ShowFieldsInLookUp.Add("BuildingName");
            this.lookUpButton1.ShowFieldsInLookUp.Add("CompoundName");
            this.lookUpButton1.Size = new System.Drawing.Size(22, 22);
            this.lookUpButton1.TabIndex = 2;
            this.lookUpButton1.TabStop = false;
            this.lookUpButton1.LookUpSelected += new System.EventHandler(this.LookUpButton1LookUpSelected);
            // 
            // lookupComound
            // 
            this.lookupComound.AssociatedControl = "txtCompoundName";
            this.lookupComound.Controller = "Compound";
            this.lookupComound.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookupComound.Location = new System.Drawing.Point(306, 130);
            this.lookupComound.Name = "lookupComound";
            this.lookupComound.ShowFieldsInLookUp.Add("CompoundName");
            this.lookupComound.Size = new System.Drawing.Size(22, 22);
            this.lookupComound.TabIndex = 6;
            this.lookupComound.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstRooms);
            this.panel2.Controls.Add(this.lblRowHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(413, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(265, 311);
            this.panel2.TabIndex = 1;
            // 
            // lstRooms
            // 
            this.lstRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRooms.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.Location = new System.Drawing.Point(3, 20);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(259, 288);
            this.lstRooms.TabIndex = 1;
            // 
            // lblRowHeader
            // 
            this.lblRowHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRowHeader.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowHeader.Location = new System.Drawing.Point(3, 3);
            this.lblRowHeader.Name = "lblRowHeader";
            this.lblRowHeader.Size = new System.Drawing.Size(259, 17);
            this.lblRowHeader.TabIndex = 0;
            this.lblRowHeader.Text = "RoomName";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkReadOnly);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lookUpButton1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBuildingName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lookUpButtonBuildingType);
            this.panel1.Controls.Add(this.lookupComound);
            this.panel1.Controls.Add(this.txtBuildingType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCompoundName);
            this.panel1.Controls.Add(this.txtCreatedBy);
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
            this.panel1.Size = new System.Drawing.Size(413, 311);
            this.panel1.TabIndex = 0;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(151, 231);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 46;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Read Only";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Building Type";
            // 
            // lookUpButtonBuildingType
            // 
            this.lookUpButtonBuildingType.AssociatedControl = "txtBuildingType";
            this.lookUpButtonBuildingType.Controller = "BuildingType";
            this.lookUpButtonBuildingType.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonBuildingType.Location = new System.Drawing.Point(306, 102);
            this.lookUpButtonBuildingType.Name = "lookUpButtonBuildingType";
            this.lookUpButtonBuildingType.ShowFieldsInLookUp.Add("BuildingType");
            this.lookUpButtonBuildingType.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonBuildingType.TabIndex = 4;
            this.lookUpButtonBuildingType.TabStop = false;
            // 
            // txtBuildingType
            // 
            this.txtBuildingType.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuildingType.Location = new System.Drawing.Point(151, 103);
            this.txtBuildingType.Name = "txtBuildingType";
            this.txtBuildingType.ReadOnly = true;
            this.txtBuildingType.Size = new System.Drawing.Size(154, 20);
            this.txtBuildingType.TabIndex = 3;
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "BuildingForm";
            this.Text = "Buildings";
            this.Load += new System.EventHandler(this.BuildingFormLoad);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.LookUpButton lookupComound;
        private System.Windows.Forms.TextBox txtCompoundName;
        private System.Windows.Forms.Button btnRemove;
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
        private System.Windows.Forms.TextBox txtBuildingName;
        private Common.LookUpButton lookUpButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.Label lblRowHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Common.LookUpButton lookUpButtonBuildingType;
        private System.Windows.Forms.TextBox txtBuildingType;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label10;
    }
}