namespace ViewWinform.Security.Profiles {
    partial class ProfileView {
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
            ModelLibrary.Security.ProfileModel profileModel2 = new ModelLibrary.Security.ProfileModel();
            this.profilesFormView1 = new ViewWinform.Security.Profiles.ProfilesFormView();
            this.SuspendLayout();
            // 
            // profilesFormView1
            // 
            this.profilesFormView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilesFormView1.Location = new System.Drawing.Point(5, 30);
            profileModel2.Created_By = null;
            profileModel2.Created_On = new System.DateTime(((long)(0)));
            profileModel2.Id = "";
            profileModel2.Profile_Name = "";
            profileModel2.Updated_By = null;
            profileModel2.Updated_On = new System.DateTime(((long)(0)));
            this.profilesFormView1.model = profileModel2;
            this.profilesFormView1.Name = "profilesFormView1";
            this.profilesFormView1.Size = new System.Drawing.Size(528, 282);
            this.profilesFormView1.TabIndex = 2;
            // 
            // PorfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 342);
            this.Controls.Add(this.profilesFormView1);
            this.Name = "PorfileView";
            this.Text = "PorfileView";
            this.OnRecordPositionChanged += new ViewWinform.Common.CommonView.RecordPositionHandler(this.PorfileView_OnRecordPositionChanged);
            this.OnRecordOperationInvoked += new ViewWinform.Common.CommonView.RecordOperationHandler(this.PorfileView_OnRecordOperationInvoked);
            this.Controls.SetChildIndex(this.profilesFormView1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProfilesFormView profilesFormView1;
    }
}