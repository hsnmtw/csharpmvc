namespace MVCHIS.Tools {
    partial class DateConversionForm {
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.listViewControl1 = new MVCHIS.Utils.ListViewControl();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoGregorian = new System.Windows.Forms.RadioButton();
            this.rdoHijri = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(176, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(284, 314);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(392, 314);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(172, 10);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(49, 20);
            this.txtYear.TabIndex = 0;
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(237, 9);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(41, 23);
            this.btnGO.TabIndex = 1;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.BtnGO_Click);
            // 
            // listViewControl1
            // 
            this.listViewControl1.Filter = null;
            //new System.Drawing.Font("Consolas", 9F);
            this.listViewControl1.FullRowSelect = true;
            this.listViewControl1.GridLines = true;
            this.listViewControl1.HideSelection = false;
            this.listViewControl1.LabelWrap = false;
            this.listViewControl1.Location = new System.Drawing.Point(12, 36);
            this.listViewControl1.MultiSelect = false;
            this.listViewControl1.Name = "listViewControl1";
            this.listViewControl1.Size = new System.Drawing.Size(455, 272);
            this.listViewControl1.TabIndex = 2;
            this.listViewControl1.UseCompatibleStateImageBehavior = false;
            this.listViewControl1.View = System.Windows.Forms.View.Details;
            this.listViewControl1.DoubleClick += new System.EventHandler(this.ListViewControl1_DoubleClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(298, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Double click on a row to update";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoGregorian
            // 
            this.rdoGregorian.AutoSize = true;
            this.rdoGregorian.Checked = true;
            this.rdoGregorian.Location = new System.Drawing.Point(12, 11);
            this.rdoGregorian.Name = "rdoGregorian";
            this.rdoGregorian.Size = new System.Drawing.Size(72, 17);
            this.rdoGregorian.TabIndex = 30;
            this.rdoGregorian.Text = "Gregorian";
            this.rdoGregorian.UseVisualStyleBackColor = true;
            // 
            // rdoHijri
            // 
            this.rdoHijri.AutoSize = true;
            this.rdoHijri.Location = new System.Drawing.Point(108, 11);
            this.rdoHijri.Name = "rdoHijri";
            this.rdoHijri.Size = new System.Drawing.Size(43, 17);
            this.rdoHijri.TabIndex = 30;
            this.rdoHijri.Text = "Hijri";
            this.rdoHijri.UseVisualStyleBackColor = true;
            // 
            // DateConversionForm
            // 
            this.Controls.Add(this.rdoHijri);
            this.Controls.Add(this.rdoGregorian);
            this.Controls.Add(this.listViewControl1);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Name = "DateConversionForm";
            this.Size = new System.Drawing.Size(478, 340);
            this.Load += new System.EventHandler(this.DateConversionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnGO;
        private Utils.ListViewControl listViewControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoGregorian;
        private System.Windows.Forms.RadioButton rdoHijri;
    }
}
