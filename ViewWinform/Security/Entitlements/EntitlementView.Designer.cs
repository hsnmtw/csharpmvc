namespace ViewWinform.Security.Entitlements {
    partial class EntitlementView {
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
            ModelLibrary.Security.EntitlementModel entitlementModel4 = new ModelLibrary.Security.EntitlementModel();
            this.entitelmentFormView1 = new ViewWinform.Security.Entitlements.EntitelmentFormView();
            this.SuspendLayout();
            // 
            // entitelmentFormView1
            // 
            this.entitelmentFormView1.Location = new System.Drawing.Point(8, 49);
            entitlementModel4.Created_By = null;
            entitlementModel4.Created_On = new System.DateTime(((long)(0)));
            entitlementModel4.Entitlement_Name = "";
            entitlementModel4.Id = "";
            entitlementModel4.Updated_By = null;
            entitlementModel4.Updated_On = new System.DateTime(((long)(0)));
            this.entitelmentFormView1.model = entitlementModel4;
            this.entitelmentFormView1.Name = "entitelmentFormView1";
            this.entitelmentFormView1.Size = new System.Drawing.Size(312, 67);
            this.entitelmentFormView1.TabIndex = 2;
            // 
            // EntitlementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 169);
            this.Controls.Add(this.entitelmentFormView1);
            this.Name = "EntitlementView";
            this.Text = "EntitlementView";
            this.OnRecordPositionChanged += new ViewWinform.Common.CommonView.RecordPositionHandler(this.EntitlementView_OnRecordPositionChanged);
            this.OnRecordOperationInvoked += new ViewWinform.Common.CommonView.RecordOperationHandler(this.EntitlementView_OnRecordOperationInvoked);
            this.OnSaveInvoked += new ViewWinform.Common.CommonView.RecordSpecificOperationHandler(this.EntitlementView_OnSaveInvoked);
            this.OnNewInvoked += new ViewWinform.Common.CommonView.RecordSpecificOperationHandler(this.EntitlementView_OnNewInvoked);
            this.OnDeleteInvoked += new ViewWinform.Common.CommonView.RecordSpecificOperationHandler(this.EntitlementView_OnDeleteInvoked);
            this.OnTableInvoked += new ViewWinform.Common.CommonView.RecordSpecificOperationHandler(this.EntitlementView_OnTableInvoked);
            this.Controls.SetChildIndex(this.entitelmentFormView1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EntitelmentFormView entitelmentFormView1;
    }
}