namespace ViewWinform.Tools {
    partial class CalendarForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.Sun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl1_1 = new System.Windows.Forms.Label();
            this.lbl1_2 = new System.Windows.Forms.Label();
            this.lbl1_5 = new System.Windows.Forms.Label();
            this.lbl1_6 = new System.Windows.Forms.Label();
            this.lbl1_3 = new System.Windows.Forms.Label();
            this.lbl1_7 = new System.Windows.Forms.Label();
            this.lbl1_4 = new System.Windows.Forms.Label();
            this.lbl2_4 = new System.Windows.Forms.Label();
            this.lbl2_7 = new System.Windows.Forms.Label();
            this.lbl2_3 = new System.Windows.Forms.Label();
            this.lbl2_6 = new System.Windows.Forms.Label();
            this.lbl2_5 = new System.Windows.Forms.Label();
            this.lbl2_2 = new System.Windows.Forms.Label();
            this.lbl2_1 = new System.Windows.Forms.Label();
            this.lbl3_4 = new System.Windows.Forms.Label();
            this.lbl3_7 = new System.Windows.Forms.Label();
            this.lbl3_3 = new System.Windows.Forms.Label();
            this.lbl3_6 = new System.Windows.Forms.Label();
            this.lbl3_5 = new System.Windows.Forms.Label();
            this.lbl3_2 = new System.Windows.Forms.Label();
            this.lbl3_1 = new System.Windows.Forms.Label();
            this.lbl4_4 = new System.Windows.Forms.Label();
            this.lbl4_7 = new System.Windows.Forms.Label();
            this.lbl4_3 = new System.Windows.Forms.Label();
            this.lbl4_6 = new System.Windows.Forms.Label();
            this.lbl4_5 = new System.Windows.Forms.Label();
            this.lbl4_2 = new System.Windows.Forms.Label();
            this.lbl4_1 = new System.Windows.Forms.Label();
            this.lbl5_4 = new System.Windows.Forms.Label();
            this.lbl5_7 = new System.Windows.Forms.Label();
            this.lbl5_3 = new System.Windows.Forms.Label();
            this.lbl5_6 = new System.Windows.Forms.Label();
            this.lbl5_5 = new System.Windows.Forms.Label();
            this.lbl5_2 = new System.Windows.Forms.Label();
            this.lbl5_1 = new System.Windows.Forms.Label();
            this.lbl6_4 = new System.Windows.Forms.Label();
            this.lbl6_7 = new System.Windows.Forms.Label();
            this.lbl6_3 = new System.Windows.Forms.Label();
            this.lbl6_6 = new System.Windows.Forms.Label();
            this.lbl6_5 = new System.Windows.Forms.Label();
            this.lbl6_2 = new System.Windows.Forms.Label();
            this.lbl6_1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Month";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(40, 7);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(74, 21);
            this.cmbYear.TabIndex = 2;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.CmbYear_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "1 - JAN",
            "2 - FEB",
            "3 - MAR",
            "4 - APR",
            "5 - MAY",
            "6 - JUN",
            "7 - JUL",
            "8 - AUG",
            "9 - SEP",
            "10 - OCT",
            "11 - NOV",
            "12 - DEC"});
            this.cmbMonth.Location = new System.Drawing.Point(173, 7);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(81, 21);
            this.cmbMonth.TabIndex = 3;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.CmbYear_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sun,
            this.Mon,
            this.Tue,
            this.Wed,
            this.Thu,
            this.Fri,
            this.Sat});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(8, 239);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(246, 154);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.DataGridView1_CellStateChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(179, 197);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Sun
            // 
            this.Sun.DataPropertyName = "Sun";
            this.Sun.HeaderText = "Sun";
            this.Sun.Name = "Sun";
            this.Sun.ReadOnly = true;
            this.Sun.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sun.Width = 35;
            // 
            // Mon
            // 
            this.Mon.DataPropertyName = "Mon";
            this.Mon.HeaderText = "Mon";
            this.Mon.Name = "Mon";
            this.Mon.ReadOnly = true;
            this.Mon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Mon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mon.Width = 35;
            // 
            // Tue
            // 
            this.Tue.DataPropertyName = "Tue";
            this.Tue.HeaderText = "Tue";
            this.Tue.Name = "Tue";
            this.Tue.ReadOnly = true;
            this.Tue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tue.Width = 35;
            // 
            // Wed
            // 
            this.Wed.DataPropertyName = "Wed";
            this.Wed.HeaderText = "Wed";
            this.Wed.Name = "Wed";
            this.Wed.ReadOnly = true;
            this.Wed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Wed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Wed.Width = 35;
            // 
            // Thu
            // 
            this.Thu.DataPropertyName = "Thu";
            this.Thu.HeaderText = "Thu";
            this.Thu.Name = "Thu";
            this.Thu.ReadOnly = true;
            this.Thu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Thu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Thu.Width = 35;
            // 
            // Fri
            // 
            this.Fri.DataPropertyName = "Fri";
            this.Fri.HeaderText = "Fri";
            this.Fri.Name = "Fri";
            this.Fri.ReadOnly = true;
            this.Fri.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fri.Width = 35;
            // 
            // Sat
            // 
            this.Sat.DataPropertyName = "Sat";
            this.Sat.HeaderText = "Sat";
            this.Sat.Name = "Sat";
            this.Sat.ReadOnly = true;
            this.Sat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sat.Width = 35;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl6_4);
            this.panel1.Controls.Add(this.lbl6_7);
            this.panel1.Controls.Add(this.lbl6_3);
            this.panel1.Controls.Add(this.lbl6_6);
            this.panel1.Controls.Add(this.lbl6_5);
            this.panel1.Controls.Add(this.lbl6_2);
            this.panel1.Controls.Add(this.lbl6_1);
            this.panel1.Controls.Add(this.lbl5_4);
            this.panel1.Controls.Add(this.lbl5_7);
            this.panel1.Controls.Add(this.lbl5_3);
            this.panel1.Controls.Add(this.lbl5_6);
            this.panel1.Controls.Add(this.lbl5_5);
            this.panel1.Controls.Add(this.lbl5_2);
            this.panel1.Controls.Add(this.lbl5_1);
            this.panel1.Controls.Add(this.lbl4_4);
            this.panel1.Controls.Add(this.lbl4_7);
            this.panel1.Controls.Add(this.lbl4_3);
            this.panel1.Controls.Add(this.lbl4_6);
            this.panel1.Controls.Add(this.lbl4_5);
            this.panel1.Controls.Add(this.lbl4_2);
            this.panel1.Controls.Add(this.lbl4_1);
            this.panel1.Controls.Add(this.lbl3_4);
            this.panel1.Controls.Add(this.lbl3_7);
            this.panel1.Controls.Add(this.lbl3_3);
            this.panel1.Controls.Add(this.lbl3_6);
            this.panel1.Controls.Add(this.lbl3_5);
            this.panel1.Controls.Add(this.lbl3_2);
            this.panel1.Controls.Add(this.lbl3_1);
            this.panel1.Controls.Add(this.lbl2_4);
            this.panel1.Controls.Add(this.lbl2_7);
            this.panel1.Controls.Add(this.lbl2_3);
            this.panel1.Controls.Add(this.lbl2_6);
            this.panel1.Controls.Add(this.lbl2_5);
            this.panel1.Controls.Add(this.lbl2_2);
            this.panel1.Controls.Add(this.lbl2_1);
            this.panel1.Controls.Add(this.lbl1_4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl1_7);
            this.panel1.Controls.Add(this.lbl1_3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl1_6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl1_5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl1_2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbl1_1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 143);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(5, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sun";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(37, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mon";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(69, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tue";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(101, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Wed";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(133, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(165, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fri";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(199, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sat";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_1
            // 
            this.lbl1_1.BackColor = System.Drawing.Color.White;
            this.lbl1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_1.Location = new System.Drawing.Point(5, 20);
            this.lbl1_1.Name = "lbl1_1";
            this.lbl1_1.Size = new System.Drawing.Size(35, 20);
            this.lbl1_1.TabIndex = 0;
            this.lbl1_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_2
            // 
            this.lbl1_2.BackColor = System.Drawing.Color.White;
            this.lbl1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_2.Location = new System.Drawing.Point(37, 20);
            this.lbl1_2.Name = "lbl1_2";
            this.lbl1_2.Size = new System.Drawing.Size(35, 20);
            this.lbl1_2.TabIndex = 0;
            this.lbl1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_5
            // 
            this.lbl1_5.BackColor = System.Drawing.Color.White;
            this.lbl1_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_5.Location = new System.Drawing.Point(133, 20);
            this.lbl1_5.Name = "lbl1_5";
            this.lbl1_5.Size = new System.Drawing.Size(35, 20);
            this.lbl1_5.TabIndex = 0;
            this.lbl1_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_6
            // 
            this.lbl1_6.BackColor = System.Drawing.Color.White;
            this.lbl1_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_6.Location = new System.Drawing.Point(165, 20);
            this.lbl1_6.Name = "lbl1_6";
            this.lbl1_6.Size = new System.Drawing.Size(35, 20);
            this.lbl1_6.TabIndex = 0;
            this.lbl1_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_3
            // 
            this.lbl1_3.BackColor = System.Drawing.Color.White;
            this.lbl1_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_3.Location = new System.Drawing.Point(69, 20);
            this.lbl1_3.Name = "lbl1_3";
            this.lbl1_3.Size = new System.Drawing.Size(35, 20);
            this.lbl1_3.TabIndex = 0;
            this.lbl1_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_7
            // 
            this.lbl1_7.BackColor = System.Drawing.Color.White;
            this.lbl1_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_7.Location = new System.Drawing.Point(199, 20);
            this.lbl1_7.Name = "lbl1_7";
            this.lbl1_7.Size = new System.Drawing.Size(35, 20);
            this.lbl1_7.TabIndex = 0;
            this.lbl1_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_4
            // 
            this.lbl1_4.BackColor = System.Drawing.Color.White;
            this.lbl1_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_4.Location = new System.Drawing.Point(101, 20);
            this.lbl1_4.Name = "lbl1_4";
            this.lbl1_4.Size = new System.Drawing.Size(35, 20);
            this.lbl1_4.TabIndex = 0;
            this.lbl1_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_4
            // 
            this.lbl2_4.BackColor = System.Drawing.Color.White;
            this.lbl2_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_4.Location = new System.Drawing.Point(101, 39);
            this.lbl2_4.Name = "lbl2_4";
            this.lbl2_4.Size = new System.Drawing.Size(35, 20);
            this.lbl2_4.TabIndex = 8;
            this.lbl2_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_7
            // 
            this.lbl2_7.BackColor = System.Drawing.Color.White;
            this.lbl2_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_7.Location = new System.Drawing.Point(199, 39);
            this.lbl2_7.Name = "lbl2_7";
            this.lbl2_7.Size = new System.Drawing.Size(35, 20);
            this.lbl2_7.TabIndex = 9;
            this.lbl2_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_3
            // 
            this.lbl2_3.BackColor = System.Drawing.Color.White;
            this.lbl2_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_3.Location = new System.Drawing.Point(69, 39);
            this.lbl2_3.Name = "lbl2_3";
            this.lbl2_3.Size = new System.Drawing.Size(35, 20);
            this.lbl2_3.TabIndex = 10;
            this.lbl2_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_6
            // 
            this.lbl2_6.BackColor = System.Drawing.Color.White;
            this.lbl2_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_6.Location = new System.Drawing.Point(165, 39);
            this.lbl2_6.Name = "lbl2_6";
            this.lbl2_6.Size = new System.Drawing.Size(35, 20);
            this.lbl2_6.TabIndex = 11;
            this.lbl2_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_5
            // 
            this.lbl2_5.BackColor = System.Drawing.Color.White;
            this.lbl2_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_5.Location = new System.Drawing.Point(133, 39);
            this.lbl2_5.Name = "lbl2_5";
            this.lbl2_5.Size = new System.Drawing.Size(35, 20);
            this.lbl2_5.TabIndex = 12;
            this.lbl2_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_2
            // 
            this.lbl2_2.BackColor = System.Drawing.Color.White;
            this.lbl2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_2.Location = new System.Drawing.Point(37, 39);
            this.lbl2_2.Name = "lbl2_2";
            this.lbl2_2.Size = new System.Drawing.Size(35, 20);
            this.lbl2_2.TabIndex = 13;
            this.lbl2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_1
            // 
            this.lbl2_1.BackColor = System.Drawing.Color.White;
            this.lbl2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_1.Location = new System.Drawing.Point(5, 39);
            this.lbl2_1.Name = "lbl2_1";
            this.lbl2_1.Size = new System.Drawing.Size(35, 20);
            this.lbl2_1.TabIndex = 14;
            this.lbl2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_4
            // 
            this.lbl3_4.BackColor = System.Drawing.Color.White;
            this.lbl3_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_4.Location = new System.Drawing.Point(101, 58);
            this.lbl3_4.Name = "lbl3_4";
            this.lbl3_4.Size = new System.Drawing.Size(35, 20);
            this.lbl3_4.TabIndex = 15;
            this.lbl3_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_7
            // 
            this.lbl3_7.BackColor = System.Drawing.Color.White;
            this.lbl3_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_7.Location = new System.Drawing.Point(199, 58);
            this.lbl3_7.Name = "lbl3_7";
            this.lbl3_7.Size = new System.Drawing.Size(35, 20);
            this.lbl3_7.TabIndex = 16;
            this.lbl3_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_3
            // 
            this.lbl3_3.BackColor = System.Drawing.Color.White;
            this.lbl3_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_3.Location = new System.Drawing.Point(69, 58);
            this.lbl3_3.Name = "lbl3_3";
            this.lbl3_3.Size = new System.Drawing.Size(35, 20);
            this.lbl3_3.TabIndex = 17;
            this.lbl3_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_6
            // 
            this.lbl3_6.BackColor = System.Drawing.Color.White;
            this.lbl3_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_6.Location = new System.Drawing.Point(165, 58);
            this.lbl3_6.Name = "lbl3_6";
            this.lbl3_6.Size = new System.Drawing.Size(35, 20);
            this.lbl3_6.TabIndex = 18;
            this.lbl3_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_5
            // 
            this.lbl3_5.BackColor = System.Drawing.Color.White;
            this.lbl3_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_5.Location = new System.Drawing.Point(133, 58);
            this.lbl3_5.Name = "lbl3_5";
            this.lbl3_5.Size = new System.Drawing.Size(35, 20);
            this.lbl3_5.TabIndex = 19;
            this.lbl3_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_2
            // 
            this.lbl3_2.BackColor = System.Drawing.Color.White;
            this.lbl3_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_2.Location = new System.Drawing.Point(37, 58);
            this.lbl3_2.Name = "lbl3_2";
            this.lbl3_2.Size = new System.Drawing.Size(35, 20);
            this.lbl3_2.TabIndex = 20;
            this.lbl3_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_1
            // 
            this.lbl3_1.BackColor = System.Drawing.Color.White;
            this.lbl3_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_1.Location = new System.Drawing.Point(5, 58);
            this.lbl3_1.Name = "lbl3_1";
            this.lbl3_1.Size = new System.Drawing.Size(35, 20);
            this.lbl3_1.TabIndex = 21;
            this.lbl3_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_4
            // 
            this.lbl4_4.BackColor = System.Drawing.Color.White;
            this.lbl4_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_4.Location = new System.Drawing.Point(101, 77);
            this.lbl4_4.Name = "lbl4_4";
            this.lbl4_4.Size = new System.Drawing.Size(35, 20);
            this.lbl4_4.TabIndex = 22;
            this.lbl4_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_7
            // 
            this.lbl4_7.BackColor = System.Drawing.Color.White;
            this.lbl4_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_7.Location = new System.Drawing.Point(199, 77);
            this.lbl4_7.Name = "lbl4_7";
            this.lbl4_7.Size = new System.Drawing.Size(35, 20);
            this.lbl4_7.TabIndex = 23;
            this.lbl4_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_3
            // 
            this.lbl4_3.BackColor = System.Drawing.Color.White;
            this.lbl4_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_3.Location = new System.Drawing.Point(69, 77);
            this.lbl4_3.Name = "lbl4_3";
            this.lbl4_3.Size = new System.Drawing.Size(35, 20);
            this.lbl4_3.TabIndex = 24;
            this.lbl4_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_6
            // 
            this.lbl4_6.BackColor = System.Drawing.Color.White;
            this.lbl4_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_6.Location = new System.Drawing.Point(165, 77);
            this.lbl4_6.Name = "lbl4_6";
            this.lbl4_6.Size = new System.Drawing.Size(35, 20);
            this.lbl4_6.TabIndex = 25;
            this.lbl4_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_5
            // 
            this.lbl4_5.BackColor = System.Drawing.Color.White;
            this.lbl4_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_5.Location = new System.Drawing.Point(133, 77);
            this.lbl4_5.Name = "lbl4_5";
            this.lbl4_5.Size = new System.Drawing.Size(35, 20);
            this.lbl4_5.TabIndex = 26;
            this.lbl4_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_2
            // 
            this.lbl4_2.BackColor = System.Drawing.Color.White;
            this.lbl4_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_2.Location = new System.Drawing.Point(37, 77);
            this.lbl4_2.Name = "lbl4_2";
            this.lbl4_2.Size = new System.Drawing.Size(35, 20);
            this.lbl4_2.TabIndex = 27;
            this.lbl4_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_1
            // 
            this.lbl4_1.BackColor = System.Drawing.Color.White;
            this.lbl4_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_1.Location = new System.Drawing.Point(5, 77);
            this.lbl4_1.Name = "lbl4_1";
            this.lbl4_1.Size = new System.Drawing.Size(35, 20);
            this.lbl4_1.TabIndex = 28;
            this.lbl4_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_4
            // 
            this.lbl5_4.BackColor = System.Drawing.Color.White;
            this.lbl5_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_4.Location = new System.Drawing.Point(101, 96);
            this.lbl5_4.Name = "lbl5_4";
            this.lbl5_4.Size = new System.Drawing.Size(35, 20);
            this.lbl5_4.TabIndex = 29;
            this.lbl5_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_7
            // 
            this.lbl5_7.BackColor = System.Drawing.Color.White;
            this.lbl5_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_7.Location = new System.Drawing.Point(199, 96);
            this.lbl5_7.Name = "lbl5_7";
            this.lbl5_7.Size = new System.Drawing.Size(35, 20);
            this.lbl5_7.TabIndex = 30;
            this.lbl5_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_3
            // 
            this.lbl5_3.BackColor = System.Drawing.Color.White;
            this.lbl5_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_3.Location = new System.Drawing.Point(69, 96);
            this.lbl5_3.Name = "lbl5_3";
            this.lbl5_3.Size = new System.Drawing.Size(35, 20);
            this.lbl5_3.TabIndex = 31;
            this.lbl5_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_6
            // 
            this.lbl5_6.BackColor = System.Drawing.Color.White;
            this.lbl5_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_6.Location = new System.Drawing.Point(165, 96);
            this.lbl5_6.Name = "lbl5_6";
            this.lbl5_6.Size = new System.Drawing.Size(35, 20);
            this.lbl5_6.TabIndex = 32;
            this.lbl5_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_5
            // 
            this.lbl5_5.BackColor = System.Drawing.Color.White;
            this.lbl5_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_5.Location = new System.Drawing.Point(133, 96);
            this.lbl5_5.Name = "lbl5_5";
            this.lbl5_5.Size = new System.Drawing.Size(35, 20);
            this.lbl5_5.TabIndex = 33;
            this.lbl5_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_2
            // 
            this.lbl5_2.BackColor = System.Drawing.Color.White;
            this.lbl5_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_2.Location = new System.Drawing.Point(37, 96);
            this.lbl5_2.Name = "lbl5_2";
            this.lbl5_2.Size = new System.Drawing.Size(35, 20);
            this.lbl5_2.TabIndex = 34;
            this.lbl5_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_1
            // 
            this.lbl5_1.BackColor = System.Drawing.Color.White;
            this.lbl5_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_1.Location = new System.Drawing.Point(5, 96);
            this.lbl5_1.Name = "lbl5_1";
            this.lbl5_1.Size = new System.Drawing.Size(35, 20);
            this.lbl5_1.TabIndex = 35;
            this.lbl5_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6_4
            // 
            this.lbl6_4.BackColor = System.Drawing.Color.White;
            this.lbl6_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl6_4.Location = new System.Drawing.Point(101, 115);
            this.lbl6_4.Name = "lbl6_4";
            this.lbl6_4.Size = new System.Drawing.Size(35, 20);
            this.lbl6_4.TabIndex = 36;
            this.lbl6_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6_7
            // 
            this.lbl6_7.BackColor = System.Drawing.Color.White;
            this.lbl6_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl6_7.Location = new System.Drawing.Point(199, 115);
            this.lbl6_7.Name = "lbl6_7";
            this.lbl6_7.Size = new System.Drawing.Size(35, 20);
            this.lbl6_7.TabIndex = 37;
            this.lbl6_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6_3
            // 
            this.lbl6_3.BackColor = System.Drawing.Color.White;
            this.lbl6_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl6_3.Location = new System.Drawing.Point(69, 115);
            this.lbl6_3.Name = "lbl6_3";
            this.lbl6_3.Size = new System.Drawing.Size(35, 20);
            this.lbl6_3.TabIndex = 38;
            this.lbl6_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6_6
            // 
            this.lbl6_6.BackColor = System.Drawing.Color.White;
            this.lbl6_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl6_6.Location = new System.Drawing.Point(165, 115);
            this.lbl6_6.Name = "lbl6_6";
            this.lbl6_6.Size = new System.Drawing.Size(35, 20);
            this.lbl6_6.TabIndex = 39;
            this.lbl6_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6_5
            // 
            this.lbl6_5.BackColor = System.Drawing.Color.White;
            this.lbl6_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl6_5.Location = new System.Drawing.Point(133, 115);
            this.lbl6_5.Name = "lbl6_5";
            this.lbl6_5.Size = new System.Drawing.Size(35, 20);
            this.lbl6_5.TabIndex = 40;
            this.lbl6_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6_2
            // 
            this.lbl6_2.BackColor = System.Drawing.Color.White;
            this.lbl6_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl6_2.Location = new System.Drawing.Point(37, 115);
            this.lbl6_2.Name = "lbl6_2";
            this.lbl6_2.Size = new System.Drawing.Size(35, 20);
            this.lbl6_2.TabIndex = 41;
            this.lbl6_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6_1
            // 
            this.lbl6_1.BackColor = System.Drawing.Color.White;
            this.lbl6_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl6_1.Location = new System.Drawing.Point(5, 115);
            this.lbl6_1.Name = "lbl6_1";
            this.lbl6_1.Size = new System.Drawing.Size(35, 20);
            this.lbl6_1.TabIndex = 42;
            this.lbl6_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalendarForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl1_4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl1_7;
        private System.Windows.Forms.Label lbl1_3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl1_6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl1_5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl1_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl1_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl2_4;
        private System.Windows.Forms.Label lbl2_7;
        private System.Windows.Forms.Label lbl2_3;
        private System.Windows.Forms.Label lbl2_6;
        private System.Windows.Forms.Label lbl2_5;
        private System.Windows.Forms.Label lbl2_2;
        private System.Windows.Forms.Label lbl2_1;
        private System.Windows.Forms.Label lbl3_4;
        private System.Windows.Forms.Label lbl3_7;
        private System.Windows.Forms.Label lbl3_3;
        private System.Windows.Forms.Label lbl3_6;
        private System.Windows.Forms.Label lbl3_5;
        private System.Windows.Forms.Label lbl3_2;
        private System.Windows.Forms.Label lbl3_1;
        private System.Windows.Forms.Label lbl4_4;
        private System.Windows.Forms.Label lbl4_7;
        private System.Windows.Forms.Label lbl4_3;
        private System.Windows.Forms.Label lbl4_6;
        private System.Windows.Forms.Label lbl4_5;
        private System.Windows.Forms.Label lbl4_2;
        private System.Windows.Forms.Label lbl4_1;
        private System.Windows.Forms.Label lbl5_4;
        private System.Windows.Forms.Label lbl5_7;
        private System.Windows.Forms.Label lbl5_3;
        private System.Windows.Forms.Label lbl5_6;
        private System.Windows.Forms.Label lbl5_5;
        private System.Windows.Forms.Label lbl5_2;
        private System.Windows.Forms.Label lbl5_1;
        private System.Windows.Forms.Label lbl6_4;
        private System.Windows.Forms.Label lbl6_7;
        private System.Windows.Forms.Label lbl6_3;
        private System.Windows.Forms.Label lbl6_6;
        private System.Windows.Forms.Label lbl6_5;
        private System.Windows.Forms.Label lbl6_2;
        private System.Windows.Forms.Label lbl6_1;
    }
}