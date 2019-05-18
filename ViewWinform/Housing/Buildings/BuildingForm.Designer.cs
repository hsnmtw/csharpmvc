namespace ViewWinform.Housing.Buildings {
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.lookUpButton1 = new ViewWinform.Common.LookUpButton();
            this.lookupComound = new ViewWinform.Common.LookUpButton();
            this.SuspendLayout();
            // 
            // txtCompoundName
            // 
            this.txtCompoundName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCompoundName.Location = new System.Drawing.Point(179, 90);
            this.txtCompoundName.Name = "txtCompoundName";
            this.txtCompoundName.Size = new System.Drawing.Size(154, 20);
            this.txtCompoundName.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(99, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedOn.Location = new System.Drawing.Point(253, 160);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 8;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedBy.Location = new System.Drawing.Point(178, 160);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 7;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedOn.Location = new System.Drawing.Point(253, 134);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 6;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedBy.Location = new System.Drawing.Point(178, 134);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 5;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Created by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Comound Name";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(179, 29);
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
            this.label1.Location = new System.Drawing.Point(77, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Building Name";
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBuildingName.Location = new System.Drawing.Point(179, 62);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(154, 20);
            this.txtBuildingName.TabIndex = 1;
            // 
            // lookUpButton1
            // 
            this.lookUpButton1.AssociatedControl = null;
            this.lookUpButton1.Controller = ControllerLibrary.Common.ControllersEnum.Building;
            this.lookUpButton1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButton1.Location = new System.Drawing.Point(334, 61);
            this.lookUpButton1.Name = "lookUpButton1";
            this.lookUpButton1.ShowFieldsInLookUp.Add("Building_Name");
            this.lookUpButton1.ShowFieldsInLookUp.Add("Compound_Name");
            this.lookUpButton1.Size = new System.Drawing.Size(22, 22);
            this.lookUpButton1.TabIndex = 2;
            this.lookUpButton1.OnLookUpSelected += new System.EventHandler(this.LookUpButton1_OnLookUpSelected);
            // 
            // lookupComound
            // 
            this.lookupComound.AssociatedControl = "txtCompoundName";
            this.lookupComound.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookupComound.Location = new System.Drawing.Point(334, 89);
            this.lookupComound.Name = "lookupComound";
            this.lookupComound.ShowFieldsInLookUp.Add("Compound_Name");
            this.lookupComound.Size = new System.Drawing.Size(22, 22);
            this.lookupComound.TabIndex = 4;
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 262);
            this.Controls.Add(this.lookUpButton1);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.lookupComound);
            this.Controls.Add(this.txtCompoundName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "BuildingForm";
            this.Text = "BuildingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.LookUpButton lookupComound;
        private System.Windows.Forms.TextBox txtCompoundName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
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
    }
}