using MVCHIS.Common;
using MVCHIS.Tools;
using System;
using System.Drawing;
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

        public static Point GetRelativePoint(Control control) {
            Point controlLoc = control.Parent.PointToScreen(control.Location);
            Point relativeLoc = new Point(controlLoc.X - control.Parent.Location.X, controlLoc.Y - control.Parent.Location.Y);
            return relativeLoc;
        }
        
        private static ContextMenuStrip cms = new ContextMenuStrip();
        private static ToolStripMenuItem tsmi = new ToolStripMenuItem("Translate");

        private static void InitContextMenuTranslate() {
            cms.Items.Add(tsmi);
            tsmi.Click += (xs, xe) => {
                if (MainView.Instance.CntrlWD.GetCurrentLanguageId() == 0) return;
                Control lcntrl = ((ContextMenuStrip)((ToolStripMenuItem)xs).Owner).SourceControl;
                var txt = lcntrl.Text;
                var trn = InputBox.Prompt("Translate", $"Translate [{txt}] to:");
                if (trn != null) {

                    WordModel wm = new WordModel { WordInEnglish = txt };
                    WordModel fw = MainView.Instance.CntrlWD.Find(wm,"WordInEnglish");
                    if (fw == null) { 
                        MainView.Instance.CntrlWD.Save(wm);
                    }
                    wm = MainView.Instance.CntrlWD.Select(wm,"Id",false,"WordInEnglish").FirstOrDefault();
                    WordLanguageModel wlm = new WordLanguageModel {
                        WordInLanguage = trn,
                        LanguageId = MainView.Instance.CntrlWD.GetCurrentLanguageId(),
                        WordId = wm.Id
                    };
                    DBControllersFactory.WordLanguage().Save(wlm);
                    lcntrl.Text = trn;
                    MainView.Instance.CntrlWD[txt] = trn;                    
                }
            };
        }

        static System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control)
                                                        .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic |
                                                        System.Reflection.BindingFlags.Instance);

        public static void ApplyLanguageLocalization(Control control) {
            if (control == null || control is TextBox) return;

            aProp.SetValue(control, true, null);

            control.Text = MainView.Instance.CntrlWD[control.Text];

            if (cms.Items.Count == 0) InitContextMenuTranslate();

            if (control.ContextMenuStrip == null){// && control is Label) {
                var txt = control.Text;
                var trn = MainView.Instance.CntrlWD[txt];

                if (txt.Equals(trn)) {
                    control.ContextMenuStrip = cms;
                }
            } else if (control is TreeView) {
                foreach (TreeNode node in ((TreeView)control).Nodes) {
                    node.Text = MainView.Instance.CntrlWD[node.Text];
                    foreach (TreeNode cnode in node.Nodes) {
                        cnode.Text = MainView.Instance.CntrlWD[cnode.Text];
                    }
                }
            } else if (control is ListView) {
                var lv = (ListView)control;
                for (int i = 0; i < lv.Columns.Count; i++) {
                    lv.Columns[i].Text = MainView.Instance.CntrlWD[lv.Columns[i].Text];
                }
            } else if (control is MenuStrip) {
                foreach (var menu in ((MenuStrip)control).Items.OfType<ToolStripMenuItem>()) {
                    menu.Text = MainView.Instance.CntrlWD[menu.Text];
                    foreach (var cmenu in menu.DropDownItems.OfType<ToolStripMenuItem>()) {
                        cmenu.Text = MainView.Instance.CntrlWD[cmenu.Text];
                    }
                }
            }

            foreach (Control cntrl in control.Controls) {
                FormsHelper.ApplyLanguageLocalization(cntrl);
            }
        }

    }
}
