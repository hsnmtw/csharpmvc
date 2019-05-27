using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MVCWinform.Common {
    public partial class LookUpForm : Form {

        //private Dictionary<string, string> values;
        private int[] columnsWidths;
        
        public LookUpForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            //this.values = new Dictionary<string, string>();
        }

        public int SelectedValueIndex       { get; set; }
        public int SelectedDescriptionIndex { get; set; }

        public string SearchText {
            set {
                this.lblSearch.Text = value;
            }
        }

        private IDBController Controller;
        private string[] shownColumns;

        
        public LookUpForm(IDBController controller,params string[]shownColumns) {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            //this.values = new Dictionary<string, string>();
            this.shownColumns = shownColumns;
            this.Controller = controller;
        }

        public string SelectedValue => this.listBox1.SelectedIndex < 0 ? null : this.listBox1.Text.Split('|')[SelectedValueIndex];
        public string SelectedDescription => this.listBox1.SelectedIndex < 0? null : this.listBox1.Text.Split('|')[SelectedDescriptionIndex];

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
            var source = this.Controller.ConvertToDataTable(this.Controller.Read(model,true,shownColumns[0]));
            if (source.Rows.Count == 0) {
                this.lblRowHeader.Text = "Empty resultset !!!";
                listBox1.Items.Clear();
                return;
            }
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


            //var sb = new StringBuilder();

            string[] sb = new string[columnsWidths.Length];

            for (int j = 0; j < table.Columns.Count; j++) {
                sb[j] = string.Format(string.Join(""," {0,-" ,columnsWidths[j] ,"} "), table.Columns[j].ColumnName);
            }
            this.lblRowHeader.Text = string.Join("|",sb);

            this.listBox1.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++) {
                //sb = new StringBuilder();
                for (int j = 0; j < table.Columns.Count; j++) {
                    sb[j] = (string.Format(" {0,-"+ columnsWidths[j] +"} ", table.Rows[i][j]));
                }
                //values[$"{table.Rows[i][SelectedValueIndex]}"] = $"{table.Rows[i][table.Columns.Count > 1 ? 1 : 0]}";
                this.listBox1.Items.Add(string.Join("|", sb));
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
