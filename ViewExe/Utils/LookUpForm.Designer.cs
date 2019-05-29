namespace MVCHIS.Common {
    partial class LookUpForm {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstView = new ViewWinform.Utils.FixedWidthListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(407, 26);
            this.panel1.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.SystemColors.Window;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Location = new System.Drawing.Point(3, 3);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(401, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSearch.TextChanged += new System.EventHandler(this.Label1TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(407, 289);
            this.panel2.TabIndex = 0;
            // 
            // lstView
            // 
            this.lstView.DataSource = null;
            this.lstView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstView.Filter = null;
            this.lstView.Location = new System.Drawing.Point(3, 3);
            this.lstView.Name = "lstView";
            this.lstView.ShownColumns = null;
            this.lstView.Size = new System.Drawing.Size(401, 283);
            this.lstView.TabIndex = 0;
            this.lstView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstView_KeyDown);
            this.lstView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LstView_KeyPress);
            // 
            // LookUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 315);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LookUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LookUp";
            this.Load += new System.EventHandler(this.LookUpLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LookUpKeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSearch;
        private ViewWinform.Utils.FixedWidthListBox lstView;
    }
}