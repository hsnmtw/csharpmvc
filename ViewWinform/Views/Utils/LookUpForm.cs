using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MVCWinform.Common {
    public partial class LookUpForm : Form {
        
        public LookUpForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
        }

        public int SelectedValueIndex       { get; set; }
        public int SelectedDescriptionIndex { get; set; }

        public string SearchText {
            set {
                this.lblSearch.Text = value;
            }
        }

        private string[] shownColumns;

        
        public LookUpForm(DataTable data,params string[]shownColumns) {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            this.shownColumns = shownColumns;
            lstView.ShownColumns = shownColumns.ToList();
            lstView.DataSource = data;
            lstView.Requery();
        }

        public string SelectedValue => lstView.SelectedIndex < 0 ? null : lstView.Text.Split('|')[SelectedValueIndex];
        public string SelectedDescription => lstView.SelectedIndex < 0 ? null : lstView.Text.Split('|')[SelectedDescriptionIndex];

        private void LookUpLoad(object sender, EventArgs e) {
        }

     
        private void LookUpKeyDown(object sender, KeyEventArgs e) {
        }

        private void Label1TextChanged(object sender, EventArgs e) {
            if (shownColumns == null || shownColumns.Length == 0) return;
            lstView.Filter = string.Format("{0} Like '%{1}%'", shownColumns[0], this.lblSearch.Text);
            lstView.Requery();
        }

        private void LstView_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Back:
                    if (this.lblSearch.Text.Length > 0) {
                        this.lblSearch.Text = this.lblSearch.Text.Substring(0, this.lblSearch.Text.Length - 1);
                    }
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    if (this.lstView.Text.Length>0) this.DialogResult = DialogResult.OK;
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

        private void LstView_KeyPress(object sender, KeyPressEventArgs e) {
            this.lblSearch.Text += e.KeyChar;
        }
    }
}
