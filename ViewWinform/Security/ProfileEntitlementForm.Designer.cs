﻿namespace ViewWinform.Security {
    partial class ProfileEntitlementForm {
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
            this.btnSave = new System.Windows.Forms.Button();
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
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAllowDelete = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAllowUpdate = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkAllowRead = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkAllowCreate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(190, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedOn.Enabled = false;
            this.txtUpdatedOn.Location = new System.Drawing.Point(236, 236);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtUpdatedOn.TabIndex = 10;
            this.txtUpdatedOn.TabStop = false;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedBy.Enabled = false;
            this.txtUpdatedBy.Location = new System.Drawing.Point(161, 236);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtUpdatedBy.TabIndex = 9;
            this.txtUpdatedBy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Updated by";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedOn.Enabled = false;
            this.txtCreatedOn.Location = new System.Drawing.Point(236, 205);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(137, 20);
            this.txtCreatedOn.TabIndex = 8;
            this.txtCreatedOn.TabStop = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Location = new System.Drawing.Point(161, 205);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(69, 20);
            this.txtCreatedBy.TabIndex = 7;
            this.txtCreatedBy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Created by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Entitlement Name";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(161, 12);
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
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Record Id";
            // 
            // txtEntitlementName
            // 
            this.txtEntitlementName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEntitlementName.Enabled = false;
            this.txtEntitlementName.Location = new System.Drawing.Point(161, 74);
            this.txtEntitlementName.Name = "txtEntitlementName";
            this.txtEntitlementName.ReadOnly = true;
            this.txtEntitlementName.Size = new System.Drawing.Size(212, 20);
            this.txtEntitlementName.TabIndex = 2;
            this.txtEntitlementName.TabStop = false;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Enabled = false;
            this.chkReadOnly.Location = new System.Drawing.Point(161, 267);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(15, 14);
            this.chkReadOnly.TabIndex = 11;
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Read Only";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Allow Delete";
            // 
            // chkAllowDelete
            // 
            this.chkAllowDelete.AutoSize = true;
            this.chkAllowDelete.Location = new System.Drawing.Point(161, 180);
            this.chkAllowDelete.Name = "chkAllowDelete";
            this.chkAllowDelete.Size = new System.Drawing.Size(15, 14);
            this.chkAllowDelete.TabIndex = 6;
            this.chkAllowDelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Allow Update";
            // 
            // chkAllowUpdate
            // 
            this.chkAllowUpdate.AutoSize = true;
            this.chkAllowUpdate.Location = new System.Drawing.Point(161, 155);
            this.chkAllowUpdate.Name = "chkAllowUpdate";
            this.chkAllowUpdate.Size = new System.Drawing.Size(15, 14);
            this.chkAllowUpdate.TabIndex = 5;
            this.chkAllowUpdate.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Allow Read";
            // 
            // chkAllowRead
            // 
            this.chkAllowRead.AutoSize = true;
            this.chkAllowRead.Location = new System.Drawing.Point(161, 130);
            this.chkAllowRead.Name = "chkAllowRead";
            this.chkAllowRead.Size = new System.Drawing.Size(15, 14);
            this.chkAllowRead.TabIndex = 4;
            this.chkAllowRead.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Profile Name";
            // 
            // txtProfileName
            // 
            this.txtProfileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtProfileName.Enabled = false;
            this.txtProfileName.Location = new System.Drawing.Point(161, 43);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.ReadOnly = true;
            this.txtProfileName.Size = new System.Drawing.Size(212, 20);
            this.txtProfileName.TabIndex = 1;
            this.txtProfileName.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Allow Create";
            // 
            // chkAllowCreate
            // 
            this.chkAllowCreate.AutoSize = true;
            this.chkAllowCreate.Location = new System.Drawing.Point(161, 105);
            this.chkAllowCreate.Name = "chkAllowCreate";
            this.chkAllowCreate.Size = new System.Drawing.Size(15, 14);
            this.chkAllowCreate.TabIndex = 3;
            this.chkAllowCreate.UseVisualStyleBackColor = true;
            // 
            // ProfileEntitlementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 355);
            this.Controls.Add(this.chkAllowCreate);
            this.Controls.Add(this.chkAllowRead);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkAllowUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkAllowDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.txtEntitlementName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUpdatedOn);
            this.Controls.Add(this.txtUpdatedBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCreatedOn);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProfileEntitlementForm";
            this.Text = "Profile Entitlements";
            this.Load += new System.EventHandler(this.EntitlementFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAllowDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAllowUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAllowRead;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkAllowCreate;
    }
}