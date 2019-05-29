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
using System.Windows.Forms;

namespace MVCHIS {
    public partial class MainView : Form, IDisposable
    {

        public DictionaryController dictionaryController;
        public EntitlementGroupController egController;
        public EntitlementController eController;

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
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;; //(); if(DesignMode || (Site != null && Site.DesignMode)) return;;
            this.dictionaryController = (DictionaryController)DBControllersFactory.GetController(Common.MODELS.Dictionary);
            this.egController = (EntitlementGroupController)DBControllersFactory.GetController(Common.MODELS.EntitlementGroup);
            this.eController = (EntitlementController)DBControllersFactory.GetController(Common.MODELS.Entitlement);

        }



        private void MainViewLoad(object sender, EventArgs e) {
                LoadForm();
            
              try{}
            catch(Exception ex) {
                FormsHelper.Error(ex.Message);
            }
        }

        public void LoadForm() {
            if (DesignMode || (Site != null && Site.DesignMode)) return;;
            initializeToolStripMenuItem.Visible = false;
            initializeToolStripMenuItem.Visible = (null == eController.Find(new EntitlementModel() { EntitlementName = "Initialize" }, "EntitlementName"));

            var entitlements = eController.Read<EntitlementModel>().OrderBy(x => x.EntitlementName);
            var egroups = egController.Read<EntitlementGroupModel>().Where(r => r.Dynamic).OrderBy(x => x.EntitlementGroupName);

            foreach (var row in egroups) {
                var egn = row.EntitlementGroupName;
                var eg = new ToolStripMenuItem(egn);
                var exist = menuStrip1.Items.OfType<ToolStripMenuItem>().Where(x => x.Text.Equals(egn));
                if (exist.Count() == 0) {
                    this.menuStrip1.Items.Add(eg);
                } else {
                    eg = exist.First();
                }
                
                foreach (var crow in entitlements.Where(x => egn.Equals(x.EntitlementGroupName))) {
                    var cen = crow.EntitlementName;
                    var ce = new ToolStripMenuItem(cen);
                    exist = eg.DropDownItems.OfType<ToolStripMenuItem>().Where(x => x.Text.Equals(cen));
                    if (exist.Count() == 0) {
                        eg.DropDownItems.Add(ce);
                    } else {
                        ce = exist.First();
                    }
                    
                    ce.Tag = crow.EntityName;
                    ce.Click += (s, ea) => {
                        if (s == null || !typeof(ToolStripMenuItem).Equals(s.GetType()) || ((ToolStripMenuItem)s).Tag == null || ((ToolStripMenuItem)s).Tag.ToString().Equals("")) return;;
                        if (Enum.TryParse<MODELS>(((ToolStripMenuItem)s).Tag.ToString(), out MODELS num)) {
                            var view = ((Form)DBViewsFactory.GetView(num));
                            view.MdiParent = this;
                            
                            view.Show();
                            FormsHelper.ApplyLanguageLocalization(view);
                        } else {
                            FormsHelper.Error("Not implemented");
                        }
                    };
                }
            }

            foreach (ToolStripMenuItem mi in this.menuStrip1.Items) {
                if (mi.Text.Contains("File") || mi.Text.Contains("Window") || mi.Text.Contains("Developer")) continue;
                foreach (var mii in mi.DropDownItems) {
                    if (mii.GetType().Equals(typeof(ToolStripMenuItem))) {
                        var tsmi = ((ToolStripMenuItem)mii);
                        tsmi.Enabled = false;
                        menus[tsmi.Text] = tsmi;
                    }
                }
            }

            tsProgressBar.Value = 0;

            FormsHelper.ApplyLanguageLocalization(this);

            tssLabelStatus.Text = "Loading Menus";
            //LogOutToolStripMenuItemClick(sender, e);
            //LogInToolStripMenuItemClick(sender, e);
            tsProgressBar.Value = 100;

            var login = new UsersLoginView() { MdiParent = this };
            login.Show();
            //login.Model = new UserModel() { UserName = "Admin", UserPassword = "123" };
            tsProgressBar.Value = 0;
        }


        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void WhenAuthenticated(UserModel model) {
            Session.Instance.CurrentUser = model;
            var pec = (ProfileEntitlementsController)DBControllersFactory.GetController(Common.MODELS.ProfileEntitlement);
            var pes = pec.Read(new ProfileEntitlementsModel() {
                ProfileName = Session.Instance.CurrentUser.ProfileName,
                AllowRead = true
            }, "ProfileName", "AllowRead");

            foreach (ProfileEntitlementsModel row in pes) {
                var EntitlementName = row.EntitlementName;
                if (this.menus.ContainsKey(EntitlementName)) { 
                    this.menus[EntitlementName].Enabled = true;
                }
            }
            Session.Instance.UserEntitlements = pes;
        }

        private void SQLViewerToolStripMenuItemClick(object sender, EventArgs e) {
            var sqlview = new Utils.SQLView() {
                MdiParent = this
            };
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
            userPasswordResetView.ShowDialog();
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
            ((IView)ActiveMdiChild)?.NewButton?.PerformClick();
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e) {
            ((IView)ActiveMdiChild)?.SaveButton?.PerformClick();
        }

        private void CloseToolStripMenuItemClick(object sender, EventArgs e) {
            try {
                this.ActiveMdiChild.Close();
            } catch { }
        }

        

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) {
            ((IView)ActiveMdiChild)?.DeleteButton?.PerformClick();
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void ArabicToolStripMenuItem_Click(object sender, EventArgs e) {
            DictionaryController.LanguageState = DictionaryController.LanguageState == LanguageState.Arabic ? LanguageState.English : LanguageState.Arabic;
            FormsHelper.ApplyLanguageLocalization(this);
            foreach(var form in this.MdiChildren) {
                FormsHelper.ApplyLanguageLocalization(form);
            }
        }

        private void InitializeToolStripMenuItem_Click(object sender, EventArgs e) {
            var entities = new MODELS[] {
                 MODELS.Entity
                ,MODELS.EntitlementGroup
                ,MODELS.Profile
                ,MODELS.Entitlement
                ,MODELS.ProfileEntitlement
                ,MODELS.User
                ,MODELS.Country
                ,MODELS.Dictionary
            };
            int i = 0;
            foreach (var entity in entities) {
                DBControllersFactory.GetController(entity).Dispatch("Initialize");
                setProgress($"Intialized {entity}", 100 * ++i / entities.Length);
            }
            FormsHelper.Success("Initialization compeleted !");
            setProgress("Initialization compeleted !", 0);
            initializeToolStripMenuItem.Visible = false;
        }
    }
}
