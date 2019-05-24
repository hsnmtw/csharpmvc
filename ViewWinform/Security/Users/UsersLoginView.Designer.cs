namespace ViewWinform.Security.Users
{
    partial class UsersLoginView
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserNameLookup = new ViewWinform.Common.LookUpButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rdoArabic = new System.Windows.Forms.RadioButton();
            this.rdoEnglish = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(250, 254);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.Button1Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(149, 216);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(222, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(149, 190);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(199, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(157, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Copyrights (c) 2004 - 2019";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(157, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "by Hussain Almutawa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(157, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Housing Information System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = global::ViewWinform.Properties.Resources.icons8_web_design_64;
            this.pictureBox1.Location = new System.Drawing.Point(75, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 63);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserNameLookup
            // 
            this.UserNameLookup.AssociatedControl = "txtUserName";
            this.UserNameLookup.AssociatedControlDescription = null;
            this.UserNameLookup.Controller = "User";
            this.UserNameLookup.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.UserNameLookup.Location = new System.Drawing.Point(350, 189);
            this.UserNameLookup.Name = "UserNameLookup";
            this.UserNameLookup.ShowFieldsInLookUp.Add("UserName");
            this.UserNameLookup.Size = new System.Drawing.Size(22, 22);
            this.UserNameLookup.TabIndex = 1;
            this.UserNameLookup.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(405, 167);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // rdoArabic
            // 
            this.rdoArabic.AutoSize = true;
            this.rdoArabic.Location = new System.Drawing.Point(19, 267);
            this.rdoArabic.Name = "rdoArabic";
            this.rdoArabic.Size = new System.Drawing.Size(54, 17);
            this.rdoArabic.TabIndex = 6;
            this.rdoArabic.Text = "عربي ";
            this.rdoArabic.UseVisualStyleBackColor = true;
            this.rdoArabic.CheckedChanged += new System.EventHandler(this.RdoArabic_CheckedChanged);
            // 
            // rdoEnglish
            // 
            this.rdoEnglish.AutoSize = true;
            this.rdoEnglish.Checked = true;
            this.rdoEnglish.Location = new System.Drawing.Point(90, 267);
            this.rdoEnglish.Name = "rdoEnglish";
            this.rdoEnglish.Size = new System.Drawing.Size(61, 17);
            this.rdoEnglish.TabIndex = 6;
            this.rdoEnglish.TabStop = true;
            this.rdoEnglish.Text = "English ";
            this.rdoEnglish.UseVisualStyleBackColor = true;
            this.rdoEnglish.CheckedChanged += new System.EventHandler(this.RdoEnglish_CheckedChanged);
            // 
            // UsersLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 310);
            this.Controls.Add(this.rdoEnglish);
            this.Controls.Add(this.rdoArabic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.UserNameLookup);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersLoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.UsersLoginView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Common.LookUpButton UserNameLookup;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rdoArabic;
        private System.Windows.Forms.RadioButton rdoEnglish;
    }
}
