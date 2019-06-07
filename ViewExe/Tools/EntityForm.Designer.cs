namespace MVCHIS.Common {
    partial class EntityForm {
        /// <summaryClient
        /// Required designer variable.
        /// </summaryClient
        private System.ComponentModel.IContainer components = null;

        /// <summaryClient
        /// Clean up any resources being used.
        /// </summaryClient
        /// <param name="disposing"Clienttrue if managed resources should be disposed; otherwise, false.</paramClient
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summaryClient
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summaryClient
        private void InitializeComponent(){
            this.txtUpdatedOn = new System.Windows.Forms.TextBox();
            this.txtUpdatedBy = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCreatedOn = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.btnPLEntity = new MVCHIS.Common.PickListButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.txtEntityDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.Location = new System.Drawing.Point(213, 161);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 8;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.Location = new System.Drawing.Point(139, 161);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 7;
            this.txtUpdatedBy.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(275, 237);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Updated by";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(167, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Location = new System.Drawing.Point(213, 135);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 6;
            this.txtCreatedOn.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(59, 237);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(139, 135);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 5;
            this.txtCreatedBy.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Entity Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Entity Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Created by";
            // 
            // txtEntityName
            // 
            this.txtEntityName.Location = new System.Drawing.Point(140, 46);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(210, 20);
            this.txtEntityName.TabIndex = 2;
            // 
            // btnPLEntity
            // 
            this.btnPLEntity.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnPLEntity.Location = new System.Drawing.Point(209, 9);
            this.btnPLEntity.Name = "btnPLEntity";
            this.btnPLEntity.Size = new System.Drawing.Size(22, 22);
            this.btnPLEntity.Source = "Entity";
            this.btnPLEntity.TabIndex = 1;
            this.btnPLEntity.TabStop = false;
            this.btnPLEntity.Text = "↓";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(139, 10);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Record Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Read Only";
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(140, 195);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 9;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // txtEntityDesc
            // 
            this.txtEntityDesc.Location = new System.Drawing.Point(140, 70);
            this.txtEntityDesc.Name = "txtEntityDesc";
            this.txtEntityDesc.Size = new System.Drawing.Size(210, 20);
            this.txtEntityDesc.TabIndex = 3;
            // 
            // EntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEntityDesc);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnPLEntity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEntityName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCreatedBy);
            this.Name = "EntityForm";
            this.Size = new System.Drawing.Size(373, 283);
            this.Load += new System.EventHandler(this.EntityFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUpdatedOn;
        private System.Windows.Forms.TextBox txtUpdatedBy;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCreatedOn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEntityName;
        private PickListButton btnPLEntity;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.TextBox txtEntityDesc;
    }
}