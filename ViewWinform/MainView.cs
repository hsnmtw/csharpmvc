﻿using ControllerLibrary.Common;
using ControllerLibrary.Security;
using ViewWinform.Customers.Nationalities;
using ViewWinform.Security.Audit;
using ViewWinform.Security.Entitlements;
using ViewWinform.Security.Profiles;
using ViewWinform.Security.Users;
using ModelLibrary.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLibrary.Common;

namespace ViewWinform
{
    public partial class MainView : Form
    {
        private Dictionary<string, ToolStripMenuItem> menus = new Dictionary<string, ToolStripMenuItem>();
        public MainView()
        {
            InitializeComponent();
            foreach (ToolStripMenuItem mi in this.menuStrip1.Items)
            {
                if (mi.Text.Contains("File") || mi.Text.Contains("Window") || mi.Text.Contains("Developer")) continue;
                foreach (var mii in mi.DropDownItems)
                {
                    if (mii.GetType().Equals(typeof(ToolStripMenuItem)))
                    {
                        ToolStripMenuItem tsmi = ((ToolStripMenuItem)mii);
                        tsmi.Enabled = false;
                        menus[tsmi.Text] = tsmi;
                    }
                }
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            tsProgressBar.Value = 0;

            tssLabelStatus.Text = "Connecting to Database";
            new UserController().Read(new UserModel(), new string[] { "Id" });
            tsProgressBar.Value += 25;            

            tssLabelStatus.Text = "Loading Collections"; 
            CollectionsFactory.InitCollectionsMap();
            tsProgressBar.Value += 25;

            tssLabelStatus.Text = "Loading Controllers";
            ControllersFactory.InitControllersMap();
            tsProgressBar.Value += 25;


            tssLabelStatus.Text = "Loading Menus";
            LogOutToolStripMenuItem_Click(sender, e);
            LogInToolStripMenuItem_Click(sender, e);
            tsProgressBar.Value += 25;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Utils.FormsHelper.showView(this, new UsersListView());
            new UserForm() { MdiParent = this }.Show();
        }

        private void ProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProfileForm() { MdiParent = this }.Show();
        }

        private void EntitlementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EntitlementForm() { MdiParent = this }.Show();
        }

        private void PorfileEntitelmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Utils.FormsHelper.showView(this, new Porfile_EntitlementsView());
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Session.Instance.CurrentUser != null) {
                new AuditController().registerEvent(new AuditModel() {
                    User_Name = Session.Instance.CurrentUser.User_Name,
                    Event_Comments = "Logout ..."
                });
            }
            Session.Instance.CurrentUser = null;
            this.tsslCurrentUser.Text = "Guest";
            foreach (ToolStripMenuItem mi in this.menus.Values)
            {
                mi.Enabled = false;
            }            
        }

        private void LogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new Security.Users.UsersLoginView();
            var loginform = Utils.FormsHelper.showView(this, login);
            login.OnOKAction = delegate ()
            {
                var model = (UserModel)new UserController().Read(login.Model,new string[] { "Id" }).First();
                this.tsslCurrentUser.Text = model.Full_Name;
                Session.Instance.CurrentUser = model;
                var pec = new ProfileEntitlementsController();
                var entitlements = pec.GetEntitlementsByProfile(model.Profile_Name);
                foreach(DataRow row in entitlements.Rows)
                {
                    var Entitlement_Name = row["Entitlement_Name"].ToString();
                    if(this.menus.ContainsKey(Entitlement_Name))
                        this.menus[Entitlement_Name].Enabled = true;
                }
                loginform.Close();
            };
            
        }

        private void SQLViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelLibrary.SQLView sqlview = new ModelLibrary.SQLView();
            sqlview.MdiParent = this;
            //sqlview.WindowState = FormWindowState.Maximized;
            sqlview.Size = new Size(sqlview.Width + 20, sqlview.Height + 120);
            sqlview.Show();
        }

        private void EncryptionToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Configurations.CryptoForm() { MdiParent = this }.Show();
        }

        private void PasswordResetToolStripMenuItem_Click(object sender, EventArgs e) {
            if(Session.Instance.CurrentUser == null) {
                Utils.FormsHelper.errorMessage("Not logged in");
                return;
            }
            UserPasswordResetView userPasswordResetView = new Security.Users.UserPasswordResetView();
            userPasswordResetView.Model = (Session.Instance.CurrentUser);
            Form pswdresetform = Utils.FormsHelper.showView(this, userPasswordResetView);
            userPasswordResetView.OnOKAction = delegate () {
                new UserController().ResetPassword(userPasswordResetView.Model);
                Utils.FormsHelper.successMessage("Password has been reset");
                pswdresetform.Close();
            };
            userPasswordResetView.OnCancelAction = delegate () { pswdresetform.Close(); };
        }

        private void NationalitiesToolStripMenuItem_Click(object sender, EventArgs e) {
            //Utils.FormsHelper.showView(this, new ViewWinform.Customers.Nationalities.NationalityListView());
            //new NationalityView() { MdiParent = this }.Show();
            new NationalityForm() { MdiParent = this }.Show();
        }

        private void AuditToolStripMenuItem_Click(object sender, EventArgs e) {
            new AuditView() { MdiParent = this }.Show();
        }

        private void TableDesignerToolStripMenuItem_Click(object sender, EventArgs e) {
            new ModelLibrary.Utils.TableDesigner.TableDesignerView() { MdiParent = this }.Show();
        }

        private void CompoundsToolStripMenuItem_Click(object sender, EventArgs e) {
            new Housing.Compounds.CompoundForm() { MdiParent = this }.Show();
        }

        private void ConfigurationsToolStripMenuItem_Click(object sender, EventArgs e) {
            new Configurations.ConfigurationsForm() { MdiParent = this }.Show();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach(var child in this.MdiChildren) {
                child.Close();
            }
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);
        }

        private void BuildingsToolStripMenuItem_Click(object sender, EventArgs e) {
            new Housing.Buildings.BuildingForm() { MdiParent = this }.Show();
        }

        private void RoomsToolStripMenuItem_Click(object sender, EventArgs e) {
            new Housing.Rooms.RoomForm() { MdiParent = this }.Show();
        }

        private void ControllersRegistryToolStripMenuItem_Click(object sender, EventArgs e) {
            new Configurations.ControllersSelectionForm() { MdiParent = this }.Show();
        }
    }
}
