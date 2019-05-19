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

        
        
        public LookUpForm() {
            InitializeComponent();
        }

        private BaseController Controller;
        private string[] shownColumns;
        private int _page,_pages,_pagesize;
        public int Page {
            get => _page;
            private set {
                _page = value;
                
                tsbFirst.Enabled = tsbPrevious.Enabled = Page > 1;
                tsbLast.Enabled = tsbNext.Enabled = Page < Pages;
                this.tslRecordPosition.Text = $"{Page}/{Pages}";
            }
        }
        public int Pages {
            get => _pages;
            private set {
                _pages = value;
                tsbFirst.Enabled = tsbPrevious.Enabled = Page > 1;
                tsbLast.Enabled = tsbNext.Enabled = Page < Pages;
                this.tslRecordPosition.Text = $"{Page}/{Pages}";
            }
        }
        public int PageSize {
            get => _pagesize;
            set {
                _pagesize = value;
                this.tslPageSize.Text  = $"Page Size {value}";
            }
        }
        
        public LookUpForm(BaseController controller,params string[]shownColumns) {
            InitializeComponent();
            this.shownColumns = shownColumns;
            this.Controller = controller;
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
            if (this.PageSize <1) this.PageSize = 10;
            this.Page = 1;
            Requery();
        }

        public void Requery() {
            object model = this.Controller.CreateNewModel();
            model.GetType().GetProperty(shownColumns[0]).SetValue(model, $"%{label1.Text}%");
            var result = this.Controller.GetTable(model,new string[] {shownColumns[0]},true,this.Page,PageSize);
            var source = result.Table;

            if (shownColumns == null || shownColumns.Length == 0) {
                shownColumns = (from DataColumn column in source.Columns select column.ColumnName).ToArray();
            }


            //this.Pages = (result.RowsCount+ this.PageSize-1) / this.PageSize;

            this.Pages = result.Pages;
            this.Page = result.Page;
            this.PageSize = result.PageSize;
            this.tslRecordsCount.Text = $"Records {result.RowsCount}";

            DataView view = new DataView(source);
            view.Sort = $"{shownColumns[0]} ASC";

            this.dataGridView1.DataSource = view.ToTable(false,shownColumns);
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void TsbFirst_Click(object sender, EventArgs e) {
            Page = 1; Requery();
        }

        private void TsbPrevious_Click(object sender, EventArgs e) {
            Page--; Requery();
        }

        private void TsbNext_Click(object sender, EventArgs e) {
            Page++; Requery();
        }

        private void TsbLast_Click(object sender, EventArgs e) {
            Page = Pages; Requery();
        }

        private void DataGridView1_KeyUp(object sender, KeyEventArgs e) {
        }

        private void Label1_TextChanged(object sender, EventArgs e) {
            //(this.dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} Like '%{1}%'", this.dataGridView1.Columns[0].Name, this.label1.Text);
            if(PageSize>0)
            TsbFirst_Click(null, null);
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e) {
            this.DataGridView1_KeyDown(sender, new KeyEventArgs(Keys.Enter));
        }
    }
}
