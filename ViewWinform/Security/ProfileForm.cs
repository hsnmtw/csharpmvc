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

namespace ViewWinform.Security.Profiles {
    public partial class ProfileForm : SingleForm {
        public ProfileForm() {
            InitializeComponent();
        }

        private List<string> entitlements = null;
        public BaseController Controller => ControllersFactory.GetController(Entities.Profile);
        private BaseController peController;
        private ProfileModel model = new ProfileModel();

        public ProfileModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtProfileName.Select();
                this.txtProfileName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        private void Button2Click(object sender, EventArgs e) {
            this.Model = new ProfileModel();
            this.lstNotSelectedEntitlements.Items.Clear();
            this.lstSelectedEntitlements.Items.Clear();
            this.lstNotSelectedEntitlements.Items.AddRange(this.entitlements.ToArray());
        }

        private void ProfileFormLoad(object sender, EventArgs e) {
            Utils.FormsHelper.BindViewToModel(this,ref this.model);
            
            this.Model = new ProfileModel();
            this.peController = (ProfileEntitlementsController)ControllersFactory.GetController(Entities.ProfileEntitlement);
            this.entitlements = (from EntitlementModel model in ControllersFactory.GetController(Entities.Entitlement).Read()
                                orderby model.EntitlementName
                                select model.EntitlementName).ToList();
            Button2Click(sender, e);
        }

        private void Button1Click(object sender, EventArgs e) {
            if (this.lstNotSelectedEntitlements.SelectedIndices.Count < 1) return;
            foreach (int i in this.lstNotSelectedEntitlements.SelectedIndices) {
                this.lstSelectedEntitlements.Items.Add(this.lstNotSelectedEntitlements.Items[i]);
            }
            foreach (int i in (from int x in this.lstNotSelectedEntitlements.SelectedIndices orderby -x select x)) {
                this.lstNotSelectedEntitlements.Items.RemoveAt(i);
            }
        }

        private void Button5Click(object sender, EventArgs e) {
            if (this.lstSelectedEntitlements.SelectedIndices.Count < 1) return;
            foreach (int i in this.lstSelectedEntitlements.SelectedIndices) {
                this.lstNotSelectedEntitlements.Items.Add(this.lstSelectedEntitlements.Items[i]);
            }
            foreach (int i in (from int x in this.lstSelectedEntitlements.SelectedIndices orderby -x select x)) {
                this.lstSelectedEntitlements.Items.RemoveAt(i);
            }
        }

        private void Button8Click(object sender, EventArgs e) {
            this.lstNotSelectedEntitlements.Items.Clear();
            this.lstSelectedEntitlements.Items.Clear();
            this.lstSelectedEntitlements.Items.AddRange(this.entitlements.ToArray());
        }

        private void Button7Click(object sender, EventArgs e) {
            this.lstNotSelectedEntitlements.Items.Clear();
            this.lstSelectedEntitlements.Items.Clear();
            this.lstNotSelectedEntitlements.Items.AddRange(this.entitlements.ToArray());
        }

        private void ProfileNameLookupLookUpSelected(object sender, EventArgs e) {
            string value = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtProfileName.Text  = value;
            this.Model = (ProfileModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();

            var selectedEntitlements = from ProfileEntitlementsModel model in this.peController.Read
                                       (
                                            new ProfileEntitlementsModel() { ProfileName = value },
                                            new string[] { "ProfileName" }
                                        )
                                       select model.EntitlementName;

            var notselectedEntitlements = from model in entitlements
                                          where !selectedEntitlements.Contains(model)
                                          orderby model
                                          select model;
            this.lstNotSelectedEntitlements.Items.Clear();
            this.lstSelectedEntitlements.Items.Clear();
            this.lstNotSelectedEntitlements.Items.AddRange(notselectedEntitlements.ToArray());
            this.lstSelectedEntitlements.Items.AddRange(selectedEntitlements.ToArray());
        }
    }
}
