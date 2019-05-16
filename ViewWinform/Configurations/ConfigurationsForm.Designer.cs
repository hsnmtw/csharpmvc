namespace ViewWinform.Configurations {
    partial class ConfigurationsForm {
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DatabaseConfig_DataGridView = new System.Windows.Forms.DataGridView();
            this.CultureInfoConfig_DataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.KeyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseConfig_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CultureInfoConfig_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuration File Path";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(503, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 206);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DatabaseConfig_DataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Database";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CultureInfoConfig_DataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CultureInfo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DatabaseConfig_DataGridView
            // 
            this.DatabaseConfig_DataGridView.AllowUserToAddRows = false;
            this.DatabaseConfig_DataGridView.AllowUserToDeleteRows = false;
            this.DatabaseConfig_DataGridView.AllowUserToResizeRows = false;
            this.DatabaseConfig_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatabaseConfig_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseConfig_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DatabaseConfig_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseConfig_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeyColumn,
            this.ValueColumn});
            this.DatabaseConfig_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabaseConfig_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DatabaseConfig_DataGridView.Location = new System.Drawing.Point(3, 3);
            this.DatabaseConfig_DataGridView.Name = "DatabaseConfig_DataGridView";
            this.DatabaseConfig_DataGridView.RowHeadersWidth = 30;
            this.DatabaseConfig_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatabaseConfig_DataGridView.ShowCellErrors = false;
            this.DatabaseConfig_DataGridView.ShowCellToolTips = false;
            this.DatabaseConfig_DataGridView.ShowEditingIcon = false;
            this.DatabaseConfig_DataGridView.ShowRowErrors = false;
            this.DatabaseConfig_DataGridView.Size = new System.Drawing.Size(606, 174);
            this.DatabaseConfig_DataGridView.TabIndex = 2;
            // 
            // CultureInfoConfig_DataGridView
            // 
            this.CultureInfoConfig_DataGridView.AllowUserToAddRows = false;
            this.CultureInfoConfig_DataGridView.AllowUserToDeleteRows = false;
            this.CultureInfoConfig_DataGridView.AllowUserToResizeRows = false;
            this.CultureInfoConfig_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CultureInfoConfig_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CultureInfoConfig_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CultureInfoConfig_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CultureInfoConfig_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.CultureInfoConfig_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CultureInfoConfig_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CultureInfoConfig_DataGridView.Location = new System.Drawing.Point(3, 3);
            this.CultureInfoConfig_DataGridView.Name = "CultureInfoConfig_DataGridView";
            this.CultureInfoConfig_DataGridView.RowHeadersWidth = 30;
            this.CultureInfoConfig_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CultureInfoConfig_DataGridView.ShowCellErrors = false;
            this.CultureInfoConfig_DataGridView.ShowCellToolTips = false;
            this.CultureInfoConfig_DataGridView.ShowEditingIcon = false;
            this.CultureInfoConfig_DataGridView.ShowRowErrors = false;
            this.CultureInfoConfig_DataGridView.Size = new System.Drawing.Size(606, 174);
            this.CultureInfoConfig_DataGridView.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(522, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // KeyColumn
            // 
            this.KeyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KeyColumn.DataPropertyName = "Key";
            this.KeyColumn.HeaderText = "Key";
            this.KeyColumn.Name = "KeyColumn";
            this.KeyColumn.ReadOnly = true;
            this.KeyColumn.Width = 50;
            // 
            // ValueColumn
            // 
            this.ValueColumn.DataPropertyName = "Value";
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Key";
            this.dataGridViewTextBoxColumn1.HeaderText = "Key";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // ConfigurationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ConfigurationsForm";
            this.Text = "Configurations";
            this.Load += new System.EventHandler(this.ConfigurationsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseConfig_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CultureInfoConfig_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DatabaseConfig_DataGridView;
        private System.Windows.Forms.DataGridView CultureInfoConfig_DataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}