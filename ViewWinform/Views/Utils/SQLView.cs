using MVCWinform.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVCWinform.Utils {
    public partial class SQLView : Form
    {
        const string NEWLINE = "\r\n";
        public SQLView()
        {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
        }

        private void Button1Click(object sender, EventArgs e) {


            string sql="";
            
            string[] sqls = this.textBox1.Text.Split(';');

            //this.dataGridView1.DataSource = DBConnectionManager.Instance.query(this.textBox1.Text);
            //this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < sqls.Length; i++) {
                sql = sqls[i];
                MainView.Instance.setProgress($"{i}/{sqls.Length}", 100 * i / sqls.Length);
                if (sql.Trim().Equals("")) continue;
                
                try {
                    if (chkMSAccess.Checked) {
                        sql = sql.Replace("int IDENTITY(1,1)", "AUTOINCREMENT");
                        sql = sql.Replace("VARCHAR(1000)", "MEMO");
                        sql = sql.Replace("BIT", "YESNO");
                    }

                    if (sql.Trim().ToLower().StartsWith("select")) richTextBox1.Text += NEWLINE + this.ViewResult(sql, i);
                    else richTextBox1.Text += $"{NEWLINE}affected rows: { DBConnectionManager.Instance.Execute(sql) } ";

                } catch (Exception ex) {
                    //MessageBox.Show($"{}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    richTextBox1.Text += $"{NEWLINE} EXCEPTION : {ex.Message} ({sql})";
                }
                richTextBox1.Refresh();
            }
            //richTextBox1.Focus();
            //richTextBox1.Select();
            //richTextBox1.ScrollToCaret();
            MainView.Instance.setProgress("Completed", 0);
        }

        private string ViewResult(string sql,int index) {

            IEnumerable<Dictionary<string, object>> query = DBConnectionManager.Instance.QueryAsDictionary(sql);
            if (query.Count() == 0) return "NO ROWS !!!";
            var sb = new StringBuilder();
            var first = query.First();
            string[] vals, keys;
            if (first.GetType().ToString().Contains("Dictionary")) {
                keys = (from key in first.Keys orderby key select key).ToArray();
                vals = new string[keys.Length];
                for (int k = 0; k < keys.Length; k++) {
                    vals[k] = (string.Format("{0,-25}", keys[k]));
                }
                sb.Append(string.Join(",", vals)).Append(NEWLINE);
                for (int k = 0; k < keys.Length; k++) {
                    vals[k] = (string.Format("{0,-25}", "-----------------------"));
                }
                sb.Append(string.Join(",", vals)).Append(NEWLINE);
                foreach (var item in query) {
                    vals = new string[keys.Length];
                    for (int k = 0; k < keys.Length; k++) {
                        vals[k] = (string.Format("{0,-25}", item[keys[k]]));
                    }
                    sb.Append(string.Join(",", vals)).Append(NEWLINE);
                }
            }
            return sb.ToString();
        }

        private void SQLView_Load(object sender, EventArgs e) {
            this.chkMSAccess.Checked = ConfigLoader.DatabaseConnectionString.ToLower().Contains("access");
            
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e) {
            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }
    }
}
