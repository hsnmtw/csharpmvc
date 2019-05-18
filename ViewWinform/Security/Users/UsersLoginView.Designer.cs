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
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.User_Name_TextBox = new System.Windows.Forms.TextBox();
            this.User_Name_Lookup = new ViewWinform.Common.LookUpButton();
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
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(81, 39);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '●';
            this.Password_TextBox.Size = new System.Drawing.Size(222, 20);
            this.Password_TextBox.TabIndex = 2;
            this.Password_TextBox.Text = "123";
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
            // User_Name_TextBox
            // 
            this.User_Name_TextBox.Location = new System.Drawing.Point(81, 13);
            this.User_Name_TextBox.Name = "User_Name_TextBox";
            this.User_Name_TextBox.Size = new System.Drawing.Size(199, 20);
            this.User_Name_TextBox.TabIndex = 0;
            this.User_Name_TextBox.Text = "Admin";
            // 
            // User_Name_Lookup
            // 
            this.User_Name_Lookup.AssociatedControl = "User_Name_TextBox";
            this.User_Name_Lookup.Controller = ControllerLibrary.Common.DBControllersEnum.User;
            this.User_Name_Lookup.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.User_Name_Lookup.Location = new System.Drawing.Point(282, 12);
            this.User_Name_Lookup.Name = "User_Name_Lookup";
            this.User_Name_Lookup.ShowFieldsInLookUp.Add("User_Name");
            this.User_Name_Lookup.Size = new System.Drawing.Size(22, 22);
            this.User_Name_Lookup.TabIndex = 1;
            // 
            // UsersLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.User_Name_Lookup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.User_Name_TextBox);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsersLoginView";
            this.Size = new System.Drawing.Size(318, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Common.LookUpButton User_Name_Lookup;
        private System.Windows.Forms.TextBox User_Name_TextBox;
    }
}
