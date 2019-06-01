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
        public EntityController tController;

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
            InitializeComponent(); //(); if(DesignMode || (Site != null && Site.DesignMode)) return;
            this.dictionaryController = (DictionaryController)DBControllersFactory.GetController(Common.MODELS.Dictionary);
            this.egController = (EntitlementGroupController)DBControllersFactory.GetController(Common.MODELS.EntitlementGroup);
            this.eController = (EntitlementController)DBControllersFactory.GetController(Common.MODELS.Entitlement);
            this.tController = (EntityController)DBControllersFactory.GetController(Common.MODELS.Entity);
        }



        private void MainViewLoad(object sender, EventArgs e) { if (DesignMode) return;
            //tsDateTime.Alignment = ToolStripItemAlignment.Right;
            try {
                //this.StartPosition = FormStartPosition.CenterScreen;
                SetBounds(100, 100, 1000, 600);
                
                LoadForm();
            
              }
            catch(Exception ex) {
                FormsHelper.Error(ex.Message);
            }
        }

        public void LoadForm() {
           ;
            initializeToolStripMenuItem.Visible = false;
            initializeToolStripMenuItem.Visible = (null == eController.Find(new EntitlementModel() { EntitlementName = "Profile" }, "EntitlementName"));

            var entitlements = eController.Read().OrderBy(x => x.EntitlementName);
            var egroups = egController.Read().Where(r => r.Dynamic).OrderBy(x => x.EntitlementGroupName);
            var entities = tController.Read().ToDictionary(x => x.Id, x => x);

            foreach (var row in egroups) {
                var egn = row.EntitlementGroupName;
                var eg = new ToolStripMenuItem(egn);
                var exist = menuStrip1.Items.OfType<ToolStripMenuItem>().Where(x => x.Text.Equals(egn));
                if (exist.Count() == 0) {
                    this.menuStrip1.Items.Add(eg);
                } else {
                    eg = exist.First();
                }
                
                foreach (var crow in entitlements.Where(x => x.EntitlementGroupId == row.Id)) {
                    var cen = crow.EntitlementName;
                    var ce = new ToolStripMenuItem(cen);
                    exist = eg.DropDownItems.OfType<ToolStripMenuItem>().Where(x => x.Text.Equals(cen));
                    if (exist.Count() == 0) {
                        eg.DropDownItems.Add(ce);
                    } else {
                        ce = exist.First();
                    }
                    
                    ce.Tag = entities[crow.EntityId];
                    ce.Click += (s, ea) => {
                        if (s == null || !typeof(ToolStripMenuItem).Equals(s.GetType()) || ((ToolStripMenuItem)s).Tag == null || ((ToolStripMenuItem)s).Tag.ToString().Equals("")) return;
                        if (Enum.TryParse<MODELS>(((EntityModel)((ToolStripMenuItem)s).Tag).EntityName, out MODELS num)) {
                            try {
                                Control view = (Control)DBViewsFactory.GetView(num);
                                ShowView(view);
                                FormsHelper.ApplyLanguageLocalization(view);
                            } catch (Exception ex){
                                Console.WriteLine($"~ ERROR : {ex.Message}");
                            }
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
            var CntrlPE = (ProfileEntitlementController)DBControllersFactory.GetController(typeof(ProfileEntitlementController));
            var CntrlEN  = (EntitlementController)DBControllersFactory.GetController(typeof(EntitlementController));

            var pes = CntrlPE.Read(new ProfileEntitlementModel() {
                ProfileId = Session.Instance.CurrentUser.ProfileId,
                AllowRead = true
            }, "ProfileId", "AllowRead");

            Dictionary<int, EntitlementModel> es = CntrlEN.Read().ToDictionary(x => x.Id, x => x);
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

        private void InitializeToolStripMenuItem_Click(object sender, EventArgs ea) {

            var ec = new Security.EntitlementController();
            var pec = new Security.ProfileEntitlementController();
            foreach (var e in pec.Read()) { pec.Delete(e); }
            foreach (var e in ec.Read()) { ec.Delete(e); }

            ((EntityController)DBControllersFactory.GetController(MODELS.Entity)).InitializeDBValues();
            ((EntitlementGroupController)DBControllersFactory.GetController(MODELS.EntitlementGroup)).InitializeDBValues();
            ((EntitlementController)DBControllersFactory.GetController(MODELS.Entitlement)).InitializeDBValues();
            ((ProfileEntitlementController)DBControllersFactory.GetController(MODELS.ProfileEntitlement)).InitializeDBValues();

            FormsHelper.Success("Initialization compeleted !");
            setProgress("Initialization compeleted !", 0);
            initializeToolStripMenuItem.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            tsDateTime.Text = DateTime.Now.ToString(ConfigLoader.CultureInfoDateTimeFormatLongDatePattern);
        }
    }
}
