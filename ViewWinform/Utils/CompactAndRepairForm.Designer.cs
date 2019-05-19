namespace ViewWinform.Utils {
    partial class CompactAndRepairForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatabaseFileSize = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDatabaseFileName = new System.Windows.Forms.Label();
            this.lblNewDatabaseFileSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database file size";
            // 
            // lblDatabaseFileSize
            // 
            this.lblDatabaseFileSize.AutoSize = true;
            this.lblDatabaseFileSize.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblDatabaseFileSize.Location = new System.Drawing.Point(143, 36);
            this.lblDatabaseFileSize.Name = "lblDatabaseFileSize";
            this.lblDatabaseFileSize.Size = new System.Drawing.Size(34, 13);
            this.lblDatabaseFileSize.TabIndex = 1;
            this.lblDatabaseFileSize.Text = "0 MB";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Compact and Repair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Database file name";
            // 
            // lblDatabaseFileName
            // 
            this.lblDatabaseFileName.AutoSize = true;
            this.lblDatabaseFileName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblDatabaseFileName.Location = new System.Drawing.Point(143, 14);
            this.lblDatabaseFileName.Name = "lblDatabaseFileName";
            this.lblDatabaseFileName.Size = new System.Drawing.Size(159, 13);
            this.lblDatabaseFileName.TabIndex = 1;
            this.lblDatabaseFileName.Text = "path to database file name";
            // 
            // lblNewDatabaseFileSize
            // 
            this.lblNewDatabaseFileSize.AutoSize = true;
            this.lblNewDatabaseFileSize.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblNewDatabaseFileSize.Location = new System.Drawing.Point(143, 58);
            this.lblNewDatabaseFileSize.Name = "lblNewDatabaseFileSize";
            this.lblNewDatabaseFileSize.Size = new System.Drawing.Size(34, 13);
            this.lblNewDatabaseFileSize.TabIndex = 1;
            this.lblNewDatabaseFileSize.Text = "0 MB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "New Database file size";
            // 
            // CompactAndRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 110);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDatabaseFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNewDatabaseFileSize);
            this.Controls.Add(this.lblDatabaseFileSize);
            this.Controls.Add(this.label1);
            this.Name = "CompactAndRepairForm";
            this.Text = "Compact and Repair";
            this.Load += new System.EventHandler(this.CompactAndRepairForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatabaseFileSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDatabaseFileName;
        private System.Windows.Forms.Label lblNewDatabaseFileSize;
        private System.Windows.Forms.Label label5;
    }
}