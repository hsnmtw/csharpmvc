﻿namespace ViewWinform.Security.Profiles {
    partial class ProfileForm {
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Updated_On_TextBox = new System.Windows.Forms.TextBox();
            this.Updated_By_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Created_On_TextBox = new System.Windows.Forms.TextBox();
            this.Created_By_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Profile_Name_TextBox = new ViewWinform.Common.LookUpField();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(79, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Updated_On_TextBox
            // 
            this.Updated_On_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Updated_On_TextBox.Location = new System.Drawing.Point(233, 308);
            this.Updated_On_TextBox.Name = "Updated_On_TextBox";
            this.Updated_On_TextBox.ReadOnly = true;
            this.Updated_On_TextBox.Size = new System.Drawing.Size(137, 20);
            this.Updated_On_TextBox.TabIndex = 11;
            this.Updated_On_TextBox.TabStop = false;
            // 
            // Updated_By_TextBox
            // 
            this.Updated_By_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Updated_By_TextBox.Location = new System.Drawing.Point(158, 308);
            this.Updated_By_TextBox.Name = "Updated_By_TextBox";
            this.Updated_By_TextBox.ReadOnly = true;
            this.Updated_By_TextBox.Size = new System.Drawing.Size(69, 20);
            this.Updated_By_TextBox.TabIndex = 10;
            this.Updated_By_TextBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Updated by";
            // 
            // Created_On_TextBox
            // 
            this.Created_On_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Created_On_TextBox.Location = new System.Drawing.Point(233, 282);
            this.Created_On_TextBox.Name = "Created_On_TextBox";
            this.Created_On_TextBox.ReadOnly = true;
            this.Created_On_TextBox.Size = new System.Drawing.Size(137, 20);
            this.Created_On_TextBox.TabIndex = 9;
            this.Created_On_TextBox.TabStop = false;
            // 
            // Created_By_TextBox
            // 
            this.Created_By_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Created_By_TextBox.Location = new System.Drawing.Point(158, 282);
            this.Created_By_TextBox.Name = "Created_By_TextBox";
            this.Created_By_TextBox.ReadOnly = true;
            this.Created_By_TextBox.Size = new System.Drawing.Size(69, 20);
            this.Created_By_TextBox.TabIndex = 8;
            this.Created_By_TextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Created by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Profile Name";
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Location = new System.Drawing.Point(159, 12);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.ReadOnly = true;
            this.Id_TextBox.Size = new System.Drawing.Size(68, 20);
            this.Id_TextBox.TabIndex = 0;
            this.Id_TextBox.TabStop = false;
            this.Id_TextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id";
            // 
            // Profile_Name_TextBox
            // 
            this.Profile_Name_TextBox.Controller = ViewWinform.Common.DBControllers.Profile;
            this.Profile_Name_TextBox.Location = new System.Drawing.Point(158, 38);
            this.Profile_Name_TextBox.Name = "Profile_Name_TextBox";
            this.Profile_Name_TextBox.ShowFieldsInLookUp.Add("Profile_Name");
            this.Profile_Name_TextBox.Size = new System.Drawing.Size(104, 22);
            this.Profile_Name_TextBox.TabIndex = 1;
            this.Profile_Name_TextBox.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Profile_Name_TextBox.OnLookUpSelected += new ViewWinform.Common.LookUpField.LookUpSelectedHandler(this.Profile_Code_TextBox_OnLookUpSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Entitlements";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(158, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(182, 199);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(393, 69);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(182, 199);
            this.listBox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(346, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(346, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "<<<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(346, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = ">>>";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 395);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Profile_Name_TextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Updated_On_TextBox);
            this.Controls.Add(this.Updated_By_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Created_On_TextBox);
            this.Controls.Add(this.Created_By_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "ProfileForm";
            this.Text = "Profiles";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.LookUpField Profile_Name_TextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Updated_On_TextBox;
        private System.Windows.Forms.TextBox Updated_By_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Created_On_TextBox;
        private System.Windows.Forms.TextBox Created_By_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}