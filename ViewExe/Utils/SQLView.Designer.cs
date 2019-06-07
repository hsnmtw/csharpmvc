namespace MVCHIS.Utils {
    partial class SQLView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(){
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkMSAccess = new System.Windows.Forms.CheckBox();
            this.btnRunSql = new System.Windows.Forms.Button();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.btnEntities = new System.Windows.Forms.Button();
            this.contextMenuStripEntities = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkMSAccess);
            this.panel1.Controls.Add(this.btnEntities);
            this.panel1.Controls.Add(this.btnRunSql);
            this.panel1.Controls.Add(this.txtSQL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(396, 301);
            this.panel1.TabIndex = 0;
            // 
            // chkMSAccess
            // 
            this.chkMSAccess.AutoSize = true;
            this.chkMSAccess.Enabled = false;
            this.chkMSAccess.Location = new System.Drawing.Point(312, 49);
            this.chkMSAccess.Name = "chkMSAccess";
            this.chkMSAccess.Size = new System.Drawing.Size(76, 17);
            this.chkMSAccess.TabIndex = 2;
            this.chkMSAccess.Text = "MS Access";
            this.chkMSAccess.UseVisualStyleBackColor = true;
            // 
            // btnRunSql
            // 
            this.btnRunSql.Location = new System.Drawing.Point(313, 13);
            this.btnRunSql.Name = "btnRunSql";
            this.btnRunSql.Size = new System.Drawing.Size(75, 23);
            this.btnRunSql.TabIndex = 1;
            this.btnRunSql.Text = "&RUN";
            this.btnRunSql.UseVisualStyleBackColor = true;
            this.btnRunSql.Click += new System.EventHandler(this.Button1Click);
            // 
            // txtSQL
            // 
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSQL.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQL.Location = new System.Drawing.Point(5, 5);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(302, 291);
            this.txtSQL.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtResults);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(396, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(487, 301);
            this.panel2.TabIndex = 1;
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.Info;
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResults.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(5, 5);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(477, 291);
            this.txtResults.TabIndex = 0;
            this.txtResults.Text = "";
            this.txtResults.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // btnEntities
            // 
            this.btnEntities.Location = new System.Drawing.Point(313, 72);
            this.btnEntities.Name = "btnEntities";
            this.btnEntities.Size = new System.Drawing.Size(75, 23);
            this.btnEntities.TabIndex = 1;
            this.btnEntities.Text = "Entities";
            this.btnEntities.UseVisualStyleBackColor = true;
            this.btnEntities.Click += new System.EventHandler(this.BtnEntities_Click);
            // 
            // contextMenuStripEntities
            // 
            this.contextMenuStripEntities.Name = "contextMenuStripEntities";
            this.contextMenuStripEntities.Size = new System.Drawing.Size(61, 4);
            // 
            // SQLView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 301);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SQLView";
            this.Text = "SQLView";
            this.Load += new System.EventHandler(this.SQLView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRunSql;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkMSAccess;
        private System.Windows.Forms.RichTextBox txtResults;
        private System.Windows.Forms.Button btnEntities;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEntities;
    }
}