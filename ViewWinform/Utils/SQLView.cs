using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLibrary.Common;

namespace ViewWinform.Utils
{
    public partial class SQLView : Form
    {
        public SQLView()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            string sql="";
            try
            {
                string[] sqls = this.textBox1.Text.Split(';');

                if (this.textBox1.Text.Trim().ToLower().StartsWith("select") || this.textBox1.Text.Trim().ToLower().StartsWith("transform"))
                {
                    //this.dataGridView1.DataSource = DBConnectionManager.Instance.query(this.textBox1.Text);
                    //this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    
                    this.tableLayoutPanel1.RowStyles.Clear();

                    this.tableLayoutPanel1.Controls.Clear();
                    this.tableLayoutPanel1.ColumnCount = 1;
                    this.tableLayoutPanel1.RowCount = sqls.Length;
                    
                    for (int i = 0; i < sqls.Length; i++)
                    {
                        sql = sqls[i];
                        if (sql.Trim().Equals("")) continue;
                        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / sqls.Length));
                        DataGridView grid = new Utils.CustomDataGridView();
                        grid.DataSource = DBConnectionManager.Instance.Query(new Statement(sql,sql));
                        this.tableLayoutPanel1.Controls.Add(grid,1,i);
                    }

                }
                else
                {

                    for (int i = 0; i < sqls.Length; i++)
                    {
                        sql = sqls[i];
                        if (sql.Trim().Equals("")) continue;
                        DBConnectionManager.Instance.Execute(new Statement(sql,sql));
                    }
                    MessageBox.Show("SQL was executed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} => {sql}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
