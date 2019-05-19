﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinform.Common {
    public partial class LookUpForm : Form {

        public LookUpForm() {
            InitializeComponent();
        }

        public LookUpForm(DataTable source,params string[]shownColumns) {
            InitializeComponent();
            if(shownColumns==null || shownColumns.Length == 0) {
                shownColumns = (from DataColumn column in source.Columns select column.ColumnName).ToArray();
            }
            DataView dv = new DataView(source);
            dv.Sort = string.Format("{0} ASC", shownColumns[0]);
            this.dataGridView1.DataSource = dv.ToTable(false,shownColumns);
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public string[] SelectedValue {
            get {
                if (this.dataGridView1.SelectedRows.Count > 0) {
                    return (from DataGridViewCell cell
                              in this.dataGridView1.SelectedRows[0].Cells
                          select cell.Value.ToString()).ToArray();
                }
                return new string[this.dataGridView1.ColumnCount];
            }
        }

        private void LookUp_Load(object sender, EventArgs e) {
            this.label1.Text = "";
        }

        private void LookUp_KeyDown(object sender, KeyEventArgs e) {

        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Back:
                    if (this.label1.Text.Length > 0) {
                        this.label1.Text = this.label1.Text.Substring(0, this.label1.Text.Length - 1);
                    }
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    if (this.dataGridView1.SelectedRows.Count > 0) this.DialogResult = DialogResult.OK;
                    this.Close();
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    break;
                case Keys.Escape:
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    break;
            }
            
        }
        private void DataGridView1_KeyPress(object sender, KeyPressEventArgs e) {
            this.label1.Text += e.KeyChar;
        }

        private void Label1_TextChanged(object sender, EventArgs e) {
            (this.dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} Like '%{1}%'", this.dataGridView1.Columns[0].Name, this.label1.Text);
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e) {
            this.DataGridView1_KeyDown(sender, new KeyEventArgs(Keys.Enter));
        }
    }
}