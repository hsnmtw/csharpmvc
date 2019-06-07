using MVCHIS.Common;
using MVCHIS.Security;
using MVCHIS.Security.Users;
using MVCHIS.Tools;
using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace MVCHIS {
    public partial class MainView : Form, IDisposable
    {

        public   WordController               CntrlWD;
        private  LanguageController           CntrlLG;
        private  UserController               CntrlUS;
        private  EntitlementGroupController   CntrlEG;
        private  EntitlementController        CntrlEN;
        private  EntityController             CntrlET;
        private  ProfileEntitlementController CntrlPE;

        private readonly Dictionary<string, ToolStripMenuItem> menus = new Dictionary<string, ToolStripMenuItem>();

        private static MainView instance = null;
        public static MainView Instance {
            get {
                if (instance == null) instance = new MainView();
                return instance;
            }
        }

        public void setProgress(string message, int progress) {
            this.tssLabelStatus.Text = message;
            this.tsProgressBar.Value = progress;
        }


        private MainView()
        {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            CntrlLG = DBControllersFactory.Language();
            CntrlWD = DBControllersFactory.Word();
            CntrlEG = DBControllersFactory.EntitlementGroup();
            CntrlEN = DBControllersFactory.Entitlement();
            CntrlET = DBControllersFactory.Entity();
            CntrlPE = DBControllersFactory.ProfileEntitlement();
            CntrlUS = DBControllersFactory.User();
        }



        private void MainViewLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //tsDateTime.Alignment = ToolStripItemAlignment.Right;
            //try {
                //this.StartPosition = FormStartPosition.CenterScreen;
                SetBounds(100, 50, 1200, 680);
                
                LoadForm();
            
              try{}
            catch(Exception ex) {
                FormsHelper.Error(ex.Message);
            }
        }

        public void LoadForm() {

            tsddbLanguage.DropDownItems.Clear();
            foreach(var l in CntrlLG.Select(new LanguageModel { }, "Id,LanguageName").Concat(new[] { new LanguageModel { LanguageName="English" } })) {
                tsddbLanguage.DropDownItems.Add(l.LanguageName).Click += (s, e) => {
                    //new Thread(delegate () {
                        if (WordController.CurrentLanguage == LanguageState.Translation) {
                            CntrlWD.SetToDefault();
                            FormsHelper.ApplyLanguageLocalization(this);
                        }
                        CntrlWD.ReadDictionary(l.Id);
                        tsddbLanguage.Text = l.LanguageName;
                        //BeginInvoke((Action)delegate () {
                        FormsHelper.ApplyLanguageLocalization(this);
                        //});
                    //}).Start();
                };
            }

            tsProgressBar.Value = 0;

            //FormsHelper.ApplyLanguageLocalization(this);

            tssLabelStatus.Text = "Loading Menus";
            //LogOutToolStripMenuItemClick(sender, e);
            //LogInToolStripMenuItemClick(sender, e);
            tsProgressBar.Value = 100;
            var login = new UsersLoginView();
            
            login.GoClicked += delegate (UserModel um) {
                um = CntrlUS.Autheniticate(um);
                if (um == null) {
                    FormsHelper.Error("Login denied");
                    return;
                }
                login.Visible = false;
                WhenAuthenticated(um);
            };
            ShowView(login,"Main");
        }



        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Dictionary<string, List<TreeNode>> menu = new Dictionary<string, List<TreeNode>>();
        public void WhenAuthenticated(UserModel model) {
            MVCHISSession.Instance.CurrentUser = model;

            string prev = "";
            TreeNode node = null;
            foreach (var stuple in CntrlUS.GetMenu(model).OrderBy(x => x.Item1)) {
                var egn = stuple.Item1.FromCamelCaseToWords();
                if (prev.Equals(egn) == false) {
                    node = this.treeViewMenu.Nodes.Add(egn);
                    node.ForeColor = Color.Red;
                    menu[egn] = new List<TreeNode>();
                    prev = egn;
                }
                TreeNode child = node.Nodes.Add(stuple.Item2.FromCamelCaseToWords());
                child.Tag = stuple.Item3;
                menu[egn].Add(child);
            }

            MVCHISSession.Instance.UserEntitlements = CntrlPE.Read(new ProfileEntitlementModel { ProfileId = model.ProfileId },"ProfileId");
            tsslCurrentUser.Text = model.UserName;
            setProgress("Login successful", 0);
            this.treeViewMenu.ExpandAll();
            FormsHelper.ApplyLanguageLocalization(this);
        }

        private void SQLViewerToolStripMenuItemClick(object sender, EventArgs e) {
            var sqlview = new Utils.SQLView();
            //sqlview.WindowState = FormWindowState.Maximized;
            sqlview.Size = new Size(sqlview.Width + 20, sqlview.Height + 120);
            sqlview.Show();
        }

        private void EncryptionToolToolStripMenuItemClick(object sender, EventArgs e)
        {
            new Configurations.CryptoForm() .Show();
        }

        private void PasswordResetToolStripMenuItemClick(object sender, EventArgs e) {
            if(MVCHISSession.Instance.CurrentUser == null) {
                Utils.FormsHelper.Error("Not logged in");
                return;
            }
            var userPasswordResetView = new Security.Users.UserPasswordResetView();
            userPasswordResetView.Model = (MVCHISSession.Instance.CurrentUser);
            userPasswordResetView.Show();
        }

        private void CloseAllToolStripMenuItemClick(object sender, EventArgs e) {
            foreach(var child in this.MdiChildren) {
                child.Close();
            }
        }

        private void CascadeToolStripMenuItemClick(object sender, EventArgs e) {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItemClick(object sender, EventArgs e) {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItemClick(object sender, EventArgs e) {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItemClick(object sender, EventArgs e) {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);
        }


        private void ControllersRegistryToolStripMenuItemClick(object sender, EventArgs e) {
            new Configurations.ControllersSelectionForm() .Show();
        }

        private void MainViewFormClosing(object sender, FormClosingEventArgs e) {
        }

        private void NewToolStripMenuItemClick(object sender, EventArgs e) {
            ((IView)tabControl1.SelectedTab.Controls[0])?.NewButton?.PerformClick();
        
}

        private void SaveToolStripMenuItemClick(object sender, EventArgs e) {
            if (panel1.Controls.Count < 1) return;
            ((IView)tabControl1.SelectedTab.Controls[0])?.SaveButton?.PerformClick();
        }

        private void CloseToolStripMenuItemClick(object sender, EventArgs e) {
            if (tabControl1.SelectedIndex >= 0) {
                tabControl1.SelectedTab.Controls.Clear();
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
            }

        }

        

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (panel1.Controls.Count < 1) return;
            ((IView)tabControl1.SelectedTab.Controls[0])?.DeleteButton?.PerformClick();
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            tsDateTime.Text = DateTime.Now.ToString(ConfigLoader.CultureInfoDateTimeFormatLongDatePattern);
        }

        private void TreeView1_DoubleClick(object s, EventArgs e) {

        }

        public void ShowView(Control view,string name,Action whenCompleted = null) {
            
            if (view is IView) {
                var iview = (IView)view;
                iview.AfterSave += AfterViewSave;
                iview.AfterDelete += AfterViewDelete;
                iview.AfterNew += AfterViewNew;
                iview.ModelChanged += ViewModelChanged;
            }

            var tpx = new TabPage(name);
            tpx.Text = name;
            
            tabControl1.TabPages.Add(tpx);
            tpx.SuspendLayout();
            tpx.Controls.Add(view);
            tabControl1.SelectedTab = tpx;
            tpx.ResumeLayout();
            whenCompleted?.Invoke();
            FormsHelper.ApplyLanguageLocalization(view);

        }


        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            TreeNode node = e.Node;
            if (node.Tag == null) return;
            var entity = CntrlET.Find(new EntityModel { EntityName = node.Tag.ToString() }, "EntityName");
            // = (UserControl)DBViewsFactory.GetView((MODELS)Enum.Parse(typeof(MODELS), entity.EntityName));
            foreach (TabPage tp in tabControl1.TabPages) {
                Control c = tp.Controls[0];
                if (c.Tag !=null && c.Tag.Equals(node.Tag)) {
                    tabControl1.SelectedTab = tp;
                    return;
                }
            }
            SuspendLayout();
            tabControl1.SuspendLayout();
            //new Thread(() => {
            //    BeginInvoke((Action)(() => {                    
                    Application.DoEvents();
                    UserControl view = (UserControl)DBViewsFactory.GetView((MODELS)Enum.Parse(typeof(MODELS), entity.EntityName));
                    view.SuspendLayout();
                    view.Tag = node.Tag;
                    //lblHeading.Text = node.Text;
                    ShowView(view, node.Text, () => {
                        Thread.Sleep(1000);
                        Cursor.Current = Cursors.Default;
                        view.ResumeLayout();
                        tabControl1.ResumeLayout();
                        ResumeLayout();
                    });
            //    }));
            //}).Start();
        }

        private void ViewModelChanged() {
            //lblActionStatus.Visible = false;
        }

        private void AfterViewNew(bool status) {
            
        }

        private void AfterViewDelete(bool status) {
            //lblActionStatus.Visible = status;
        }

        private void AfterViewSave(bool status) {
            //lblActionStatus.Visible = status;
        }

        private void TreeView1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                TreeView1_NodeMouseDoubleClick(sender, new TreeNodeMouseClickEventArgs(treeViewMenu.SelectedNode, MouseButtons.Left, 2, 0, 0));
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtSearchMenu_TextChanged(object sender, EventArgs e) {
            treeViewMenu.BeginUpdate();
            treeViewMenu.Nodes.Clear();
            foreach (string row in menu.Keys) {
                TreeNode node = this.treeViewMenu.Nodes.Add(row);
                node.ForeColor = Color.Red;
                foreach (TreeNode crow in menu[row].Where(x => x.Text.ToLower().Contains(txtSearchMenu.Text.ToLower()))) {
                    node.Nodes.Add(crow);
                    if (treeViewMenu.SelectedNode == null) treeViewMenu.SelectedNode = crow;
                }
            }
            treeViewMenu.ExpandAll();
            treeViewMenu.EndUpdate();
        }

        private void TreeViewMenu_DrawNode(object sender, DrawTreeNodeEventArgs e) {

        }
 
        private void TreeViewMenu_BeforeSelect(object sender, TreeViewCancelEventArgs e) {
            
        }

        private void TreeViewMenu_AfterSelect(object sender, TreeViewEventArgs e) {

        }

        private void TabControl1_TabIndexChanged(object sender, EventArgs e) {
            //lblHeading.Text = tabControl1.SelectedTab.Text;
        }
    }
}
