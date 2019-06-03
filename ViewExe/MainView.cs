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
using System.Windows.Forms;

namespace MVCHIS {
    public partial class MainView : Form, IDisposable
    {

        public   DictionaryController         CntrlDC;
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
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return; //(); if(DesignMode || (Site != null && Site.DesignMode)) return;
            this.CntrlDC = (DictionaryController)DBControllersFactory.GetController(Common.MODELS.Dictionary);
            this.CntrlEG = (EntitlementGroupController)DBControllersFactory.GetController(Common.MODELS.EntitlementGroup);
            this.CntrlEN = (EntitlementController)DBControllersFactory.GetController(Common.MODELS.Entitlement);
            this.CntrlET = (EntityController)DBControllersFactory.GetController(Common.MODELS.Entity);
            this.CntrlPE = ((ProfileEntitlementController)DBControllersFactory.GetController(MODELS.ProfileEntitlement));
        }



        private void MainViewLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //tsDateTime.Alignment = ToolStripItemAlignment.Right;
            try {
                //this.StartPosition = FormStartPosition.CenterScreen;
                SetBounds(100, 50, 1200, 680);
                
                LoadForm();
            
              }
            catch(Exception ex) {
                FormsHelper.Error(ex.Message);
            }
        }

        public void LoadForm() {
           ;
            initializeToolStripMenuItem.Visible = false;
            initializeToolStripMenuItem.Visible = (null == CntrlEN.Find(new EntitlementModel() { EntitlementName = "Profile" }, "EntitlementName"));




            tsProgressBar.Value = 0;

            FormsHelper.ApplyLanguageLocalization(this);

            tssLabelStatus.Text = "Loading Menus";
            //LogOutToolStripMenuItemClick(sender, e);
            //LogInToolStripMenuItemClick(sender, e);
            tsProgressBar.Value = 100;

            ShowView(new UsersLoginView() { Dock = DockStyle.Top });
        }

        public void ShowView(Control view) {
            panel1.Controls.Clear();
            panel1.Controls.Add(view);
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Dictionary<string, List<TreeNode>> menu = new Dictionary<string, List<TreeNode>>();
        public void WhenAuthenticated(UserModel model) {
            Session.Instance.CurrentUser = model;

            var pes = CntrlPE.Read(new ProfileEntitlementModel() {
                ProfileId = Session.Instance.CurrentUser.ProfileId,
                AllowRead = true
            }, "ProfileId", "AllowRead");

            
            var entitlements = CntrlEN.Read().Where(x => pes.Any(y => y.EntitlementId==x.Id) ).OrderBy(x => x.EntitlementName);
            var egroups = CntrlEG.Read().Where(r => r.Dynamic).Where(x => entitlements.Any(y => y.EntitlementGroupId == x.Id)).OrderBy(x => x.EntitlementGroupName);
            var entities = CntrlET.Read().ToDictionary(x => x.Id, x => x);

            foreach (var row in egroups) {
                var egn = row.EntitlementGroupName;

                TreeNode node = this.treeViewMenu.Nodes.Add(egn);
                node.ForeColor = Color.Red;
                menu[egn] = new List<TreeNode>();
                foreach (var crow in entitlements.Where(x => x.EntitlementGroupId == row.Id)) {
                    crow.EntitlementName = crow.EntitlementName.FromCamelCaseToWords();
                    
                    TreeNode ce = node.Nodes.Add(crow.EntitlementName);
                    ce.Tag = entities[crow.EntityId];
                    menu[egn].Add(ce);
                }
            }

            Session.Instance.UserEntitlements = pes;
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
            if(Session.Instance.CurrentUser == null) {
                Utils.FormsHelper.Error("Not logged in");
                return;
            }
            var userPasswordResetView = new Security.Users.UserPasswordResetView();
            userPasswordResetView.Model = (Session.Instance.CurrentUser);
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
            ((IView)panel1.Controls[0])?.NewButton?.PerformClick();
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e) {
            if (panel1.Controls.Count < 1) return;
            ((IView)panel1.Controls[0])?.SaveButton?.PerformClick();
        }

        private void CloseToolStripMenuItemClick(object sender, EventArgs e) {
            try {
                this.ActiveMdiChild.Close();
            } catch { }
        }

        

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (panel1.Controls.Count < 1) return;
            ((IView)panel1.Controls[0])?.DeleteButton?.PerformClick();
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void ArabicToolStripMenuItem_Click(object sender, EventArgs e) {
            DictionaryController.LanguageState = DictionaryController.LanguageState == LanguageState.Arabic ? LanguageState.English : LanguageState.Arabic;
            FormsHelper.ApplyLanguageLocalization(this);
        }

        private void InitializeToolStripMenuItem_Click(object sender, EventArgs ea) {

            var ec = new Security.EntitlementController();
            var pec = new Security.ProfileEntitlementController();
            foreach (var e in pec.Read()) { pec.Delete(e); }
            foreach (var e in ec.Read()) { ec.Delete(e); }

            CntrlET.InitializeDBValues();
            CntrlEG.InitializeDBValues();
            CntrlEN.InitializeDBValues();
            CntrlPE.InitializeDBValues();

            FormsHelper.Success("Initialization compeleted !");
            setProgress("Initialization compeleted !", 0);
            initializeToolStripMenuItem.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            tsDateTime.Text = DateTime.Now.ToString(ConfigLoader.CultureInfoDateTimeFormatLongDatePattern);
        }

        private void TreeView1_DoubleClick(object s, EventArgs e) {

        }

        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            TreeNode node = e.Node;
            if (node.Tag == null) return;
            var entity = (EntityModel)node.Tag;
            var view = (UserControl)DBViewsFactory.GetView((MODELS)Enum.Parse(typeof(MODELS), entity.EntityName));
            panel1.Controls.Clear();
            lblHeading.Text = node.Text;
            panel1.Controls.Add(view);
            FormsHelper.ApplyLanguageLocalization(view);
            if (view is IView) {
                var iview = (IView)view;
                iview.AfterSave += AfterViewSave;
                iview.AfterDelete += AfterViewDelete;
                iview.AfterNew += AfterViewNew;
                iview.ModelChanged += ViewModelChanged;
            }
        }

        private void ViewModelChanged() {
            lblActionStatus.Visible = false;
        }

        private void AfterViewNew(bool status) {
            
        }

        private void AfterViewDelete(bool status) {
            lblActionStatus.Visible = status;
        }

        private void AfterViewSave(bool status) {
            lblActionStatus.Visible = status;
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
        TreeNode previous = null;
        private void TreeViewMenu_BeforeSelect(object sender, TreeViewCancelEventArgs e) {
            
        }

        private void TreeViewMenu_AfterSelect(object sender, TreeViewEventArgs e) {
            treeViewMenu.BeginUpdate();
            if (previous != null) previous.NodeFont = new Font("Verdana", 8, FontStyle.Regular);
            e.Node.NodeFont = new Font("Verdana", 8, FontStyle.Bold);
            previous = e.Node;
            treeViewMenu.EndUpdate();
            treeViewMenu.Invalidate();
        }
    }
}
