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
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLookup = new ViewWinform.Common.LookUpButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(81, 39);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.Size = new System.Drawing.Size(222, 20);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(81, 13);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.UserNameTextBox.TabIndex = 0;
            this.UserNameTextBox.Text = "Admin";
            // 
            // UserNameLookup
            // 
            this.UserNameLookup.AssociatedControl = "UserNameTextBox";
            this.UserNameLookup.Controller = "User";
            this.UserNameLookup.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.UserNameLookup.Location = new System.Drawing.Point(282, 12);
            this.UserNameLookup.Name = "UserNameLookup";
            this.UserNameLookup.ShowFieldsInLookUp.Add("UserName");
            this.UserNameLookup.Size = new System.Drawing.Size(22, 22);
            this.UserNameLookup.TabIndex = 1;
            this.UserNameLookup.TabStop = false;
            // 
            // UsersLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 119);
            this.Controls.Add(this.UserNameLookup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersLoginView";
            this.Load += new System.EventHandler(this.UsersLoginView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Common.LookUpButton UserNameLookup;
        private System.Windows.Forms.TextBox UserNameTextBox;
    }
}
