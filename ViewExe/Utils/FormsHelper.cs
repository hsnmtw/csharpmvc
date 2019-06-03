using MVCHIS.Common;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MVCHIS.Utils {
    public class FormsHelper
    {
        public static string ARROW => "↓";
        public static string CALENDAR => "📅";
        public static string TICK => "✓";
        public static string DATE_FORMAT => "yyyy-MM-dd";
        public static string TIME_FORMAT => "HH:mm:ss";

        public static void Error(string message)
        {
            //throw new Exception(message);
            MessageBox.Show(message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public static void Success(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        
        private static ContextMenuStrip cms = new ContextMenuStrip();
        private static ToolStripMenuItem tsmi = new ToolStripMenuItem("Translate");

        private static void InitContextMenuTranslate() {
            cms.Items.Add(tsmi);
            tsmi.Click += (xs, xe) => {
                Control lcntrl = ((ContextMenuStrip)((ToolStripMenuItem)xs).Owner).SourceControl;
                var txt = lcntrl.Text;
                var trn = InputBoxForm.Prompt("Translate", $"Translate [{txt}] to:");
                if (trn != null) {
                    int result = MainView.Instance.CntrlDC.Save(new Tools.DictionaryModel() {
                        WordInEnglish = txt,
                        WordInArabic = trn
                    });
                    if (result > 0) {
                        lcntrl.Text = trn;
                        MainView.Instance.CntrlDC[txt] = trn;
                    }
                }
            };
        }


        public static void ApplyLanguageLocalization(Control control) {
            if (control == null || control is TextBox) return;

            control.Text = MainView.Instance.CntrlDC[control.Text];

            if (cms.Items.Count == 0) InitContextMenuTranslate();

            if (control.ContextMenuStrip == null){// && control is Label) {
                var txt = control.Text;
                var trn = MainView.Instance.CntrlDC[txt];

                if (txt.Equals(trn)) {
                    control.ContextMenuStrip = cms;
                }
            } else if (control is TreeView) {
                foreach (TreeNode node in ((TreeView)control).Nodes) {
                    node.Text = MainView.Instance.CntrlDC[node.Text];
                    foreach (TreeNode cnode in node.Nodes) {
                        cnode.Text = MainView.Instance.CntrlDC[cnode.Text];
                    }
                }
            } else if (control is ListView) {
                var lv = (ListView)control;
                for (int i = 0; i < lv.Columns.Count; i++) {
                    lv.Columns[i].Text = MainView.Instance.CntrlDC[lv.Columns[i].Text];
                }
            } else if (control is MenuStrip) {
                foreach (var menu in ((MenuStrip)control).Items.OfType<ToolStripMenuItem>()) {
                    menu.Text = MainView.Instance.CntrlDC[menu.Text];
                    foreach (var cmenu in menu.DropDownItems.OfType<ToolStripMenuItem>()) {
                        cmenu.Text = MainView.Instance.CntrlDC[cmenu.Text];
                    }
                }
            }

            foreach (Control cntrl in control.Controls) {
                FormsHelper.ApplyLanguageLocalization(cntrl);
            }
        }

    }
}
