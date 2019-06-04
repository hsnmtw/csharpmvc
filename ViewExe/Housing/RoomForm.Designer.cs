namespace MVCHIS.Housing.Rooms {
    partial class RoomForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtBuildingId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtUpdatedOn = new System.Windows.Forms.TextBox();
            this.txtUpdatedBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreatedOn = new System.Windows.Forms.TextBox();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCountryId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.lookUpButton1 = new MVCHIS.Common.LookUpButton();
            this.lookupCountry = new MVCHIS.Common.LookUpButton();
            this.lookupBuilding = new MVCHIS.Common.LookUpButton();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumberOfWindows = new System.Windows.Forms.TextBox();
            this.txtBedCapacity = new System.Windows.Forms.TextBox();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(129, 40);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(154, 20);
            this.txtRoomName.TabIndex = 1;
            // 
            // txtBuildingId
            // 
            this.txtBuildingId.Location = new System.Drawing.Point(129, 70);
            this.txtBuildingId.Name = "txtBuildingId";
            this.txtBuildingId.ReadOnly = true;
            this.txtBuildingId.Size = new System.Drawing.Size(30, 20);
            this.txtBuildingId.TabIndex = 3;
            this.txtBuildingId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuildingId.TextChanged += new System.EventHandler(this.TxtBuildingId_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(55, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(163, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(271, 284);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.Location = new System.Drawing.Point(204, 214);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(142, 20);
            this.txtUpdatedOn.TabIndex = 15;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.Location = new System.Drawing.Point(129, 214);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 14;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Location = new System.Drawing.Point(204, 188);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(142, 20);
            this.txtCreatedOn.TabIndex = 13;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(129, 188);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 12;
            this.txtCreatedBy.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Room Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Created by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Building";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(129, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Record Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Country";
            // 
            // txtCountryId
            // 
            this.txtCountryId.Location = new System.Drawing.Point(129, 97);
            this.txtCountryId.Name = "txtCountryId";
            this.txtCountryId.ReadOnly = true;
            this.txtCountryId.Size = new System.Drawing.Size(30, 20);
            this.txtCountryId.TabIndex = 6;
            this.txtCountryId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCountryId.TextChanged += new System.EventHandler(this.TxtCountryId_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Bed Capacity";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Windows";
            // 
            // lookUpButton1
            // 
            this.lookUpButton1.AssociatedControl = "txtRoomName";
            this.lookUpButton1.Source = "Room";
            this.lookUpButton1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButton1.Location = new System.Drawing.Point(284, 39);
            this.lookUpButton1.Name = "lookUpButton1";
            //
            //("RoomName");
            //("CountryId");
            //("BedCapacity");
            this.lookUpButton1.Size = new System.Drawing.Size(22, 22);
            this.lookUpButton1.TabIndex = 2;
            this.lookUpButton1.TabStop = false;
            this.lookUpButton1.LookUpSelected += new System.EventHandler(this.LookUpButton1LookUpSelected);
            // 
            // lookupCountry
            // 
            this.lookupCountry.AssociatedControl = "txtCountryId";
            this.lookupCountry.Source = "Country";
            this.lookupCountry.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookupCountry.Location = new System.Drawing.Point(284, 96);
            this.lookupCountry.Name = "lookupCountry";
            //
            //("CountryCode");
            //("CountryEnglish");
            //("CountryArabic");
            //("Id");
            this.lookupCountry.Size = new System.Drawing.Size(22, 22);
            this.lookupCountry.TabIndex = 7;
            this.lookupCountry.TabStop = false;
            // 
            // lookupBuilding
            // 
            this.lookupBuilding.AssociatedControl = "txtBuildingId";
            this.lookupBuilding.Source = "Building";
            this.lookupBuilding.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookupBuilding.Location = new System.Drawing.Point(284, 69);
            this.lookupBuilding.Name = "lookupBuilding";
            //
            //("BuildingName");
            //("Id");
            this.lookupBuilding.Size = new System.Drawing.Size(22, 22);
            this.lookupBuilding.TabIndex = 4;
            this.lookupBuilding.TabStop = false;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(129, 245);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 16;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Read Only";
            // 
            // txtNumberOfWindows
            // 
            this.txtNumberOfWindows.Location = new System.Drawing.Point(129, 151);
            this.txtNumberOfWindows.MaxLength = 3;
            this.txtNumberOfWindows.Name = "txtNumberOfWindows";
            this.txtNumberOfWindows.Size = new System.Drawing.Size(30, 20);
            this.txtNumberOfWindows.TabIndex = 11;
            this.txtNumberOfWindows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBedCapacity
            // 
            this.txtBedCapacity.Location = new System.Drawing.Point(129, 125);
            this.txtBedCapacity.MaxLength = 3;
            this.txtBedCapacity.Name = "txtBedCapacity";
            this.txtBedCapacity.Size = new System.Drawing.Size(30, 20);
            this.txtBedCapacity.TabIndex = 10;
            this.txtBedCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Enabled = false;
            this.txtCountryCode.Location = new System.Drawing.Point(162, 97);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.ReadOnly = true;
            this.txtCountryCode.Size = new System.Drawing.Size(121, 20);
            this.txtCountryCode.TabIndex = 8;
            this.txtCountryCode.TabStop = false;
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Enabled = false;
            this.txtBuildingName.Location = new System.Drawing.Point(162, 70);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.ReadOnly = true;
            this.txtBuildingName.Size = new System.Drawing.Size(121, 20);
            this.txtBuildingName.TabIndex = 5;
            this.txtBuildingName.TabStop = false;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberOfWindows);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtBedCapacity);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lookUpButton1);
            this.Controls.Add(this.txtBuildingId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.txtCountryId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lookupCountry);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lookupBuilding);
            this.Name = "RoomForm";
            this.Size = new System.Drawing.Size(382, 340);
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRoomName;
        private Common.LookUpButton lookupBuilding;
        private System.Windows.Forms.TextBox txtBuildingId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtUpdatedOn;
        private System.Windows.Forms.TextBox txtUpdatedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreatedOn;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCountryId;
        private Common.LookUpButton lookupCountry;
        private System.Windows.Forms.Label label7;
        private Common.LookUpButton lookUpButton1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberOfWindows;
        private System.Windows.Forms.TextBox txtBedCapacity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.CheckBox chkReadOnly;
    }
}