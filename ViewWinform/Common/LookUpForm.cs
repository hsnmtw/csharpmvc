using ControllerLibrary.Common;
using System;
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

        private Dictionary<string, string> values;
        private int[] columnsWidths;
        
        public LookUpForm() {
            InitializeComponent(); if (DesignMode) return;
            this.values = new Dictionary<string, string>();
        }

        public string SearchText {
            set {
                this.lblSearch.Text = value;
            }
        }

        private IDBController Controller;
        private string[] shownColumns;

        
        public LookUpForm(IDBController controller,params string[]shownColumns) {
            InitializeComponent(); if (DesignMode) return;
            this.values = new Dictionary<string, string>();
            this.shownColumns = shownColumns;
            this.Controller = controller;
        }

        public string SelectedValue {
            get {
                if (this.listBox1.SelectedIndex < 0) return null;
                string selected = $"{this.listBox1.SelectedItem}".Trim();
                selected = selected.Substring(0, Math.Min(selected.Length, columnsWidths[0])).Trim();
                return selected;
            }
        }

        public string SelectedDescription => this.listBox1.SelectedIndex < 0? null : values[SelectedValue];

        private void LookUpLoad(object sender, EventArgs e) {
            //this.lblSearch.Text = "";
            Requery();
            listBox1.Select();
            listBox1.Focus();
        }

        private bool columnsInitialized { get; set; }

        public void Requery() {
            object model = this.Controller.CreateNewModel();
            model.GetType().GetProperty(shownColumns[0]).SetValue(model, $"%{lblSearch.Text}%");
            var source = this.Controller.GetTable(model,new string[] {shownColumns[0]},true);
            
            if (shownColumns == null || shownColumns.Length == 0) {
                shownColumns = (from DataColumn column in source.Columns select column.ColumnName).ToArray();
            }

            DataView view = new DataView(source);
            view.Sort = $"{shownColumns[0]} ASC";


            var table = view.ToTable(false, shownColumns);
            if (!columnsInitialized) {
                this.columnsWidths = new int[shownColumns.Length];
                for (int j = 0; j < table.Columns.Count; j++) {
                    this.columnsWidths[j] = Math.Max(this.columnsWidths[j], table.Columns[j].ColumnName.Length);
                }
                for (int i = 0; i < table.Rows.Count; i++) {
                    for (int j = 0; j < table.Columns.Count; j++) {
                        this.columnsWidths[j] = Math.Max(this.columnsWidths[j], table.Rows[i][j].ToString().Length);
                    }
                    
                }
                columnsInitialized = true;
            }


            var sb = new StringBuilder();
            for (int j = 0; j < table.Columns.Count; j++) {
                sb.Append(string.Format(" {0,-" + columnsWidths[j] + "}  ", table.Columns[j].ColumnName));
            }
            this.lblRowHeader.Text = sb.ToString();

            this.listBox1.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++) {
                sb = new StringBuilder();
                for (int j = 0; j < table.Columns.Count; j++) {
                    sb.Append(string.Format(" {0,-"+ columnsWidths[j] +"}  ", table.Rows[i][j]));
                }
                values[$"{table.Rows[i][0]}"] = $"{table.Rows[i][table.Columns.Count > 1 ? 1 : 0]}";
                this.listBox1.Items.Add(sb);
            }
            if (this.listBox1.Items.Count > 0) this.listBox1.SelectedIndex = 0;
        }

        private void LookUpKeyDown(object sender, KeyEventArgs e) {

        }

        private void DataGridView1KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Back:
                    if (this.lblSearch.Text.Length > 0) {
                        this.lblSearch.Text = this.lblSearch.Text.Substring(0, this.lblSearch.Text.Length - 1);
                    }
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    if (this.listBox1.SelectedIndex > -1) this.DialogResult = DialogResult.OK;
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
        public void DataGridView1KeyPress(object sender, KeyPressEventArgs e) {
            this.lblSearch.Text += e.KeyChar;
            
        }

        private void DataGridView1KeyUp(object sender, KeyEventArgs e) {
        }

        private void Label1TextChanged(object sender, EventArgs e) {
            //(this.dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} Like '%{1}%'", this.dataGridView1.Columns[0].Name, this.label1.Text);
            Requery();
        }

        private void DataGridView1DoubleClick(object sender, EventArgs e) {
            this.DataGridView1KeyDown(sender, new KeyEventArgs(Keys.Enter));
        }
    }
}
