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
            this.Database_Source_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Size_on_disk_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Number_of_Tables_Label = new System.Windows.Forms.Label();
            this.Number_of_Views_Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CompactRepair_Button = new System.Windows.Forms.Button();
            this.Backup_Button = new System.Windows.Forms.Button();
            this.Restore_Button = new System.Windows.Forms.Button();
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
            // Database_Source_Label
            // 
            this.Database_Source_Label.AutoSize = true;
            this.Database_Source_Label.Location = new System.Drawing.Point(13, 38);
            this.Database_Source_Label.Name = "Database_Source_Label";
            this.Database_Source_Label.Size = new System.Drawing.Size(89, 13);
            this.Database_Source_Label.TabIndex = 0;
            this.Database_Source_Label.Text = "Database Source";
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
            // Size_on_disk_Label
            // 
            this.Size_on_disk_Label.AutoSize = true;
            this.Size_on_disk_Label.Location = new System.Drawing.Point(13, 95);
            this.Size_on_disk_Label.Name = "Size_on_disk_Label";
            this.Size_on_disk_Label.Size = new System.Drawing.Size(62, 13);
            this.Size_on_disk_Label.TabIndex = 0;
            this.Size_on_disk_Label.Text = "Size on disk";
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
            // Number_of_Tables_Label
            // 
            this.Number_of_Tables_Label.AutoSize = true;
            this.Number_of_Tables_Label.Location = new System.Drawing.Point(133, 95);
            this.Number_of_Tables_Label.Name = "Number_of_Tables_Label";
            this.Number_of_Tables_Label.Size = new System.Drawing.Size(91, 13);
            this.Number_of_Tables_Label.TabIndex = 0;
            this.Number_of_Tables_Label.Text = "Number of Tables";
            // 
            // Number_of_Views_Label
            // 
            this.Number_of_Views_Label.AutoSize = true;
            this.Number_of_Views_Label.Location = new System.Drawing.Point(282, 95);
            this.Number_of_Views_Label.Name = "Number_of_Views_Label";
            this.Number_of_Views_Label.Size = new System.Drawing.Size(87, 13);
            this.Number_of_Views_Label.TabIndex = 1;
            this.Number_of_Views_Label.Text = "Number of Views";
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
            // CompactRepair_Button
            // 
            this.CompactRepair_Button.Enabled = false;
            this.CompactRepair_Button.Location = new System.Drawing.Point(16, 139);
            this.CompactRepair_Button.Name = "CompactRepair_Button";
            this.CompactRepair_Button.Size = new System.Drawing.Size(133, 23);
            this.CompactRepair_Button.TabIndex = 3;
            this.CompactRepair_Button.Text = "Compact and Repair";
            this.CompactRepair_Button.UseVisualStyleBackColor = true;
            // 
            // Backup_Button
            // 
            this.Backup_Button.Enabled = false;
            this.Backup_Button.Location = new System.Drawing.Point(180, 139);
            this.Backup_Button.Name = "Backup_Button";
            this.Backup_Button.Size = new System.Drawing.Size(77, 23);
            this.Backup_Button.TabIndex = 3;
            this.Backup_Button.Text = "Backup";
            this.Backup_Button.UseVisualStyleBackColor = true;
            // 
            // Restore_Button
            // 
            this.Restore_Button.Enabled = false;
            this.Restore_Button.Location = new System.Drawing.Point(300, 139);
            this.Restore_Button.Name = "Restore_Button";
            this.Restore_Button.Size = new System.Drawing.Size(77, 23);
            this.Restore_Button.TabIndex = 3;
            this.Restore_Button.Text = "Restore";
            this.Restore_Button.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.Restore_Button);
            this.Controls.Add(this.Backup_Button);
            this.Controls.Add(this.CompactRepair_Button);
            this.Controls.Add(this.Number_of_Views_Label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Number_of_Tables_Label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Size_on_disk_Label);
            this.Controls.Add(this.Database_Source_Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DBMaintenance";
            this.Text = "Database Maintenance";
            this.Load += new System.EventHandler(this.DBMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Database_Source_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Size_on_disk_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Number_of_Tables_Label;
        private System.Windows.Forms.Label Number_of_Views_Label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CompactRepair_Button;
        private System.Windows.Forms.Button Backup_Button;
        private System.Windows.Forms.Button Restore_Button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupTypeColumn;
    }
}