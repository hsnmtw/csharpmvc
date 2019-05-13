namespace ViewWinform.Customers.Nationalities {
    partial class NationalityListView {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            ModelLibrary.Customers.NationalityModel nationalityModel1 = new ModelLibrary.Customers.NationalityModel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality_Arabic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Go_Button = new System.Windows.Forms.Button();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nationalityFormView1 = new ViewWinform.Customers.Nationalities.NationalityFormView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(294, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(523, 373);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(519, 336);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nationality_Code,
            this.Nationality_Desc,
            this.Nationality_Arabic});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(519, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DataGridView1_RowStateChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 42;
            // 
            // Nationality_Code
            // 
            this.Nationality_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nationality_Code.DataPropertyName = "Nationality_Code";
            this.Nationality_Code.HeaderText = "Code";
            this.Nationality_Code.Name = "Nationality_Code";
            this.Nationality_Code.ReadOnly = true;
            this.Nationality_Code.Width = 57;
            // 
            // Nationality_Desc
            // 
            this.Nationality_Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nationality_Desc.DataPropertyName = "Nationality_Desc";
            this.Nationality_Desc.HeaderText = "Nationality EN";
            this.Nationality_Desc.Name = "Nationality_Desc";
            this.Nationality_Desc.ReadOnly = true;
            this.Nationality_Desc.Width = 99;
            // 
            // Nationality_Arabic
            // 
            this.Nationality_Arabic.DataPropertyName = "Nationality_Arabic";
            this.Nationality_Arabic.HeaderText = "Nationality AR";
            this.Nationality_Arabic.Name = "Nationality_Arabic";
            this.Nationality_Arabic.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Go_Button);
            this.panel2.Controls.Add(this.Search_TextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 33);
            this.panel2.TabIndex = 0;
            // 
            // Go_Button
            // 
            this.Go_Button.Location = new System.Drawing.Point(476, 4);
            this.Go_Button.Name = "Go_Button";
            this.Go_Button.Size = new System.Drawing.Size(33, 23);
            this.Go_Button.TabIndex = 2;
            this.Go_Button.Text = "Go";
            this.Go_Button.UseVisualStyleBackColor = true;
            this.Go_Button.Click += new System.EventHandler(this.Go_Button_Click);
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(58, 6);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(412, 20);
            this.Search_TextBox.TabIndex = 1;
            this.Search_TextBox.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nationalityFormView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 373);
            this.panel3.TabIndex = 5;
            // 
            // nationalityFormView1
            // 
            this.nationalityFormView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nationalityFormView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nationalityFormView1.Location = new System.Drawing.Point(0, 0);
            nationalityModel1.Created_By = null;
            nationalityModel1.Created_On = new System.DateTime(((long)(0)));
            nationalityModel1.Id = "";
            nationalityModel1.Nationality_Arabic = "";
            nationalityModel1.Nationality_Code = "";
            nationalityModel1.Nationality_Desc = "";
            nationalityModel1.Updated_By = null;
            nationalityModel1.Updated_On = new System.DateTime(((long)(0)));
            this.nationalityFormView1.model = nationalityModel1;
            this.nationalityFormView1.Name = "nationalityFormView1";
            this.nationalityFormView1.Padding = new System.Windows.Forms.Padding(3);
            this.nationalityFormView1.Size = new System.Drawing.Size(294, 373);
            this.nationalityFormView1.TabIndex = 0;
            //this.nationalityFormView1.OnSaveDeleteAction += new System.EventHandler(this.NationalityFormView1_OnSaveDeleteAction);
            // 
            // NationalityListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "NationalityListView";
            this.Size = new System.Drawing.Size(817, 373);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Go_Button;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private NationalityFormView nationalityFormView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality_Arabic;
    }
}
