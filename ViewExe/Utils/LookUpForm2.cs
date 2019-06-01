using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MVCHIS.Common {
    public partial class LookUpForm2 : Form {

        DataTable source;
        private int[] columnsWidths;

        public bool ValueHasBeenSelected => listView1.SelectedIndices.Count > 0;

        public LookUpForm2() {
            InitializeComponent();
            //this.values = new Dictionary<string, string>();
        }

        public int SelectedValueIndex       { get; set; }

        public string SearchText {
            set {
                this.lblSearch.Text = value;
            }
        }

        //private IDBController Controller;
        private string[] shownColumns;

        
        public LookUpForm2(DataTable data,params string[]shownColumns) {
            InitializeComponent();
            this.listView1.Columns.Clear();
            this.listView1.Items.Clear();
            this.shownColumns = shownColumns;
            //Controller = controller;
            source = data;
            listView1.Columns.AddRange((from c in shownColumns select new ColumnHeader(c) { Text = c }).ToArray());
        }

        public string SelectedValue => ValueHasBeenSelected == false ? null : (SelectedValueIndex==0 ?  this.listView1.SelectedItems[0].Text : this.listView1.SelectedItems[0].SubItems[SelectedValueIndex].Text);

        private void LookUpLoad(object sender, EventArgs e) { if (DesignMode) return;
            //this.lblSearch.Text = "";
            Requery();
            listView1.Select();
            listView1.Focus();
        }

        public void Requery() {
            
            if (source.Rows.Count == 0) {
                //this.lblRowHeader.Text = "Empty resultset !!!";
                listView1.Items.Clear();
                return;
            }
            if (shownColumns == null || shownColumns.Length == 0) {
                shownColumns = (from DataColumn column in source.Columns select column.ColumnName).ToArray();
            }
            
            var view = new DataView(source);
            try {
                view.RowFilter = string.Format("{0} Like '{1}%'", shownColumns[0], this.lblSearch.Text);
                view.Sort = $"{shownColumns[0]} ASC";
            } catch { }
            
            var table = view.ToTable(false, shownColumns);
            listView1.Items.Clear();
            foreach (DataRow row in table.Rows) {
                var item = new ListViewItem(row[0].ToString());
                for(int i = 1; i < shownColumns.Length; i++) {
                    item.SubItems.Add(row[i].ToString());
                }
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            if (listView1.Columns.Count > 0) {
                listView1.Columns[listView1.Columns.Count-1].Width -= 5;
            }
            if (listView1.Items.Count > 0) {
                listView1.Items[0].Selected = true;
                listView1.Select();
                listView1.Focus();
            }
        }

        private void LookUpKeyDown(object sender, KeyEventArgs e) {

        }

        private void ListView1KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Back:
                    if (this.lblSearch.Text.Length > 0) {
                        this.lblSearch.Text = this.lblSearch.Text.Substring(0, this.lblSearch.Text.Length - 1);
                    }
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    if (this.listView1.SelectedIndices.Count > 0) this.DialogResult = DialogResult.OK;
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
        public void ListView1KeyPress(object sender, KeyPressEventArgs e) {
            this.lblSearch.Text += e.KeyChar;
            e.Handled = true;
            
        }

        private void DataGridView1KeyUp(object sender, KeyEventArgs e) {
        }

        private void Label1TextChanged(object sender, EventArgs e) {
            Requery();
        }


        private void ListView1_DoubleClick(object sender, EventArgs e) {
            this.ListView1KeyDown(sender, new KeyEventArgs(Keys.Enter));
        }
    }
}
