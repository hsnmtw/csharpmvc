using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MVCHIS.Common {
    public partial class LookUpForm2 : Form {

        DataTable source;
        private int[] columnsWidths;

        public bool ValueHasBeenSelected => listView1.SelectedIndices.Count > 0;

        public LookUpForm2() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
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

        public LookUpForm2(DataTable data,params string[]shownColumns) : this() {
            this.listView1.Columns.Clear();
            this.listView1.Items.Clear();
            this.shownColumns = shownColumns;
            //Controller = controller;
            source = data;
            //listView1.Columns.AddRange((from c in shownColumns select new ColumnHeader(c) { Text = c }).ToArray());
            listView1.LoadFKs(shownColumns);
        }



        public string SelectedValue => ValueHasBeenSelected == false ? null : (SelectedValueIndex==0 ?  this.listView1.SelectedItems[0].Text : this.listView1.SelectedItems[0].SubItems[SelectedValueIndex].Text);

        private void LookUpLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //this.lblSearch.Text = "";
            if (0 == Interlocked.Exchange(ref listView1.LoadingFKs, 1)) {
                Requery();
            } else {
                listView1.LoadFKCompleted += Requery;
            }
            listView1.Select();
            listView1.Focus();
        }

        public void Requery() {
            listView1.LoadData(lblSearch.Text, source, shownColumns);
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
