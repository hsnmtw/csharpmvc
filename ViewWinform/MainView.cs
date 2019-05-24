using ControllerLibrary.Common;
using ControllerLibrary.Security;
using ViewWinform.Customers;
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
using ViewWinform.Common;
using ViewWinform.Billing;
using ViewWinform.Security;
using System.Reflection;
using ControllerLibrary.Tools;
using ViewWinform.Utils;

namespace ViewWinform
{
    public partial class MainView : Form, IDisposable
    {

        public DictionaryController dictionaryController;
        //private DictionaryModel model;

        //public DictionaryModel Model {
        //    get {
        //        model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
        //        return model;
        //    }
        //    set {
        //        this.model = value;
        //        ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);
        //    }
        //}


        private Dictionary<string, ToolStripMenuItem> menus = new Dictionary<string, ToolStripMenuItem>();



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
            InitializeComponent(); if (DesignMode) return;
            this.dictionaryController = (DictionaryController)DBControllersFactory.GetController(Entities.Dictionary);

            foreach (ToolStripMenuItem mi in this.menuStrip1.Items)
            {
                if (mi.Text.Contains("File") || mi.Text.Contains("Window") || mi.Text.Contains("Developer")) continue;
                foreach (var mii in mi.DropDownItems)
                {
                    if (mii.GetType().Equals(typeof(ToolStripMenuItem)))
                    {
                        var tsmi = ((ToolStripMenuItem)mii);
                        tsmi.Enabled = false;
                        menus[tsmi.Text] = tsmi;
                    }
                }
            }
        }

        

        private void MainViewLoad(object sender, EventArgs e)
        {
            if (DesignMode) return;
            tsProgressBar.Value = 0;

            FormsHelper.ApplyLanguageLocalization(this);

            tssLabelStatus.Text = "Loading Menus";
            LogOutToolStripMenuItemClick(sender, e);
            LogInToolStripMenuItemClick(sender, e);
            tsProgressBar.Value = 100;
        }


        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsersToolStripMenuItemClick(object sender, EventArgs e)
        {
            //Utils.FormsHelper.showView(this, new UsersListView());
            new UserForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void ProfilesToolStripMenuItemClick(object sender, EventArgs e)
        {
            new ProfileForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void EntitlementsToolStripMenuItemClick(object sender, EventArgs e)
        {
            new EntitlementForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void PorfileEntitelmentsToolStripMenuItemClick(object sender, EventArgs e)
        {
            //Utils.FormsHelper.showView(this, new PorfileEntitlementsView());
        }

        private void LogOutToolStripMenuItemClick(object sender, EventArgs e)
        {
            //CloseAllToolStripMenuItemClick(sender, e);
            //if (Session.Instance.CurrentUser != null) {
            //    var audit = (AuditController)DBControllersFactory.GetController(Entities.Audit);
            //    audit.registerEvent(new AuditModel() {
            //        UserName = Session.Instance.CurrentUser.UserName,
            //        EventComments = "Logout ..."
            //    });
            //}
            //Session.Instance.CurrentUser = null;
            //this.tsslCurrentUser.Text = "Guest";
            //foreach (ToolStripMenuItem mi in this.menus.Values)
            //{
            //    mi.Enabled = false;
            //}            
        }

        private void LogInToolStripMenuItemClick(object sender, EventArgs e)
        {
            //new UsersLoginView() { RightToLeft = this.RightToLeft, RightToLeftLayout = this.RightToLeftLayout, }.ShowDialog();
        }

        public void WhenAuthenticated(UserModel model) {
            Session.Instance.CurrentUser = model;
            var pec = (ProfileEntitlementsController)DBControllersFactory.GetController(Entities.ProfileEntitlement);
            var entitlements = pec.Read(new ProfileEntitlementsModel() {
                ProfileName = Session.Instance.CurrentUser.ProfileName,
                AllowRead = true
            }, "ProfileName", "AllowRead");

            foreach (ProfileEntitlementsModel row in entitlements) {
                var EntitlementName = row.EntitlementName;
                if (this.menus.ContainsKey(EntitlementName))
                    this.menus[EntitlementName].Enabled = true;
            }
        }

        private void SQLViewerToolStripMenuItemClick(object sender, EventArgs e) {
            var sqlview = new Utils.SQLView() {
                MdiParent = this, RightToLeft = this.RightToLeft, RightToLeftLayout = this.RightToLeftLayout,
            };
            //sqlview.WindowState = FormWindowState.Maximized;
            sqlview.Size = new Size(sqlview.Width + 20, sqlview.Height + 120);
            sqlview.Show();
        }

        private void EncryptionToolToolStripMenuItemClick(object sender, EventArgs e)
        {
            new Configurations.CryptoForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
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

        private void CountryToolStripMenuItemClick(object sender, EventArgs e) {
            //Utils.FormsHelper.showView(this, new ViewWinform.Customers.Country.CountryListView());
            //new CountryView() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
            new CountryForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void AuditToolStripMenuItemClick(object sender, EventArgs e) {
            new AuditView() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void TableDesignerToolStripMenuItemClick(object sender, EventArgs e) {
            new ModelLibrary.Utils.TableDesigner.TableDesignerView() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void CompoundsToolStripMenuItemClick(object sender, EventArgs e) {
            new Housing.Compounds.CompoundForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void ConfigurationsToolStripMenuItemClick(object sender, EventArgs e) {
            new Configurations.ConfigurationsForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
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

        private void BuildingsToolStripMenuItemClick(object sender, EventArgs e) {
            new Housing.Buildings.BuildingForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void RoomsToolStripMenuItemClick(object sender, EventArgs e) {
            new Housing.Rooms.RoomForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void ControllersRegistryToolStripMenuItemClick(object sender, EventArgs e) {
            new Configurations.ControllersSelectionForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void CompactAndRepairToolStripMenuItemClick(object sender, EventArgs e) {
            new Utils.CompactAndRepairForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void MainViewFormClosing(object sender, FormClosingEventArgs e) {
            try {
                DBConnectionManager.Instance.Close();
            } catch { }
        }

        private void BuildingTypesToolStripMenuItemClick(object sender, EventArgs e) {
            new Housing.BuildingTypes.BuildingTypeForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void ClientTypesToolStripMenuItemClick(object sender, EventArgs e) {
            new ClientTypeForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void ClientsToolStripMenuItemClick(object sender, EventArgs e) {
            new ClientForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void ProjectsToolStripMenuItemClick(object sender, EventArgs e) {
            new ProjectForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void BillingCategoriesToolStripMenuItemClick(object sender, EventArgs e) {
            new BillingCategoryForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void AccomodationClassesToolStripMenuItemClick(object sender, EventArgs e) {
            new AccomodationClassForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void NewToolStripMenuItemClick(object sender, EventArgs e) {
            if (this.ActiveMdiChild == null) return;
            if (this.ActiveMdiChild is ISingleForm) {
                ((ISingleForm)this.ActiveMdiChild).PerformAction("New");
            }
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e) {
            if (this.ActiveMdiChild == null) return;
            if (this.ActiveMdiChild is ISingleForm) {
                ((ISingleForm)this.ActiveMdiChild).PerformAction("Save");
            }
        }

        private void FoodClassesToolStripMenuItemClick(object sender, EventArgs e) {
            new Billing.FoodClassForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void CloseToolStripMenuItemClick(object sender, EventArgs e) {
            try {
                this.ActiveMdiChild.Close();
            } catch { }
        }

        private void FoodTypesToolStripMenuItem_Click(object sender, EventArgs e) {
            new FoodTypeForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void DuplicateToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.ActiveMdiChild == null) return;
            if (this.ActiveMdiChild is ISingleForm) {
                ((ISingleForm)this.ActiveMdiChild).PerformAction("Duplicate");
            }
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.ActiveMdiChild == null) return;
            if (this.ActiveMdiChild is ISingleForm) {
                ((ISingleForm)this.ActiveMdiChild).PerformAction("Remove");
            }
        }

        private void IdentificationTypesToolStripMenuItem_Click(object sender, EventArgs e) {
            new IdentificationTypeForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void EntitlementGroupsToolStripMenuItem_Click(object sender, EventArgs e) {
            new EntitlementGroupForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void IdentificationToolStripMenuItem_Click(object sender, EventArgs e) {
            new IdentificationForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout, }.Show();
        }

        private void DictionaryToolStripMenuItem_Click(object sender, EventArgs e) {
            new Tools.DictionaryForm() { MdiParent = this, RightToLeft = this.RightToLeft , RightToLeftLayout = this.RightToLeftLayout }.Show();
        }

        private void ArabicToolStripMenuItem_Click(object sender, EventArgs e) {

            //DictionaryController.LanguageState = DictionaryController.LanguageState == LanguageState.Arabic ? LanguageState.English : LanguageState.Arabic;

            switch (DictionaryController.LanguageState) {
                case LanguageState.Arabic:
                    DictionaryController.LanguageState = LanguageState.English;
                    this.RightToLeft = RightToLeft.No;
                    this.RightToLeftLayout = false;
                    break;
                default:
                    DictionaryController.LanguageState = LanguageState.Arabic;
                    this.RightToLeft = RightToLeft.Yes;
                    this.RightToLeftLayout = true;
                    break;
            }

            FormsHelper.ApplyLanguageLocalization(this);

            //var mainm = menuStrip1.Items.OfType<ToolStripMenuItem>();

            //foreach (var menu in mainm) {
            //    menu.Text = this.dictionaryController[menu.Text];
            //    foreach(var cmenu in menu.DropDownItems.OfType<ToolStripMenuItem>()) {
            //        cmenu.Text = this.dictionaryController[cmenu.Text];
            //    }
            //}
        }
    }
}
