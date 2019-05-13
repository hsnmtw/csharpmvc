namespace ViewWinform.Security.Profiles
{
    partial class ProfilesFormView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Profile_Name_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.advancedCheckedListBox1 = new ViewWinform.Utils.AdvancedCheckedListBox();
            this.SuspendLayout();
            // 
            // Profile_Name_TextBox
            // 
            this.Profile_Name_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Profile_Name_TextBox.Location = new System.Drawing.Point(96, 42);
            this.Profile_Name_TextBox.Name = "Profile_Name_TextBox";
            this.Profile_Name_TextBox.Size = new System.Drawing.Size(426, 20);
            this.Profile_Name_TextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Profile Name";
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Location = new System.Drawing.Point(96, 15);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.ReadOnly = true;
            this.Id_TextBox.Size = new System.Drawing.Size(426, 20);
            this.Id_TextBox.TabIndex = 9;
            this.Id_TextBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Entitlements";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(39, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(37, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // advancedCheckedListBox1
            // 
            this.advancedCheckedListBox1.Location = new System.Drawing.Point(96, 69);
            this.advancedCheckedListBox1.Name = "advancedCheckedListBox1";
            this.advancedCheckedListBox1.Size = new System.Drawing.Size(426, 195);
            this.advancedCheckedListBox1.TabIndex = 1;
            // 
            // ProfilesFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.advancedCheckedListBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Profile_Name_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "ProfilesFormView";
            this.Size = new System.Drawing.Size(533, 271);
            this.Load += new System.EventHandler(this.ProfilesFormView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Profile_Name_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private Utils.AdvancedCheckedListBox advancedCheckedListBox1;
    }
}
