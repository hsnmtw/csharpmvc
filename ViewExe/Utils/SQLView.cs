using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVCHIS.Utils {
    public partial class SQLView : Form
    {
        const string NEWLINE = "\r\n";
        public SQLView()
        {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;;
        }

        private void Button1Click(object sender, EventArgs e) {

            SQLController controller = new SQLController();
            chkMSAccess.Checked = controller.isOLEDBConnection();

            string[] sqls = this.textBox1.Text.Split(';');

            for (int i = 0; i < sqls.Length; i++) {
                var sql = sqls[i];
                MainView.Instance.setProgress($"{i}/{sqls.Length}", 100 * i / sqls.Length);
                if (sql.Trim().Equals("")) continue;
                
                try {
                    if (chkMSAccess.Checked) {
                        sql = sql.Replace("int IDENTITY(1,1)", "AUTOINCREMENT");
                        sql = sql.Replace("VARCHAR(1000)", "MEMO");
                        sql = sql.Replace("BIT", "YESNO");
                    }

                    if (sql.Trim().ToLower().StartsWith("select")) richTextBox1.Text += $"{NEWLINE}{controller.Query(sql)}";
                    else richTextBox1.Text += $"{NEWLINE}affected rows: { controller.Execute(sql) } ";

                } catch (Exception ex) {
                    richTextBox1.Text += $"{NEWLINE} EXCEPTION : {ex.Message} ({sql})";
                }
                richTextBox1.Refresh();
            }
            MainView.Instance.setProgress("Completed", 0);
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e) {
            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }
    }
}
