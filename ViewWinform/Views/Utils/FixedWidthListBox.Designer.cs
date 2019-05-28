namespace ViewWinform.Utils {
    partial class FixedWidthListBox {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lstView = new System.Windows.Forms.ListBox();
            this.lblRowHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstView
            // 
            this.lstView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView.FormattingEnabled = true;
            this.lstView.Location = new System.Drawing.Point(0, 17);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(150, 133);
            this.lstView.TabIndex = 1;
            this.lstView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstView_KeyDown);
            this.lstView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LstView_KeyPress);
            // 
            // lblRowHeader
            // 
            this.lblRowHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRowHeader.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowHeader.Location = new System.Drawing.Point(0, 0);
            this.lblRowHeader.Name = "lblRowHeader";
            this.lblRowHeader.Size = new System.Drawing.Size(150, 17);
            this.lblRowHeader.TabIndex = 2;
            this.lblRowHeader.Text = ".";
            // 
            // FixedWidthListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.lblRowHeader);
            this.Name = "FixedWidthListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstView;
        private System.Windows.Forms.Label lblRowHeader;
    }
}
