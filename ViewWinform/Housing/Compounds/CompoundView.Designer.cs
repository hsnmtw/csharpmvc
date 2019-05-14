namespace ViewWinform.Housing.Compounds {
    partial class CompoundView {
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
            this.compoundFormView1 = new ViewWinform.Housing.Compounds.CompoundFormView();
            this.SuspendLayout();
            // 
            // compoundFormView1
            // 
            this.compoundFormView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compoundFormView1.Location = new System.Drawing.Point(5, 71);
            this.compoundFormView1.Name = "compoundFormView1";
            this.compoundFormView1.Size = new System.Drawing.Size(316, 78);
            this.compoundFormView1.TabIndex = 0;
            // 
            // CompoundView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 179);
            this.Controls.Add(this.compoundFormView1);
            this.Name = "CompoundView";
            this.Text = "CompoundView";
            this.OnRecordPositionChanged += new ViewWinform.Common.CommonView.RecordPositionHandler(this.CompoundView_OnRecordPositionChanged);
            this.OnSaveInvoked += new ViewWinform.Common.CommonView.RecordSpecificOperationHandler(this.CompoundView_OnSaveInvoked);
            this.OnNewInvoked += new ViewWinform.Common.CommonView.RecordSpecificOperationHandler(this.CompoundView_OnNewInvoked);
            this.OnDeleteInvoked += new ViewWinform.Common.CommonView.RecordSpecificOperationHandler(this.CompoundView_OnDeleteInvoked);
            this.OnTableInvoked += new ViewWinform.Common.CommonView.RecordSpecificOperationHandler(this.CompoundView_OnTableInvoked);
            this.Controls.SetChildIndex(this.compoundFormView1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CompoundFormView compoundFormView1;
    }
}