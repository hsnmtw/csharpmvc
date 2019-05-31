﻿using MVCHIS.Common;
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
            tsDateTime.Alignment = ToolStripItemAlignment.Right;
            
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
                            Control view = (Control)DBViewsFactory.GetView(num);
                            ShowView(view);
                            FormsHelper.ApplyLanguageLocalization(view);
                        } else {
                            FormsHelper.Error("Not implemented");
                        }
                    };
                }
            }

            foreach (ToolStripMenuItem mi in this.menuStrip1.Items) {
                if (new string[] { "File","Edit","Developer" }.Contains(mi.Text)) continue;
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


        public void WhenAuthenticated(UserModel model) {
            Session.Instance.CurrentUser = model;
            var pec = DBControllersFactory.GetController(MODELS.ProfileEntitlement);
            //var pc = DBControllersFactory.GetController(MODELS.Profile);
            var ec = DBControllersFactory.GetController(MODELS.Entitlement);

            var pes = pec.Read(new ProfileEntitlementModel() {
                ProfileId = Session.Instance.CurrentUser.ProfileId,
                AllowRead = true
            }, "ProfileId", "AllowRead");

            Dictionary<int, EntitlementModel> es = ec.Read<EntitlementModel>().ToDictionary(x => x.Id, x => x);
            foreach (ProfileEntitlementModel row in pes) {
                var eid = row.EntitlementId;
                if (menus.ContainsKey(es[eid].EntitlementName)) { 
                    menus[es[eid].EntitlementName].Enabled = true;
                }
            }
            Session.Instance.UserEntitlements = pes;
            tsslCurrentUser.Text = model.UserName;
            setProgress("Login successful", 0);
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

        private void Timer1_Tick(object sender, EventArgs e) {
            tsDateTime.Text = DateTime.Now.ToString(ConfigLoader.CultureInfoDateTimeFormatLongDatePattern);
        }
    }
}
