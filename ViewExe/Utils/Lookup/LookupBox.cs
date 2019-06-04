using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MVCHIS.Common {
    public partial class LookupBox : Form {

        private DataTable source;// = new DataTable();
        public bool ValueHasBeenSelected => listView1.SelectedIndices.Count > 0;

        public LookupBox() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }


        public string SearchText {
            set {
                this.lblSearch.Text = value;
            }
        }

        public LookupBox(string datasource,DataTable data) : this() {
            this.listView1.Columns.Clear();
            this.listView1.Items.Clear();
            this.Text = $"LookUp : [{datasource}]";
            this.source = data;
        }

        public string SelectedValue => ValueHasBeenSelected == false ? null : this.listView1.SelectedItems[0].Text;

        private void LookUpLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //this.lblSearch.Text = "";
            Requery();
            listView1.Select();
            listView1.Focus();
        }

        public void Requery() {
            listView1.LoadData(lblSearch.Text, source,"Key","Value");
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

        private void Label1TextChanged(object sender, EventArgs e) {
            Requery();
        }

        private void ListView1_DoubleClick(object sender, EventArgs e) {
            this.ListView1KeyDown(sender, new KeyEventArgs(Keys.Enter));
        }
    }
}
