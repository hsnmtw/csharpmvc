﻿namespace ViewWinform.Customers.Nationalities {
    partial class NationalityForm {
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
            this.Nationality_Arabic_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nationality_Desc_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Created_By_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Updated_By_TextBox = new System.Windows.Forms.TextBox();
            this.Created_On_TextBox = new System.Windows.Forms.TextBox();
            this.Updated_On_TextBox = new System.Windows.Forms.TextBox();
            this.Nationality_Code_LookupButton = new ViewWinform.Common.LookUpButton();
            this.Nationality_Code_TextBox = new System.Windows.Forms.TextBox();
            this.lblMetaData_Nationality_Code = new System.Windows.Forms.Label();
            this.lblMetaData_Nationality_Desc = new System.Windows.Forms.Label();
            this.lblMetaData_Nationality_Arabic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nationality_Arabic_TextBox
            // 
            this.Nationality_Arabic_TextBox.BackColor = System.Drawing.Color.White;
            this.Nationality_Arabic_TextBox.Location = new System.Drawing.Point(141, 91);
            this.Nationality_Arabic_TextBox.Name = "Nationality_Arabic_TextBox";
            this.Nationality_Arabic_TextBox.Size = new System.Drawing.Size(204, 20);
            this.Nationality_Arabic_TextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nationality Arabic";
            // 
            // Nationality_Desc_TextBox
            // 
            this.Nationality_Desc_TextBox.BackColor = System.Drawing.Color.White;
            this.Nationality_Desc_TextBox.Location = new System.Drawing.Point(141, 65);
            this.Nationality_Desc_TextBox.Name = "Nationality_Desc_TextBox";
            this.Nationality_Desc_TextBox.Size = new System.Drawing.Size(204, 20);
            this.Nationality_Desc_TextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nationality English";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Code";
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Location = new System.Drawing.Point(141, 12);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.ReadOnly = true;
            this.Id_TextBox.Size = new System.Drawing.Size(60, 20);
            this.Id_TextBox.TabIndex = 0;
            this.Id_TextBox.TabStop = false;
            this.Id_TextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(161, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(53, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Created by";
            // 
            // Created_By_TextBox
            // 
            this.Created_By_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Created_By_TextBox.Location = new System.Drawing.Point(140, 117);
            this.Created_By_TextBox.Name = "Created_By_TextBox";
            this.Created_By_TextBox.ReadOnly = true;
            this.Created_By_TextBox.Size = new System.Drawing.Size(61, 20);
            this.Created_By_TextBox.TabIndex = 5;
            this.Created_By_TextBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Updated by";
            // 
            // Updated_By_TextBox
            // 
            this.Updated_By_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Updated_By_TextBox.Location = new System.Drawing.Point(140, 143);
            this.Updated_By_TextBox.Name = "Updated_By_TextBox";
            this.Updated_By_TextBox.ReadOnly = true;
            this.Updated_By_TextBox.Size = new System.Drawing.Size(61, 20);
            this.Updated_By_TextBox.TabIndex = 7;
            this.Updated_By_TextBox.TabStop = false;
            // 
            // Created_On_TextBox
            // 
            this.Created_On_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Created_On_TextBox.Location = new System.Drawing.Point(207, 117);
            this.Created_On_TextBox.Name = "Created_On_TextBox";
            this.Created_On_TextBox.ReadOnly = true;
            this.Created_On_TextBox.Size = new System.Drawing.Size(137, 20);
            this.Created_On_TextBox.TabIndex = 6;
            this.Created_On_TextBox.TabStop = false;
            // 
            // Updated_On_TextBox
            // 
            this.Updated_On_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Updated_On_TextBox.Location = new System.Drawing.Point(207, 143);
            this.Updated_On_TextBox.Name = "Updated_On_TextBox";
            this.Updated_On_TextBox.ReadOnly = true;
            this.Updated_On_TextBox.Size = new System.Drawing.Size(137, 20);
            this.Updated_On_TextBox.TabIndex = 8;
            this.Updated_On_TextBox.TabStop = false;
            // 
            // Nationality_Code_LookupButton
            // 
            this.Nationality_Code_LookupButton.AssociatedControl = "Nationality_Code_TextBox";
            this.Nationality_Code_LookupButton.Controller = ControllerLibrary.Common.ControllersEnum.Nationality;
            this.Nationality_Code_LookupButton.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Nationality_Code_LookupButton.Location = new System.Drawing.Point(213, 37);
            this.Nationality_Code_LookupButton.Name = "Nationality_Code_LookupButton";
            this.Nationality_Code_LookupButton.ShowFieldsInLookUp.Add("Nationality_Code");
            this.Nationality_Code_LookupButton.ShowFieldsInLookUp.Add("Nationality_Desc");
            this.Nationality_Code_LookupButton.Size = new System.Drawing.Size(22, 22);
            this.Nationality_Code_LookupButton.TabIndex = 2;
            // 
            // Nationality_Code_TextBox
            // 
            this.Nationality_Code_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Nationality_Code_TextBox.Location = new System.Drawing.Point(141, 38);
            this.Nationality_Code_TextBox.Name = "Nationality_Code_TextBox";
            this.Nationality_Code_TextBox.Size = new System.Drawing.Size(72, 20);
            this.Nationality_Code_TextBox.TabIndex = 1;
            // 
            // lblMetaData_Nationality_Code
            // 
            this.lblMetaData_Nationality_Code.AutoSize = true;
            this.lblMetaData_Nationality_Code.ForeColor = System.Drawing.Color.Red;
            this.lblMetaData_Nationality_Code.Location = new System.Drawing.Point(127, 41);
            this.lblMetaData_Nationality_Code.Name = "lblMetaData_Nationality_Code";
            this.lblMetaData_Nationality_Code.Size = new System.Drawing.Size(12, 13);
            this.lblMetaData_Nationality_Code.TabIndex = 16;
            this.lblMetaData_Nationality_Code.Text = "?";
            // 
            // lblMetaData_Nationality_Desc
            // 
            this.lblMetaData_Nationality_Desc.AutoSize = true;
            this.lblMetaData_Nationality_Desc.ForeColor = System.Drawing.Color.Red;
            this.lblMetaData_Nationality_Desc.Location = new System.Drawing.Point(127, 69);
            this.lblMetaData_Nationality_Desc.Name = "lblMetaData_Nationality_Desc";
            this.lblMetaData_Nationality_Desc.Size = new System.Drawing.Size(12, 13);
            this.lblMetaData_Nationality_Desc.TabIndex = 16;
            this.lblMetaData_Nationality_Desc.Text = "?";
            // 
            // lblMetaData_Nationality_Arabic
            // 
            this.lblMetaData_Nationality_Arabic.AutoSize = true;
            this.lblMetaData_Nationality_Arabic.ForeColor = System.Drawing.Color.Red;
            this.lblMetaData_Nationality_Arabic.Location = new System.Drawing.Point(128, 94);
            this.lblMetaData_Nationality_Arabic.Name = "lblMetaData_Nationality_Arabic";
            this.lblMetaData_Nationality_Arabic.Size = new System.Drawing.Size(12, 13);
            this.lblMetaData_Nationality_Arabic.TabIndex = 16;
            this.lblMetaData_Nationality_Arabic.Text = "?";
            // 
            // NationalityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 230);
            this.Controls.Add(this.lblMetaData_Nationality_Arabic);
            this.Controls.Add(this.lblMetaData_Nationality_Desc);
            this.Controls.Add(this.lblMetaData_Nationality_Code);
            this.Controls.Add(this.Nationality_Code_LookupButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Updated_On_TextBox);
            this.Controls.Add(this.Updated_By_TextBox);
            this.Controls.Add(this.Nationality_Arabic_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Created_On_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Created_By_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nationality_Code_TextBox);
            this.Controls.Add(this.Nationality_Desc_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "NationalityForm";
            this.Text = "Nationality";
            this.Load += new System.EventHandler(this.NationalityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nationality_Arabic_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nationality_Desc_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Created_By_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Updated_By_TextBox;
        private System.Windows.Forms.TextBox Created_On_TextBox;
        private System.Windows.Forms.TextBox Updated_On_TextBox;
        private Common.LookUpButton lookUpField1;
        private Common.LookUpButton Nationality_Code_LookupButton;
        private System.Windows.Forms.TextBox Nationality_Code_TextBox;
        private System.Windows.Forms.Label lblMetaData_Nationality_Code;
        private System.Windows.Forms.Label lblMetaData_Nationality_Desc;
        private System.Windows.Forms.Label lblMetaData_Nationality_Arabic;
    }
}