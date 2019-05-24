using ControllerLibrary.Common;
using ControllerLibrary.Security;
using ModelLibrary.Common;
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
using ViewWinform.Common;

namespace ViewWinform.Security {
    public partial class ProfileForm : SingleForm {
        const char C = 'C', R = 'R', U = 'U', D = 'D', E = '-';
        private Dictionary<string, List<string>> entitlementsByGroup = new Dictionary<string, List<string>>();
        private List<string> allEntitlements = new List<string>();

        public IDBController Controller;
        private IDBController peController;
        private ProfileModel model;

        public ProfileForm() {
            InitializeComponent(); if (DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.Profile);
            peController = DBControllersFactory.GetController(Entities.ProfileEntitlement);
            model = new ProfileModel();
        }

        

        public ProfileModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                RequeryEntitlements();

                this.txtProfileName.Select();
                this.txtProfileName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }

        public void RequeryEntitlements() {
            this.lstEntitlements.Items.Clear();
            List<string> filter;
            string eg = $"{this.cmbEntitelmentsGroup.SelectedItem}";
            if ("All".Equals(eg)) {
                filter = allEntitlements;
            } else if (this.entitlementsByGroup.ContainsKey(eg)) { 
                filter = this.entitlementsByGroup[eg];
            } else {
                filter = new List<string>();
            }
            this.lstEntitlements.Items.AddRange((
                    from ProfileEntitlementsModel row
                    in peController.Read(new ProfileEntitlementsModel() { ProfileName= this.model.ProfileName }, new string[] { "ProfileName" })
                 where filter.Contains(row.EntitlementName)
               orderby row.EntitlementName 
                select $"{(row.AllowCreate?C:E)}{(row.AllowRead?R:E)}{(row.AllowUpdate?U:E)}{(row.AllowDelete?D:E)}  {row.EntitlementName}"
            ).ToArray());
        }

        private void ProfileFormLoad(object sender, EventArgs e) {


       

        Utils.FormsHelper.BindViewToModel(this,ref this.model);
            this.cmbEntitelmentsGroup.Items.Clear();
            this.cmbEntitelmentsGroup.Items.Add("All");
            this.cmbEntitelmentsGroup.Text = "All";
            this.cmbEntitelmentsGroup.Items.AddRange((
               from EntitlementGroupModel eg
               in DBControllersFactory.GetController(Entities.EntitlementGroup).Read()
               orderby eg.EntitlementGroupName
               select eg.EntitlementGroupName
            ).ToArray());

            foreach(EntitlementModel em in DBControllersFactory.GetController(Entities.Entitlement).Read().OrderBy(x => ((EntitlementModel)x).EntitlementName )) {
                if (this.entitlementsByGroup.ContainsKey(em.EntitlementGroupName) == false) {
                    this.entitlementsByGroup[em.EntitlementGroupName] = new List<string>();
                }
                this.entitlementsByGroup[em.EntitlementGroupName].Add(em.EntitlementName);
                this.allEntitlements.Add(em.EntitlementName);
            }
        }

        private void CmbEntitelmentsGroup_SelectedIndexChanged(object sender, EventArgs e) {
            RequeryEntitlements();
        }

        private void BtnOpen_Click(object sender, EventArgs e) {
            if (this.lstEntitlements.SelectedIndex < 0) return;
            string profile = this.txtProfileName.Text;
            string entitlement = $"{this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex]}".Substring(6).Trim();
            var pef = new ProfileEntitlementForm();
            var pem = (ProfileEntitlementsModel)pef.Controller.Read(new ProfileEntitlementsModel() {
                ProfileName = profile,
                EntitlementName = entitlement
            }, new string[] { "ProfileName", "EntitlementName" }).First();
            
            pef.Model = pem;
            if (pef.ShowDialog() == DialogResult.OK) {
                this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex] = $"{(pef.Model.AllowCreate?C:E)}{(pef.Model.AllowRead?R:E)}{(pef.Model.AllowUpdate?U:E)}{(pef.Model.AllowDelete?D:E)}  {entitlement}";
            }

        }

        private void ProfileNameLookupLookUpSelected(object sender, EventArgs e) {
            string value = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtProfileName.Text  = value;
            this.Model = (ProfileModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }

        private void BtnAllowAll_Click(object sender, EventArgs e) {
            if (this.lstEntitlements.SelectedIndex < 0) return;
            string profile = this.txtProfileName.Text;
            string entitlement = $"{this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex]}".Substring(6).Trim();
            ((ProfileEntitlementsController)peController).ChangePermissions(profile, entitlement, true, true, true, true);
            this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex] = $"{C}{R}{U}{D}  {entitlement}";
            //Utils.FormsHelper.Success("All entitlements were allowed");
            MainView.Instance.setProgress("All entitlements were allowed", 100);
        }

        private void BtnUnallowAll_Click(object sender, EventArgs e) {
            if (this.lstEntitlements.SelectedIndex < 0) return;
            string profile = this.txtProfileName.Text;
            string entitlement = $"{this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex]}".Substring(6).Trim();
            ((ProfileEntitlementsController)peController).ChangePermissions(profile, entitlement, false, false, false, false);
            this.lstEntitlements.Items[this.lstEntitlements.SelectedIndex] = $"{E}{E}{E}{E}  {entitlement}";
            //Utils.FormsHelper.Success("All entitlements were un-allowed");
            MainView.Instance.setProgress("All entitlements were un-allowed", 100);
        }
    }
}
