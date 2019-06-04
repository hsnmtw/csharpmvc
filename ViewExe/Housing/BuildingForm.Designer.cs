namespace MVCHIS.Housing.Buildings {
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
        private void InitializeComponent(){
            this.txtCompoundId = new System.Windows.Forms.TextBox();
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
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.lookUpButton1 = new MVCHIS.Common.LookUpButton();
            this.lookupComound = new MVCHIS.Common.LookUpButton();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lookUpButtonBuildingType = new MVCHIS.Common.LookUpButton();
            this.txtBuildingTypeId = new System.Windows.Forms.TextBox();
            this.txtCompoundName = new System.Windows.Forms.TextBox();
            this.txtBuildingTypeCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCompoundId
            // 
            this.txtCompoundId.Location = new System.Drawing.Point(149, 105);
            this.txtCompoundId.Name = "txtCompoundId";
            this.txtCompoundId.ReadOnly = true;
            this.txtCompoundId.Size = new System.Drawing.Size(33, 20);
            this.txtCompoundId.TabIndex = 5;
            this.txtCompoundId.TextChanged += new System.EventHandler(this.TxtCompoundId_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(69, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(177, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(285, 240);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.Location = new System.Drawing.Point(223, 173);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 10;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.Location = new System.Drawing.Point(149, 173);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 9;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Location = new System.Drawing.Point(223, 147);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 8;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(149, 147);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 7;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Created by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Compound";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(149, 13);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Record Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Building Name";
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(149, 46);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(154, 20);
            this.txtBuildingName.TabIndex = 1;
            // 
            // lookUpButton1
            // 
            this.lookUpButton1.AssociatedControl = "txtBuildingName";
            this.lookUpButton1.Controller = "Building";
            this.lookUpButton1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButton1.Location = new System.Drawing.Point(304, 45);
            this.lookUpButton1.Name = "lookUpButton1";
            this.lookUpButton1.SelectedValueIndex = 0;
            this.lookUpButton1.ShowFieldsInLookUp.Add("BuildingName");
            this.lookUpButton1.Size = new System.Drawing.Size(22, 22);
            this.lookUpButton1.TabIndex = 2;
            this.lookUpButton1.TabStop = false;
            this.lookUpButton1.LookUpSelected += new System.EventHandler(this.LookUpButton1LookUpSelected);
            // 
            // lookupComound
            // 
            this.lookupComound.AssociatedControl = "txtCompoundId";
            this.lookupComound.Controller = "Compound";
            this.lookupComound.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookupComound.Location = new System.Drawing.Point(304, 104);
            this.lookupComound.Name = "lookupComound";
            this.lookupComound.SelectedValueIndex = 1;
            this.lookupComound.ShowFieldsInLookUp.Add("CompoundName");
            this.lookupComound.ShowFieldsInLookUp.Add("Id");
            this.lookupComound.Size = new System.Drawing.Size(22, 22);
            this.lookupComound.TabIndex = 6;
            this.lookupComound.TabStop = false;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(149, 204);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 46;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Read Only";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Building Type";
            // 
            // lookUpButtonBuildingType
            // 
            this.lookUpButtonBuildingType.AssociatedControl = "txtBuildingTypeId";
            this.lookUpButtonBuildingType.Controller = "BuildingType";
            this.lookUpButtonBuildingType.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpButtonBuildingType.Location = new System.Drawing.Point(304, 76);
            this.lookUpButtonBuildingType.Name = "lookUpButtonBuildingType";
            this.lookUpButtonBuildingType.SelectedValueIndex = 1;
            this.lookUpButtonBuildingType.ShowFieldsInLookUp.Add("BuildingTypeCode");
            this.lookUpButtonBuildingType.ShowFieldsInLookUp.Add("Id");
            this.lookUpButtonBuildingType.Size = new System.Drawing.Size(22, 22);
            this.lookUpButtonBuildingType.TabIndex = 4;
            this.lookUpButtonBuildingType.TabStop = false;
            // 
            // txtBuildingTypeId
            // 
            this.txtBuildingTypeId.Location = new System.Drawing.Point(149, 77);
            this.txtBuildingTypeId.Name = "txtBuildingTypeId";
            this.txtBuildingTypeId.ReadOnly = true;
            this.txtBuildingTypeId.Size = new System.Drawing.Size(33, 20);
            this.txtBuildingTypeId.TabIndex = 3;
            this.txtBuildingTypeId.TextChanged += new System.EventHandler(this.TxtBuildingTypeId_TextChanged);
            // 
            // txtCompoundName
            // 
            this.txtCompoundName.Enabled = false;
            this.txtCompoundName.Location = new System.Drawing.Point(185, 105);
            this.txtCompoundName.Name = "txtCompoundName";
            this.txtCompoundName.ReadOnly = true;
            this.txtCompoundName.Size = new System.Drawing.Size(118, 20);
            this.txtCompoundName.TabIndex = 5;
            // 
            // txtBuildingTypeCode
            // 
            this.txtBuildingTypeCode.Enabled = false;
            this.txtBuildingTypeCode.Location = new System.Drawing.Point(185, 77);
            this.txtBuildingTypeCode.Name = "txtBuildingTypeCode";
            this.txtBuildingTypeCode.ReadOnly = true;
            this.txtBuildingTypeCode.Size = new System.Drawing.Size(118, 20);
            this.txtBuildingTypeCode.TabIndex = 3;
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.lookupComound);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lookUpButtonBuildingType);
            this.Controls.Add(this.lookUpButton1);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.txtBuildingTypeCode);
            this.Controls.Add(this.txtCompoundName);
            this.Controls.Add(this.txtBuildingTypeId);
            this.Controls.Add(this.txtCompoundId);
            this.Name = "BuildingForm";
            this.Size = new System.Drawing.Size(393, 286);
            this.Load += new System.EventHandler(this.BuildingFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.LookUpButton lookupComound;
        private System.Windows.Forms.TextBox txtCompoundId;
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
        private System.Windows.Forms.TextBox txtBuildingName;
        private Common.LookUpButton lookUpButton1;
        private System.Windows.Forms.Label label4;
        private Common.LookUpButton lookUpButtonBuildingType;
        private System.Windows.Forms.TextBox txtBuildingTypeId;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCompoundName;
        private System.Windows.Forms.TextBox txtBuildingTypeCode;
    }
}