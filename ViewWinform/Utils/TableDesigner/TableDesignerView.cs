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
    public partial class TableDesignerView : Form {
        public TableDesignerView() {
            InitializeComponent();
            //if (DesignMode) return;
        }


        private void ListBox1SelectedValueChanged(object sender, EventArgs e) {

        }

        public static string getDataType(int dbtype) {
            switch (dbtype) {
                case 130 : return "TEXT";
                case 7   : return "DATETIME";
                case 3   : return "INTEGER";
                case 11  : return "YESNO";
                default  :
                    throw new ArgumentNullException();
            }
        }

        private void ListBox1SelectedIndexChanged(object sender, EventArgs e) {
            if (this.listBox1.SelectedItem == null) return;
            //COLUMNNAME,DATATYPE,CHARACTERMAXIMUMLENGTH,!ISNULLABLE,key
            var columns =
                (from row
                in ModelLibrary.Common.DBConnectionManager.Instance.SchemaColumns.Rows.Cast<DataRow>()
                 where this.listBox1.SelectedItem.ToString().Equals(row["TABLE_NAME"])
                 orderby int.Parse(row["ORDINAL_POSITION"].ToString())
                 select new object[] {
                    row["COLUMN_NAME"],
                    "id".Equals(row["COLUMN_NAME"].ToString().ToLower()) ? "AUTOINCREMENT" : getDataType(int.Parse(row["DATA_TYPE"].ToString())),
                    row["CHARACTER_MAXIMUM_LENGTH"],
                    ! bool.Parse(row["IS_NULLABLE"].ToString()),
                    "id".Equals(row["COLUMN_NAME"].ToString().ToLower()) ? "PRIMARY KEY" : null
                }).ToArray();
            addColumnsDefinition(this.listBox1.SelectedItem.ToString(), columns);
        }

        public void GenerateSQL() {
            string FIELDS = string.Join(",\r\n", (
                              from row
                                in dataGridView1.Rows.Cast<DataGridViewRow>()
                              where !"".Equals(row.Cells[0].Value ?? "")
                              //name,type,size,required,key
                              select string.Format("{0}\t{1}\t{2}\t{3}\t{4}",
                                      row.Cells[0].Value,
                                      row.Cells[1].Value,
                                      "".Equals(row.Cells[2].Value ?? "") ? null : string.Format("({0})", row.Cells[2].Value),
                                      bool.Parse($"{row.Cells[3].Value ?? false}") ? "NOT NULL" : "",
                                      row.Cells[4].Value)));

            this.textBox2.Text = string.Format("CREATE TABLE {0} (\r\n{1}\r\n);", this.textBox1.Text, FIELDS).Replace("\t()\t", "\t \t");

            this.tabControl1.SelectedTab = this.tabControl1.TabPages[1];
        }

        public void ClearColumns() {
            this.dataGridView1.Rows.Clear();
        }

        public void addColumnsDefinition(string name, object[][] values) {
            this.textBox1.Text = name;
            this.ClearColumns();
            foreach (var row in values) {
                dataGridView1.Rows.Add(row);
            }
            if ((from n in DBConnectionManager.Instance.SchemaTables.Rows.Cast<DataRow>() where n["TABLE_NAME"].ToString().Equals(name) select n).Count() == 1) {
                this.dataGridView2.DataSource = DBConnectionManager.Instance.Query(new Statement(name, $"SELECT * FROM [{name}] ORDER BY 1" ));
            }
        }


        private void TableDesignerViewLoad(object sender, EventArgs e) {
            //if (DesignMode) return;
            var tables =
                from row
                in ModelLibrary.Common.DBConnectionManager.Instance.SchemaTables.Rows.Cast<DataRow>()
                where !row["TABLE_NAME"].ToString().StartsWith("MSys")
                orderby row["TABLE_NAME"]
                select row["TABLE_NAME"]
                ;
            this.listBox1.Items.Clear();
            foreach (string table in tables) {
                this.listBox1.Items.Add(table);
                //DBConnectionManager.Instance.Execute(new Statement(table) {
                //    Sql = $"ALTER TABLE {table} ADD COLUMN ReadOnly YESNO"
                //});
            }
            CreateNew();
        }
        public void CreateNew() { 
            addColumnsDefinition("NEWTABLENAME",
             new object[][] {
                             //name,type,size,required,key
                new object[]{ "Id"       ,"AUTOINCREMENT"    ,null,true ,"PRIMARY KEY" },
                new object[]{ "CreatedBy","TEXT"             ,50  ,false, null },
                new object[]{ "CreatedOn","DATETIME"         ,null,false, null },
                new object[]{ "UpdatedBy","TEXT"             ,50  ,false, null },
                new object[]{ "UpdatedOn","DATETIME"         ,null,false, null },
                new object[]{ "ReadOnly", "YESNO"            ,null,false, null },
            });
            this.textBox1.Focus();
            this.textBox1.Select();
            this.textBox1.SelectAll();
        }

        private void Button2Click(object sender, EventArgs e) {
            GenerateSQL();
        }

        private void Button1Click(object sender, EventArgs e) {
            GenerateSQL();
            DBConnectionManager.Instance.Execute(new Statement(this.textBox2.Text, this.textBox2.Text));
            ViewWinform.Utils.FormsHelper.Success("Done...");
            TableDesignerViewLoad(null,null);
        }
    }
}
