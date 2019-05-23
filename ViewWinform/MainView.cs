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

namespace ViewWinform
{
    public partial class MainView : Form, IDisposable
    {
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
            InitializeComponent();
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
            tsProgressBar.Value = 0;

            tssLabelStatus.Text = "Connecting to database";
            DBConnectionManager.Instance.Open();
            tsProgressBar.Value += 25;


            tssLabelStatus.Text = "Loading Entities"; 
            EntitiesFactory.InitEntitiesMap();
            tsProgressBar.Value += 25;

            tssLabelStatus.Text = "Loading Controllers";
            ControllersFactory.InitControllersMap();
            tsProgressBar.Value += 25;


            tssLabelStatus.Text = "Loading Menus";
            LogOutToolStripMenuItemClick(sender, e);
            LogInToolStripMenuItemClick(sender, e);
            tsProgressBar.Value += 25;
        }


        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsersToolStripMenuItemClick(object sender, EventArgs e)
        {
            //Utils.FormsHelper.showView(this, new UsersListView());
            new UserForm() { MdiParent = this }.Show();
        }

        private void ProfilesToolStripMenuItemClick(object sender, EventArgs e)
        {
            new ProfileForm() { MdiParent = this }.Show();
        }

        private void EntitlementsToolStripMenuItemClick(object sender, EventArgs e)
        {
            new EntitlementForm() { MdiParent = this }.Show();
        }

        private void PorfileEntitelmentsToolStripMenuItemClick(object sender, EventArgs e)
        {
            //Utils.FormsHelper.showView(this, new PorfileEntitlementsView());
        }

        private void LogOutToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(Session.Instance.CurrentUser != null) {
                var audit = (AuditController)ControllersFactory.GetController(Entities.Audit);
                audit.registerEvent(new AuditModel() {
                    UserName = Session.Instance.CurrentUser.UserName,
                    EventComments = "Logout ..."
                });
            }
            Session.Instance.CurrentUser = null;
            this.tsslCurrentUser.Text = "Guest";
            foreach (ToolStripMenuItem mi in this.menus.Values)
            {
                mi.Enabled = false;
            }            
        }

        private void LogInToolStripMenuItemClick(object sender, EventArgs e)
        {
            var loginview = new UsersLoginView();
            if (loginview.ShowDialog() == DialogResult.OK) {
                Session.Instance.CurrentUser = loginview.Model;
                var pec = (ProfileEntitlementsController)ControllersFactory.GetController(Entities.ProfileEntitlement);
                var entitlements = pec.Read(new ProfileEntitlementsModel() {
                    ProfileName = loginview.Model.ProfileName,
                    AllowRead = true
                },"ProfileName","AllowRead");

                foreach (ProfileEntitlementsModel row in entitlements) {
                    var EntitlementName = row.EntitlementName;
                    if (this.menus.ContainsKey(EntitlementName))
                        this.menus[EntitlementName].Enabled = true;
                }
            }
        }

        private void SQLViewerToolStripMenuItemClick(object sender, EventArgs e)
        {
            var sqlview = new Utils.SQLView();
            sqlview.MdiParent = this;
            //sqlview.WindowState = FormWindowState.Maximized;
            sqlview.Size = new Size(sqlview.Width + 20, sqlview.Height + 120);
            sqlview.Show();
        }

        private void EncryptionToolToolStripMenuItemClick(object sender, EventArgs e)
        {
            new Configurations.CryptoForm() { MdiParent = this }.Show();
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
            //new CountryView() { MdiParent = this }.Show();
            new CountryForm() { MdiParent = this }.Show();
        }

        private void AuditToolStripMenuItemClick(object sender, EventArgs e) {
            new AuditView() { MdiParent = this }.Show();
        }

        private void TableDesignerToolStripMenuItemClick(object sender, EventArgs e) {
            new ModelLibrary.Utils.TableDesigner.TableDesignerView() { MdiParent = this }.Show();
        }

        private void CompoundsToolStripMenuItemClick(object sender, EventArgs e) {
            new Housing.Compounds.CompoundForm() { MdiParent = this }.Show();
        }

        private void ConfigurationsToolStripMenuItemClick(object sender, EventArgs e) {
            new Configurations.ConfigurationsForm() { MdiParent = this }.Show();
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
            new Housing.Buildings.BuildingForm() { MdiParent = this }.Show();
        }

        private void RoomsToolStripMenuItemClick(object sender, EventArgs e) {
            new Housing.Rooms.RoomForm() { MdiParent = this }.Show();
        }

        private void ControllersRegistryToolStripMenuItemClick(object sender, EventArgs e) {
            new Configurations.ControllersSelectionForm() { MdiParent = this }.Show();
        }

        private void CompactAndRepairToolStripMenuItemClick(object sender, EventArgs e) {
            new Utils.CompactAndRepairForm() { MdiParent = this }.Show();
        }

        private void MainViewFormClosing(object sender, FormClosingEventArgs e) {
            try {
                DBConnectionManager.Instance.Close();
            } catch { }
        }

        private void BuildingTypesToolStripMenuItemClick(object sender, EventArgs e) {
            new Housing.BuildingTypes.BuildingTypeForm() { MdiParent = this }.Show();
        }

        private void ClientTypesToolStripMenuItemClick(object sender, EventArgs e) {
            new ClientTypeForm() { MdiParent = this }.Show();
        }

        private void ClientsToolStripMenuItemClick(object sender, EventArgs e) {
            new ClientForm() { MdiParent = this }.Show();
        }

        private void ProjectsToolStripMenuItemClick(object sender, EventArgs e) {
            new ProjectForm() { MdiParent = this }.Show();
        }

        private void BillingCategoriesToolStripMenuItemClick(object sender, EventArgs e) {
            new BillingCategoryForm() { MdiParent = this }.Show();
        }

        private void AccomodationClassesToolStripMenuItemClick(object sender, EventArgs e) {
            new AccomodationClassForm() { MdiParent = this }.Show();
        }

        private void NewToolStripMenuItemClick(object sender, EventArgs e) {
            //try { ((Button)((Form)this.ActiveMdiChild).Controls.Find("btnNew", true).First()).PerformClick(); } catch { }
            ((ISingleForm)this.ActiveMdiChild).PerformAction("New");
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e) {
            //try { ((Button)((Form)this.ActiveMdiChild).Controls.Find("btnSave", true).First()).PerformClick(); } catch { }
            ((ISingleForm)this.ActiveMdiChild).PerformAction("Save");
        }

        private void FoodClassesToolStripMenuItemClick(object sender, EventArgs e) {
            new Billing.FoodClassForm() { MdiParent = this }.Show();
        }

        private void CloseToolStripMenuItemClick(object sender, EventArgs e) {
            try {
                this.ActiveMdiChild.Close();
            } catch { }
        }

        private void FoodTypesToolStripMenuItem_Click(object sender, EventArgs e) {
            new FoodTypeForm() { MdiParent = this }.Show();
        }

        private void DuplicateToolStripMenuItem_Click(object sender, EventArgs e) {
            ((ISingleForm)this.ActiveMdiChild).PerformAction("Duplicate");
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e) {
            //try {((Button)((Form)this.ActiveMdiChild).Controls.Find("btnRemove", true).First()).PerformClick();} catch {}
            ((ISingleForm)this.ActiveMdiChild).PerformAction("Remove");
        }

        private void IdentificationTypesToolStripMenuItem_Click(object sender, EventArgs e) {
            new IdentificationTypeForm() { MdiParent = this }.Show();
        }

        private void EntitlementGroupsToolStripMenuItem_Click(object sender, EventArgs e) {
            new EntitlementGroupForm() { MdiParent = this }.Show();
        }
    }
}
