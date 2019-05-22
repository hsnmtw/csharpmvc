namespace ViewWinform.Configurations {
    partial class DBMaintenance {
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
            this.DatabaseSourceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SizeondiskLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberofTablesLabel = new System.Windows.Forms.Label();
            this.NumberofViewsLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CompactRepairButton = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackupTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Source";
            // 
            // DatabaseSourceLabel
            // 
            this.DatabaseSourceLabel.AutoSize = true;
            this.DatabaseSourceLabel.Location = new System.Drawing.Point(13, 38);
            this.DatabaseSourceLabel.Name = "DatabaseSourceLabel";
            this.DatabaseSourceLabel.Size = new System.Drawing.Size(89, 13);
            this.DatabaseSourceLabel.TabIndex = 0;
            this.DatabaseSourceLabel.Text = "Database Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Size on disk";
            // 
            // SizeondiskLabel
            // 
            this.SizeondiskLabel.AutoSize = true;
            this.SizeondiskLabel.Location = new System.Drawing.Point(13, 95);
            this.SizeondiskLabel.Name = "SizeondiskLabel";
            this.SizeondiskLabel.Size = new System.Drawing.Size(62, 13);
            this.SizeondiskLabel.TabIndex = 0;
            this.SizeondiskLabel.Text = "Size on disk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number of Tables";
            // 
            // NumberofTablesLabel
            // 
            this.NumberofTablesLabel.AutoSize = true;
            this.NumberofTablesLabel.Location = new System.Drawing.Point(133, 95);
            this.NumberofTablesLabel.Name = "NumberofTablesLabel";
            this.NumberofTablesLabel.Size = new System.Drawing.Size(91, 13);
            this.NumberofTablesLabel.TabIndex = 0;
            this.NumberofTablesLabel.Text = "Number of Tables";
            // 
            // NumberofViewsLabel
            // 
            this.NumberofViewsLabel.AutoSize = true;
            this.NumberofViewsLabel.Location = new System.Drawing.Point(282, 95);
            this.NumberofViewsLabel.Name = "NumberofViewsLabel";
            this.NumberofViewsLabel.Size = new System.Drawing.Size(87, 13);
            this.NumberofViewsLabel.TabIndex = 1;
            this.NumberofViewsLabel.Text = "Number of Views";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(282, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Number of Views";
            // 
            // CompactRepairButton
            // 
            this.CompactRepairButton.Enabled = false;
            this.CompactRepairButton.Location = new System.Drawing.Point(16, 139);
            this.CompactRepairButton.Name = "CompactRepairButton";
            this.CompactRepairButton.Size = new System.Drawing.Size(133, 23);
            this.CompactRepairButton.TabIndex = 3;
            this.CompactRepairButton.Text = "Compact and Repair";
            this.CompactRepairButton.UseVisualStyleBackColor = true;
            // 
            // BackupButton
            // 
            this.BackupButton.Enabled = false;
            this.BackupButton.Location = new System.Drawing.Point(180, 139);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(77, 23);
            this.BackupButton.TabIndex = 3;
            this.BackupButton.Text = "Backup";
            this.BackupButton.UseVisualStyleBackColor = true;
            // 
            // RestoreButton
            // 
            this.RestoreButton.Enabled = false;
            this.RestoreButton.Location = new System.Drawing.Point(300, 139);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(77, 23);
            this.RestoreButton.TabIndex = 3;
            this.RestoreButton.Text = "Restore";
            this.RestoreButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Backups";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.FileNameColumn,
            this.SizeColumn,
            this.BackupTypeColumn});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(8, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(374, 232);
            this.dataGridView1.TabIndex = 4;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.HeaderText = "File Name";
            this.FileNameColumn.Name = "FileNameColumn";
            this.FileNameColumn.ReadOnly = true;
            // 
            // SizeColumn
            // 
            this.SizeColumn.HeaderText = "Size on disk";
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.ReadOnly = true;
            // 
            // BackupTypeColumn
            // 
            this.BackupTypeColumn.HeaderText = "Backup Type";
            this.BackupTypeColumn.Name = "BackupTypeColumn";
            this.BackupTypeColumn.ReadOnly = true;
            // 
            // DBMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RestoreButton);
            this.Controls.Add(this.BackupButton);
            this.Controls.Add(this.CompactRepairButton);
            this.Controls.Add(this.NumberofViewsLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumberofTablesLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SizeondiskLabel);
            this.Controls.Add(this.DatabaseSourceLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DBMaintenance";
            this.Text = "Database Maintenance";
            this.Load += new System.EventHandler(this.DBMaintenanceLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DatabaseSourceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SizeondiskLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NumberofTablesLabel;
        private System.Windows.Forms.Label NumberofViewsLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CompactRepairButton;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupTypeColumn;
    }
}