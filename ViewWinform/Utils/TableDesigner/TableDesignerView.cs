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
        }

        private void TableDesignerForm1_Load(object sender, EventArgs e) {
            var tables =
                from row
                in ModelLibrary.Common.DBConnectionManager.Instance.SchemaTables.Rows.Cast<DataRow>()
                where !row["TABLE_NAME"].ToString().StartsWith("MSys")
                orderby row["TABLE_NAME"]
                select row["TABLE_NAME"]
                ;
            foreach(var table in tables) {
                this.listBox1.Items.Add(table);
            }
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e) {

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

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.listBox1.SelectedItem == null) return;
            //COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,!IS_NULLABLE,key
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
            this.tableDesignerForm1.addColumnsDefinition(this.listBox1.SelectedItem.ToString(), columns);
        }
    }
}
