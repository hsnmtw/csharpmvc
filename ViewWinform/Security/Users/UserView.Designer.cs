namespace ViewWinform.Security.Users {
    partial class UserView {
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
            ModelLibrary.Security.UserModel userModel1 = new ModelLibrary.Security.UserModel();
            this.usersFormView1 = new ViewWinform.Security.Users.UsersFormView();
            this.SuspendLayout();
            // 
            // usersFormView1
            // 
            this.usersFormView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersFormView1.Location = new System.Drawing.Point(5, 71);
            userModel1.Created_By = null;
            userModel1.Created_On = new System.DateTime(((long)(0)));
            userModel1.Email = "";
            userModel1.Failed_Login_Attempts = 0;
            userModel1.Full_Name = "";
            userModel1.Id = "";
            userModel1.Is_Active = false;
            userModel1.Last_Change_Password = new System.DateTime(((long)(0)));
            userModel1.Last_Login_Date = new System.DateTime(((long)(0)));
            userModel1.Profile_Name = "Viewer";
            userModel1.Updated_By = null;
            userModel1.Updated_On = new System.DateTime(((long)(0)));
            userModel1.User_Name = "";
            userModel1.User_Password = "{ENC}H4sIAAAAAAAEAAFgAJ//Osw6X/VPX06hMvGZxXxidNdMXfSYh4evz4ifBlxKHGedNVMwNTQ67u4C" +
    "2YEqwamBwjOuvQ/biwdQArb8IGs/Zdmod/VLTAEuCIGA4bA3NyT4wGf/c8cZmuJYq8QzsnF47MGrL2AA" +
    "AAA=";
            this.usersFormView1.model = userModel1;
            this.usersFormView1.Name = "usersFormView1";
            this.usersFormView1.Size = new System.Drawing.Size(560, 165);
            this.usersFormView1.TabIndex = 2;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 266);
            this.Controls.Add(this.usersFormView1);
            this.Name = "UserView";
            this.Text = "UserView";
            this.OnRecordPositionChanged += new ViewWinform.Common.CommonView.RecordPositionHandler(this.UserView_OnRecordPositionChanged);
            this.OnSaveInvoked += new ViewWinform.Common.CommonView.RecordSpecificOperationHandler(this.UserView_OnSaveInvoked);
            this.OnNewInvoked += new ViewWinform.Common.CommonView.RecordSpecificOperationHandler(this.UserView_OnNewInvoked);
            this.OnDeleteInvoked += new ViewWinform.Common.CommonView.RecordSpecificOperationHandler(this.UserView_OnDeleteInvoked);
            this.OnTableInvoked += new ViewWinform.Common.CommonView.RecordSpecificOperationHandler(this.UserView_OnTableInvoked);
            this.Controls.SetChildIndex(this.usersFormView1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UsersFormView usersFormView1;
    }
}