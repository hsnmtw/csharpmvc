namespace ViewWinform.Security.Audit {
    partial class AuditView {
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
            this.auditFormView1 = new ViewWinform.Security.Audit.AuditFormView();
            this.SuspendLayout();
            // 
            // auditFormView1
            // 
            this.auditFormView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auditFormView1.Location = new System.Drawing.Point(5, 30);
            this.auditFormView1.model = null;
            this.auditFormView1.Name = "auditFormView1";
            this.auditFormView1.Size = new System.Drawing.Size(612, 373);
            this.auditFormView1.TabIndex = 2;
            // 
            // AuditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.auditFormView1);
            this.Name = "AuditView";
            this.Text = "AuditView";
            this.OnRecordPositionChanged += new ViewWinform.Common.CommonView.RecordPositionHandler(this.AuditView_OnRecordPositionChanged);
            this.OnRecordOperationInvoked += new ViewWinform.Common.CommonView.RecordOperationHandler(this.AuditView_OnRecordOperationInvoked);
            this.Controls.SetChildIndex(this.auditFormView1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AuditFormView auditFormView1;
    }
}