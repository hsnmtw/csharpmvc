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
        private SQLController controller;

        public SQLView()
        {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            controller = new SQLController();
        }

        private void Button1Click(object sender, EventArgs e) {

            
            chkMSAccess.Checked = controller.isOLEDBConnection();

            string[] sqls = this.txtSQL.Text.Split(';');

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

                    if (sql.Trim().ToLower().StartsWith("select")) txtResults.Text += $"{NEWLINE}{controller.Query(sql)}";
                    else txtResults.Text += $"{NEWLINE}affected rows: { controller.Execute(sql) } ";

                } catch (Exception ex) {
                    txtResults.Text += $"{NEWLINE} EXCEPTION : {ex.Message} ({sql})";
                }
                txtResults.Refresh();
            }
            MainView.Instance.setProgress("Completed", 0);
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e) {
            // set the current caret position to the end
            txtResults.SelectionStart = txtResults.Text.Length;
            // scroll it automatically
            txtResults.ScrollToCaret();
        }

        private void BtnEntities_Click(object sender, EventArgs e) {
            contextMenuStripEntities.Show(FormsHelper.GetRelativePoint(btnEntities));
        }

        private void SQLView_Load(object sender, EventArgs e) {
            contextMenuStripEntities.Items.Clear();
            Dictionary<char, ToolStripMenuItem> parent = new Dictionary<char, ToolStripMenuItem>();
            foreach(var entity in DBControllersFactory.Entity().Read().OrderBy(x => x.EntityName)) {
                char pname = entity.EntityName[0];
                if (parent.ContainsKey(pname) == false) {
                    parent[pname] = new ToolStripMenuItem($"{pname}");
                    contextMenuStripEntities.Items.Add(parent[pname]);
                }
                parent[pname].DropDownItems.Add(entity.EntityName).Click += (ms, me) => {
                    txtSQL.Text = controller.GetDLL(entity.EntityName);
                } ;
            }
        }
    }
}
