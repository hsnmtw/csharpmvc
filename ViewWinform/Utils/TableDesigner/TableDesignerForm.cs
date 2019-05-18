using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelLibrary.Utils.TableDesigner {
    public partial class TableDesignerForm : UserControl {
        public TableDesignerForm() {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e) {
            generateSQL();
        }
        public void generateSQL() { 
            string FIELDS = string.Join(",\r\n", (
                              from row
                                in dataGridView1.Rows.Cast<DataGridViewRow>()
                             where !"".Equals(row.Cells[0].Value ?? "") 
                                //name,type,size,required,key
                            select string.Format("{0}\t{1}\t{2}\t{3}\t{4}",
                                    row.Cells[0].Value,
                                    row.Cells[1].Value,
                                    "".Equals(row.Cells[2].Value ?? "") ? null : string.Format("({0})", row.Cells[2].Value),
                                    bool.Parse(row.Cells[3].Value.ToString()) ? "NOT NULL" : "",
                                    row.Cells[4].Value)));

            this.textBox2.Text = string.Format( "CREATE TABLE {0} (\r\n{1}\r\n);",this.textBox1.Text,FIELDS).Replace("\t()\t","\t \t") ;

            this.tabControl1.SelectedTab = this.tabControl1.TabPages[1];
        }

        public void ClearColumns() {
            this.dataGridView1.Rows.Clear();
        }

        public void addColumnsDefinition(string name,object[][] values) {
            this.textBox1.Text = name;
            this.ClearColumns();
            foreach (var row in values) {
                dataGridView1.Rows.Add(row);
            }
            if((from n in DBConnectionManager.Instance.SchemaTables.Rows.Cast<DataRow>() where n["TABLE_NAME"].ToString().Equals(name) select n).Count() == 1){
                this.dataGridView2.DataSource = DBConnectionManager.Instance.Query(new Statement(name,"SELECT * FROM " + name));
            }
        }

        private void TableDesignerForm_Load(object sender, EventArgs e) {
            addColumnsDefinition("NEW_TABLE_NAME",
             new object[][] {
                             //name,type,size,required,key
                new object[]{ "Id",        "AUTOINCREMENT"    ,null,true ,"PRIMARY KEY" },
                new object[]{ "Created_By","TEXT"             ,50  ,false, null },
                new object[]{ "Created_On","DATETIME"         ,null,false, null },
                new object[]{ "Updated_By","TEXT"             ,50  ,false, null },
                new object[]{ "Updated_On","DATETIME"         ,null,false, null },
            }); 
            this.textBox1.Focus();
            this.textBox1.Select();
            this.textBox1.SelectAll();
        }

        private void Button1_Click(object sender, EventArgs e) {
            generateSQL();
            DBConnectionManager.Instance.Execute(new Statement(this.textBox2.Text,this.textBox2.Text));
        }
    }
}
