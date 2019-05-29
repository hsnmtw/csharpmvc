namespace MVCHIS.Tools {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbl0_4 = new System.Windows.Forms.Label();
            this.lbl0_0 = new System.Windows.Forms.Label();
            this.lbl0_3 = new System.Windows.Forms.Label();
            this.lbl0_6 = new System.Windows.Forms.Label();
            this.lbl0_5 = new System.Windows.Forms.Label();
            this.lbl0_2 = new System.Windows.Forms.Label();
            this.lbl0_1 = new System.Windows.Forms.Label();
            this.lbl5_4 = new System.Windows.Forms.Label();
            this.lbl5_0 = new System.Windows.Forms.Label();
            this.lbl5_3 = new System.Windows.Forms.Label();
            this.lbl5_6 = new System.Windows.Forms.Label();
            this.lbl5_5 = new System.Windows.Forms.Label();
            this.lbl5_2 = new System.Windows.Forms.Label();
            this.lbl5_1 = new System.Windows.Forms.Label();
            this.lbl4_4 = new System.Windows.Forms.Label();
            this.lbl4_0 = new System.Windows.Forms.Label();
            this.lbl4_3 = new System.Windows.Forms.Label();
            this.lbl4_6 = new System.Windows.Forms.Label();
            this.lbl4_5 = new System.Windows.Forms.Label();
            this.lbl4_2 = new System.Windows.Forms.Label();
            this.lbl4_1 = new System.Windows.Forms.Label();
            this.lbl3_4 = new System.Windows.Forms.Label();
            this.lbl3_0 = new System.Windows.Forms.Label();
            this.lbl3_3 = new System.Windows.Forms.Label();
            this.lbl3_6 = new System.Windows.Forms.Label();
            this.lbl3_5 = new System.Windows.Forms.Label();
            this.lbl3_2 = new System.Windows.Forms.Label();
            this.lbl3_1 = new System.Windows.Forms.Label();
            this.lbl2_4 = new System.Windows.Forms.Label();
            this.lbl2_0 = new System.Windows.Forms.Label();
            this.lbl2_3 = new System.Windows.Forms.Label();
            this.lbl2_6 = new System.Windows.Forms.Label();
            this.lbl2_5 = new System.Windows.Forms.Label();
            this.lbl2_2 = new System.Windows.Forms.Label();
            this.lbl2_1 = new System.Windows.Forms.Label();
            this.lbl1_4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl1_0 = new System.Windows.Forms.Label();
            this.lbl1_3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl1_6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl1_5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl1_2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl1_1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Month";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(52, 8);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(73, 21);
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
            this.cmbMonth.Location = new System.Drawing.Point(183, 8);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(57, 21);
            this.cmbMonth.TabIndex = 3;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.CmbYear_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(165, 186);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lbl0_4
            // 
            this.lbl0_4.BackColor = System.Drawing.Color.White;
            this.lbl0_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl0_4.Location = new System.Drawing.Point(146, 62);
            this.lbl0_4.Name = "lbl0_4";
            this.lbl0_4.Size = new System.Drawing.Size(33, 20);
            this.lbl0_4.TabIndex = 36;
            this.lbl0_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl0_0
            // 
            this.lbl0_0.BackColor = System.Drawing.Color.White;
            this.lbl0_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl0_0.Location = new System.Drawing.Point(18, 62);
            this.lbl0_0.Name = "lbl0_0";
            this.lbl0_0.Size = new System.Drawing.Size(33, 20);
            this.lbl0_0.TabIndex = 37;
            this.lbl0_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl0_3
            // 
            this.lbl0_3.BackColor = System.Drawing.Color.White;
            this.lbl0_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl0_3.Location = new System.Drawing.Point(114, 62);
            this.lbl0_3.Name = "lbl0_3";
            this.lbl0_3.Size = new System.Drawing.Size(33, 20);
            this.lbl0_3.TabIndex = 38;
            this.lbl0_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl0_6
            // 
            this.lbl0_6.BackColor = System.Drawing.Color.White;
            this.lbl0_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl0_6.Location = new System.Drawing.Point(210, 62);
            this.lbl0_6.Name = "lbl0_6";
            this.lbl0_6.Size = new System.Drawing.Size(33, 20);
            this.lbl0_6.TabIndex = 39;
            this.lbl0_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl0_5
            // 
            this.lbl0_5.BackColor = System.Drawing.Color.White;
            this.lbl0_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl0_5.Location = new System.Drawing.Point(178, 62);
            this.lbl0_5.Name = "lbl0_5";
            this.lbl0_5.Size = new System.Drawing.Size(33, 20);
            this.lbl0_5.TabIndex = 40;
            this.lbl0_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl0_2
            // 
            this.lbl0_2.BackColor = System.Drawing.Color.White;
            this.lbl0_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl0_2.Location = new System.Drawing.Point(82, 62);
            this.lbl0_2.Name = "lbl0_2";
            this.lbl0_2.Size = new System.Drawing.Size(33, 20);
            this.lbl0_2.TabIndex = 41;
            this.lbl0_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl0_1
            // 
            this.lbl0_1.BackColor = System.Drawing.Color.White;
            this.lbl0_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl0_1.Location = new System.Drawing.Point(50, 62);
            this.lbl0_1.Name = "lbl0_1";
            this.lbl0_1.Size = new System.Drawing.Size(33, 20);
            this.lbl0_1.TabIndex = 42;
            this.lbl0_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_4
            // 
            this.lbl5_4.BackColor = System.Drawing.Color.White;
            this.lbl5_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_4.Location = new System.Drawing.Point(146, 157);
            this.lbl5_4.Name = "lbl5_4";
            this.lbl5_4.Size = new System.Drawing.Size(33, 20);
            this.lbl5_4.TabIndex = 29;
            this.lbl5_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_0
            // 
            this.lbl5_0.BackColor = System.Drawing.Color.White;
            this.lbl5_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_0.Location = new System.Drawing.Point(18, 157);
            this.lbl5_0.Name = "lbl5_0";
            this.lbl5_0.Size = new System.Drawing.Size(33, 20);
            this.lbl5_0.TabIndex = 30;
            this.lbl5_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_3
            // 
            this.lbl5_3.BackColor = System.Drawing.Color.White;
            this.lbl5_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_3.Location = new System.Drawing.Point(114, 157);
            this.lbl5_3.Name = "lbl5_3";
            this.lbl5_3.Size = new System.Drawing.Size(33, 20);
            this.lbl5_3.TabIndex = 31;
            this.lbl5_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_6
            // 
            this.lbl5_6.BackColor = System.Drawing.Color.White;
            this.lbl5_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_6.Location = new System.Drawing.Point(210, 157);
            this.lbl5_6.Name = "lbl5_6";
            this.lbl5_6.Size = new System.Drawing.Size(33, 20);
            this.lbl5_6.TabIndex = 32;
            this.lbl5_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_5
            // 
            this.lbl5_5.BackColor = System.Drawing.Color.White;
            this.lbl5_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_5.Location = new System.Drawing.Point(178, 157);
            this.lbl5_5.Name = "lbl5_5";
            this.lbl5_5.Size = new System.Drawing.Size(33, 20);
            this.lbl5_5.TabIndex = 33;
            this.lbl5_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_2
            // 
            this.lbl5_2.BackColor = System.Drawing.Color.White;
            this.lbl5_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_2.Location = new System.Drawing.Point(82, 157);
            this.lbl5_2.Name = "lbl5_2";
            this.lbl5_2.Size = new System.Drawing.Size(33, 20);
            this.lbl5_2.TabIndex = 34;
            this.lbl5_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_1
            // 
            this.lbl5_1.BackColor = System.Drawing.Color.White;
            this.lbl5_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5_1.Location = new System.Drawing.Point(50, 157);
            this.lbl5_1.Name = "lbl5_1";
            this.lbl5_1.Size = new System.Drawing.Size(33, 20);
            this.lbl5_1.TabIndex = 35;
            this.lbl5_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_4
            // 
            this.lbl4_4.BackColor = System.Drawing.Color.White;
            this.lbl4_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_4.Location = new System.Drawing.Point(146, 138);
            this.lbl4_4.Name = "lbl4_4";
            this.lbl4_4.Size = new System.Drawing.Size(33, 20);
            this.lbl4_4.TabIndex = 22;
            this.lbl4_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_0
            // 
            this.lbl4_0.BackColor = System.Drawing.Color.White;
            this.lbl4_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_0.Location = new System.Drawing.Point(18, 138);
            this.lbl4_0.Name = "lbl4_0";
            this.lbl4_0.Size = new System.Drawing.Size(33, 20);
            this.lbl4_0.TabIndex = 23;
            this.lbl4_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_3
            // 
            this.lbl4_3.BackColor = System.Drawing.Color.White;
            this.lbl4_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_3.Location = new System.Drawing.Point(114, 138);
            this.lbl4_3.Name = "lbl4_3";
            this.lbl4_3.Size = new System.Drawing.Size(33, 20);
            this.lbl4_3.TabIndex = 24;
            this.lbl4_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_6
            // 
            this.lbl4_6.BackColor = System.Drawing.Color.White;
            this.lbl4_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_6.Location = new System.Drawing.Point(210, 138);
            this.lbl4_6.Name = "lbl4_6";
            this.lbl4_6.Size = new System.Drawing.Size(33, 20);
            this.lbl4_6.TabIndex = 25;
            this.lbl4_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_5
            // 
            this.lbl4_5.BackColor = System.Drawing.Color.White;
            this.lbl4_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_5.Location = new System.Drawing.Point(178, 138);
            this.lbl4_5.Name = "lbl4_5";
            this.lbl4_5.Size = new System.Drawing.Size(33, 20);
            this.lbl4_5.TabIndex = 26;
            this.lbl4_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_2
            // 
            this.lbl4_2.BackColor = System.Drawing.Color.White;
            this.lbl4_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_2.Location = new System.Drawing.Point(82, 138);
            this.lbl4_2.Name = "lbl4_2";
            this.lbl4_2.Size = new System.Drawing.Size(33, 20);
            this.lbl4_2.TabIndex = 27;
            this.lbl4_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4_1
            // 
            this.lbl4_1.BackColor = System.Drawing.Color.White;
            this.lbl4_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4_1.Location = new System.Drawing.Point(50, 138);
            this.lbl4_1.Name = "lbl4_1";
            this.lbl4_1.Size = new System.Drawing.Size(33, 20);
            this.lbl4_1.TabIndex = 28;
            this.lbl4_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_4
            // 
            this.lbl3_4.BackColor = System.Drawing.Color.White;
            this.lbl3_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_4.Location = new System.Drawing.Point(146, 119);
            this.lbl3_4.Name = "lbl3_4";
            this.lbl3_4.Size = new System.Drawing.Size(33, 20);
            this.lbl3_4.TabIndex = 15;
            this.lbl3_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_0
            // 
            this.lbl3_0.BackColor = System.Drawing.Color.White;
            this.lbl3_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_0.Location = new System.Drawing.Point(18, 119);
            this.lbl3_0.Name = "lbl3_0";
            this.lbl3_0.Size = new System.Drawing.Size(33, 20);
            this.lbl3_0.TabIndex = 16;
            this.lbl3_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_3
            // 
            this.lbl3_3.BackColor = System.Drawing.Color.White;
            this.lbl3_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_3.Location = new System.Drawing.Point(114, 119);
            this.lbl3_3.Name = "lbl3_3";
            this.lbl3_3.Size = new System.Drawing.Size(33, 20);
            this.lbl3_3.TabIndex = 17;
            this.lbl3_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_6
            // 
            this.lbl3_6.BackColor = System.Drawing.Color.White;
            this.lbl3_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_6.Location = new System.Drawing.Point(210, 119);
            this.lbl3_6.Name = "lbl3_6";
            this.lbl3_6.Size = new System.Drawing.Size(33, 20);
            this.lbl3_6.TabIndex = 18;
            this.lbl3_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_5
            // 
            this.lbl3_5.BackColor = System.Drawing.Color.White;
            this.lbl3_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_5.Location = new System.Drawing.Point(178, 119);
            this.lbl3_5.Name = "lbl3_5";
            this.lbl3_5.Size = new System.Drawing.Size(33, 20);
            this.lbl3_5.TabIndex = 19;
            this.lbl3_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_2
            // 
            this.lbl3_2.BackColor = System.Drawing.Color.White;
            this.lbl3_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_2.Location = new System.Drawing.Point(82, 119);
            this.lbl3_2.Name = "lbl3_2";
            this.lbl3_2.Size = new System.Drawing.Size(33, 20);
            this.lbl3_2.TabIndex = 20;
            this.lbl3_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3_1
            // 
            this.lbl3_1.BackColor = System.Drawing.Color.White;
            this.lbl3_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_1.Location = new System.Drawing.Point(50, 119);
            this.lbl3_1.Name = "lbl3_1";
            this.lbl3_1.Size = new System.Drawing.Size(33, 20);
            this.lbl3_1.TabIndex = 21;
            this.lbl3_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_4
            // 
            this.lbl2_4.BackColor = System.Drawing.Color.White;
            this.lbl2_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_4.Location = new System.Drawing.Point(146, 100);
            this.lbl2_4.Name = "lbl2_4";
            this.lbl2_4.Size = new System.Drawing.Size(33, 20);
            this.lbl2_4.TabIndex = 8;
            this.lbl2_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_0
            // 
            this.lbl2_0.BackColor = System.Drawing.Color.White;
            this.lbl2_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_0.Location = new System.Drawing.Point(18, 100);
            this.lbl2_0.Name = "lbl2_0";
            this.lbl2_0.Size = new System.Drawing.Size(33, 20);
            this.lbl2_0.TabIndex = 9;
            this.lbl2_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_3
            // 
            this.lbl2_3.BackColor = System.Drawing.Color.White;
            this.lbl2_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_3.Location = new System.Drawing.Point(114, 100);
            this.lbl2_3.Name = "lbl2_3";
            this.lbl2_3.Size = new System.Drawing.Size(33, 20);
            this.lbl2_3.TabIndex = 10;
            this.lbl2_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_6
            // 
            this.lbl2_6.BackColor = System.Drawing.Color.White;
            this.lbl2_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_6.Location = new System.Drawing.Point(210, 100);
            this.lbl2_6.Name = "lbl2_6";
            this.lbl2_6.Size = new System.Drawing.Size(33, 20);
            this.lbl2_6.TabIndex = 11;
            this.lbl2_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_5
            // 
            this.lbl2_5.BackColor = System.Drawing.Color.White;
            this.lbl2_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_5.Location = new System.Drawing.Point(178, 100);
            this.lbl2_5.Name = "lbl2_5";
            this.lbl2_5.Size = new System.Drawing.Size(33, 20);
            this.lbl2_5.TabIndex = 12;
            this.lbl2_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_2
            // 
            this.lbl2_2.BackColor = System.Drawing.Color.White;
            this.lbl2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_2.Location = new System.Drawing.Point(82, 100);
            this.lbl2_2.Name = "lbl2_2";
            this.lbl2_2.Size = new System.Drawing.Size(33, 20);
            this.lbl2_2.TabIndex = 13;
            this.lbl2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_1
            // 
            this.lbl2_1.BackColor = System.Drawing.Color.White;
            this.lbl2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_1.Location = new System.Drawing.Point(50, 100);
            this.lbl2_1.Name = "lbl2_1";
            this.lbl2_1.Size = new System.Drawing.Size(33, 20);
            this.lbl2_1.TabIndex = 14;
            this.lbl2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_4
            // 
            this.lbl1_4.BackColor = System.Drawing.Color.White;
            this.lbl1_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_4.Location = new System.Drawing.Point(146, 81);
            this.lbl1_4.Name = "lbl1_4";
            this.lbl1_4.Size = new System.Drawing.Size(33, 20);
            this.lbl1_4.TabIndex = 0;
            this.lbl1_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(114, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Wed";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_0
            // 
            this.lbl1_0.BackColor = System.Drawing.Color.White;
            this.lbl1_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_0.Location = new System.Drawing.Point(18, 81);
            this.lbl1_0.Name = "lbl1_0";
            this.lbl1_0.Size = new System.Drawing.Size(33, 20);
            this.lbl1_0.TabIndex = 0;
            this.lbl1_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_3
            // 
            this.lbl1_3.BackColor = System.Drawing.Color.White;
            this.lbl1_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_3.Location = new System.Drawing.Point(114, 81);
            this.lbl1_3.Name = "lbl1_3";
            this.lbl1_3.Size = new System.Drawing.Size(33, 20);
            this.lbl1_3.TabIndex = 0;
            this.lbl1_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(210, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sat";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_6
            // 
            this.lbl1_6.BackColor = System.Drawing.Color.White;
            this.lbl1_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_6.Location = new System.Drawing.Point(210, 81);
            this.lbl1_6.Name = "lbl1_6";
            this.lbl1_6.Size = new System.Drawing.Size(33, 20);
            this.lbl1_6.TabIndex = 0;
            this.lbl1_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(82, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tue";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_5
            // 
            this.lbl1_5.BackColor = System.Drawing.Color.White;
            this.lbl1_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_5.Location = new System.Drawing.Point(178, 81);
            this.lbl1_5.Name = "lbl1_5";
            this.lbl1_5.Size = new System.Drawing.Size(33, 20);
            this.lbl1_5.TabIndex = 0;
            this.lbl1_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(178, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fri";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_2
            // 
            this.lbl1_2.BackColor = System.Drawing.Color.White;
            this.lbl1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_2.Location = new System.Drawing.Point(82, 81);
            this.lbl1_2.Name = "lbl1_2";
            this.lbl1_2.Size = new System.Drawing.Size(33, 20);
            this.lbl1_2.TabIndex = 0;
            this.lbl1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(146, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1_1
            // 
            this.lbl1_1.BackColor = System.Drawing.Color.White;
            this.lbl1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_1.Location = new System.Drawing.Point(50, 81);
            this.lbl1_1.Name = "lbl1_1";
            this.lbl1_1.Size = new System.Drawing.Size(33, 20);
            this.lbl1_1.TabIndex = 0;
            this.lbl1_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(50, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mon";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(18, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sun";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalendarForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 221);
            this.Controls.Add(this.lbl0_4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl0_0);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lbl0_3);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lbl1_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl0_6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl3_6);
            this.Controls.Add(this.lbl0_5);
            this.Controls.Add(this.lbl3_5);
            this.Controls.Add(this.lbl1_2);
            this.Controls.Add(this.lbl3_3);
            this.Controls.Add(this.lbl0_2);
            this.Controls.Add(this.lbl3_2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl3_0);
            this.Controls.Add(this.lbl0_1);
            this.Controls.Add(this.lbl3_1);
            this.Controls.Add(this.lbl1_5);
            this.Controls.Add(this.lbl3_4);
            this.Controls.Add(this.lbl5_4);
            this.Controls.Add(this.lbl2_4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl4_1);
            this.Controls.Add(this.lbl5_0);
            this.Controls.Add(this.lbl2_0);
            this.Controls.Add(this.lbl1_6);
            this.Controls.Add(this.lbl4_2);
            this.Controls.Add(this.lbl5_3);
            this.Controls.Add(this.lbl2_3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl4_5);
            this.Controls.Add(this.lbl5_6);
            this.Controls.Add(this.lbl2_6);
            this.Controls.Add(this.lbl1_3);
            this.Controls.Add(this.lbl4_6);
            this.Controls.Add(this.lbl5_5);
            this.Controls.Add(this.lbl2_5);
            this.Controls.Add(this.lbl1_0);
            this.Controls.Add(this.lbl4_3);
            this.Controls.Add(this.lbl5_2);
            this.Controls.Add(this.lbl2_2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl4_0);
            this.Controls.Add(this.lbl5_1);
            this.Controls.Add(this.lbl2_1);
            this.Controls.Add(this.lbl1_4);
            this.Controls.Add(this.lbl4_4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbl1_4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl1_0;
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
        private System.Windows.Forms.Label lbl2_0;
        private System.Windows.Forms.Label lbl2_3;
        private System.Windows.Forms.Label lbl2_6;
        private System.Windows.Forms.Label lbl2_5;
        private System.Windows.Forms.Label lbl2_2;
        private System.Windows.Forms.Label lbl2_1;
        private System.Windows.Forms.Label lbl3_4;
        private System.Windows.Forms.Label lbl3_0;
        private System.Windows.Forms.Label lbl3_3;
        private System.Windows.Forms.Label lbl3_6;
        private System.Windows.Forms.Label lbl3_5;
        private System.Windows.Forms.Label lbl3_2;
        private System.Windows.Forms.Label lbl3_1;
        private System.Windows.Forms.Label lbl4_4;
        private System.Windows.Forms.Label lbl4_0;
        private System.Windows.Forms.Label lbl4_3;
        private System.Windows.Forms.Label lbl4_6;
        private System.Windows.Forms.Label lbl4_5;
        private System.Windows.Forms.Label lbl4_2;
        private System.Windows.Forms.Label lbl4_1;
        private System.Windows.Forms.Label lbl5_4;
        private System.Windows.Forms.Label lbl5_0;
        private System.Windows.Forms.Label lbl5_3;
        private System.Windows.Forms.Label lbl5_6;
        private System.Windows.Forms.Label lbl5_5;
        private System.Windows.Forms.Label lbl5_2;
        private System.Windows.Forms.Label lbl5_1;
        private System.Windows.Forms.Label lbl0_4;
        private System.Windows.Forms.Label lbl0_0;
        private System.Windows.Forms.Label lbl0_3;
        private System.Windows.Forms.Label lbl0_6;
        private System.Windows.Forms.Label lbl0_5;
        private System.Windows.Forms.Label lbl0_2;
        private System.Windows.Forms.Label lbl0_1;
    }
}