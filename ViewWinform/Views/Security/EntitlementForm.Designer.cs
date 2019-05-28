namespace MVCWinform.Security {
    partial class EntitlementForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntitlementForm));
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
            this.txtEntitlementName = new System.Windows.Forms.TextBox();
            this.EntitlementNameLookup = new MVCWinform.Common.LookUpButton();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEntitlementGroupName = new System.Windows.Forms.TextBox();
            this.EntitlementGroupNameLookup = new MVCWinform.Common.LookUpButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lookUpEntityName = new MVCWinform.Common.LookUpButton();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.Name = "btnNew";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.txtUpdatedOn, "txtUpdatedOn");
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.txtUpdatedBy, "txtUpdatedBy");
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.txtCreatedOn, "txtCreatedOn");
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.txtCreatedBy, "txtCreatedBy");
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtEntitlementName
            // 
            this.txtEntitlementName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.txtEntitlementName, "txtEntitlementName");
            this.txtEntitlementName.Name = "txtEntitlementName";
            // 
            // EntitlementNameLookup
            // 
            this.EntitlementNameLookup.AssociatedControl = "txtEntitlementName";
            this.EntitlementNameLookup.AssociatedControlDescription = null;
            this.EntitlementNameLookup.Controller = "Entitlement";
            resources.ApplyResources(this.EntitlementNameLookup, "EntitlementNameLookup");
            this.EntitlementNameLookup.Name = "EntitlementNameLookup";
            this.EntitlementNameLookup.SelectedValueIndex = 0;
            this.EntitlementNameLookup.ShowFieldsInLookUp.Add(resources.GetString("EntitlementNameLookup.ShowFieldsInLookUp"));
            this.EntitlementNameLookup.ShowFieldsInLookUp.Add(resources.GetString("EntitlementNameLookup.ShowFieldsInLookUp1"));
            this.EntitlementNameLookup.TabStop = false;
            this.EntitlementNameLookup.LookUpSelected += new System.EventHandler(this.EntitlementNameLookupLookUpSelected);
            // 
            // chkReadOnly
            // 
            resources.ApplyResources(this.chkReadOnly, "chkReadOnly");
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtEntitlementGroupName
            // 
            this.txtEntitlementGroupName.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtEntitlementGroupName, "txtEntitlementGroupName");
            this.txtEntitlementGroupName.Name = "txtEntitlementGroupName";
            this.txtEntitlementGroupName.ReadOnly = true;
            // 
            // EntitlementGroupNameLookup
            // 
            this.EntitlementGroupNameLookup.AssociatedControl = "txtEntitlementGroupName";
            this.EntitlementGroupNameLookup.AssociatedControlDescription = null;
            this.EntitlementGroupNameLookup.Controller = "EntitlementGroup";
            resources.ApplyResources(this.EntitlementGroupNameLookup, "EntitlementGroupNameLookup");
            this.EntitlementGroupNameLookup.Name = "EntitlementGroupNameLookup";
            this.EntitlementGroupNameLookup.SelectedValueIndex = 0;
            this.EntitlementGroupNameLookup.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lookUpEntityName
            // 
            this.lookUpEntityName.AssociatedControl = "txtEntityName";
            this.lookUpEntityName.AssociatedControlDescription = null;
            this.lookUpEntityName.Controller = "Entity";
            resources.ApplyResources(this.lookUpEntityName, "lookUpEntityName");
            this.lookUpEntityName.Name = "lookUpEntityName";
            this.lookUpEntityName.SelectedValueIndex = 0;
            this.lookUpEntityName.TabStop = false;
            // 
            // txtEntityName
            // 
            this.txtEntityName.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtEntityName, "txtEntityName");
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.ReadOnly = true;
            // 
            // EntitlementForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEntityName);
            this.Controls.Add(this.txtEntitlementGroupName);
            this.Controls.Add(this.lookUpEntityName);
            this.Controls.Add(this.EntitlementGroupNameLookup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEntitlementName);
            this.Controls.Add(this.EntitlementNameLookup);
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
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "EntitlementForm";
            this.Load += new System.EventHandler(this.EntitlementFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.LookUpButton EntitlementNameLookup;
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
        private System.Windows.Forms.TextBox txtEntitlementName;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEntitlementGroupName;
        private Common.LookUpButton EntitlementGroupNameLookup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Common.LookUpButton lookUpEntityName;
        private System.Windows.Forms.TextBox txtEntityName;
    }
}