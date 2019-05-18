namespace ViewWinform.Housing.Rooms {
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.txtNationalityCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBedCapacity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lookUpButton1 = new ViewWinform.Common.LookUpButton();
            this.lookupNationality = new ViewWinform.Common.LookUpButton();
            this.lookupBuilding = new ViewWinform.Common.LookUpButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberOfWindows = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRoomName
            // 
            this.txtRoomName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRoomName.Location = new System.Drawing.Point(136, 53);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(154, 20);
            this.txtRoomName.TabIndex = 1;
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(136, 81);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.ReadOnly = true;
            this.txtBuildingName.Size = new System.Drawing.Size(154, 20);
            this.txtBuildingName.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(62, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedOn.Location = new System.Drawing.Point(216, 222);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 12;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedBy.Location = new System.Drawing.Point(141, 222);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 11;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedOn.Location = new System.Drawing.Point(216, 196);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 10;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedBy.Location = new System.Drawing.Point(141, 196);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 9;
            this.txtCreatedBy.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Room Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Created by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Building Name";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(136, 20);
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
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Nationality";
            // 
            // txtNationalityCode
            // 
            this.txtNationalityCode.Location = new System.Drawing.Point(136, 107);
            this.txtNationalityCode.Name = "txtNationalityCode";
            this.txtNationalityCode.ReadOnly = true;
            this.txtNationalityCode.Size = new System.Drawing.Size(154, 20);
            this.txtNationalityCode.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Bed Capacity";
            // 
            // txtBedCapacity
            // 
            this.txtBedCapacity.BackColor = System.Drawing.SystemColors.Window;
            this.txtBedCapacity.Location = new System.Drawing.Point(136, 134);
            this.txtBedCapacity.Name = "txtBedCapacity";
            this.txtBedCapacity.Size = new System.Drawing.Size(154, 20);
            this.txtBedCapacity.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            // lookUpButton1
            // 
            this.lookUpButton1.AssociatedControl = "txtRoomName";
            this.lookUpButton1.Controller = ControllerLibrary.Common.ControllersEnum.Room;
            this.lookUpButton1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButton1.Location = new System.Drawing.Point(291, 52);
            this.lookUpButton1.Name = "lookUpButton1";
            this.lookUpButton1.ShowFieldsInLookUp.Add("Room_Name");
            this.lookUpButton1.ShowFieldsInLookUp.Add("Building_Name");
            this.lookUpButton1.ShowFieldsInLookUp.Add("Bed_Capacity");
            this.lookUpButton1.ShowFieldsInLookUp.Add("Nationality_Code");
            this.lookUpButton1.ShowFieldsInLookUp.Add("Id");
            this.lookUpButton1.Size = new System.Drawing.Size(22, 22);
            this.lookUpButton1.TabIndex = 2;
            this.lookUpButton1.OnLookUpSelected += new System.EventHandler(this.LookUpButton1_OnLookUpSelected);
            // 
            // lookupNationality
            // 
            this.lookupNationality.AssociatedControl = "txtNationalityCode";
            this.lookupNationality.Controller = ControllerLibrary.Common.ControllersEnum.Nationality;
            this.lookupNationality.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookupNationality.Location = new System.Drawing.Point(291, 106);
            this.lookupNationality.Name = "lookupNationality";
            this.lookupNationality.ShowFieldsInLookUp.Add("Nationality_Code");
            this.lookupNationality.ShowFieldsInLookUp.Add("Nationality_Desc");
            this.lookupNationality.ShowFieldsInLookUp.Add("Nationality_Arabic");
            this.lookupNationality.Size = new System.Drawing.Size(22, 22);
            this.lookupNationality.TabIndex = 6;
            // 
            // lookupBuilding
            // 
            this.lookupBuilding.AssociatedControl = "txtBuildingName";
            this.lookupBuilding.Controller = ControllerLibrary.Common.ControllersEnum.Building;
            this.lookupBuilding.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookupBuilding.Location = new System.Drawing.Point(291, 80);
            this.lookupBuilding.Name = "lookupBuilding";
            this.lookupBuilding.ShowFieldsInLookUp.Add("Building_Name");
            this.lookupBuilding.ShowFieldsInLookUp.Add("Compound_Name");
            this.lookupBuilding.Size = new System.Drawing.Size(22, 22);
            this.lookupBuilding.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Windows";
            // 
            // txtNumberOfWindows
            // 
            this.txtNumberOfWindows.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumberOfWindows.Location = new System.Drawing.Point(136, 163);
            this.txtNumberOfWindows.Name = "txtNumberOfWindows";
            this.txtNumberOfWindows.Size = new System.Drawing.Size(154, 20);
            this.txtNumberOfWindows.TabIndex = 8;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lookUpButton1);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.lookupNationality);
            this.Controls.Add(this.lookupBuilding);
            this.Controls.Add(this.txtNumberOfWindows);
            this.Controls.Add(this.txtBedCapacity);
            this.Controls.Add(this.txtNationalityCode);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRoomName;
        private Common.LookUpButton lookupBuilding;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.TextBox txtNationalityCode;
        private Common.LookUpButton lookupNationality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBedCapacity;
        private Common.LookUpButton lookUpButton1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberOfWindows;
    }
}