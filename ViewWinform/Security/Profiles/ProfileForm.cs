using ControllerLibrary.Security;
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

namespace ViewWinform.Security.Profiles {
    public partial class ProfileForm : Form {
        public ProfileForm() {
            InitializeComponent();
        }

        private List<string> entitlements;
        private ProfileController controller;
        private Profile_EntitlementsController profile_EntitlementsController;
        private ProfileModel _model;

        public ProfileModel Model {
            get {
                _model.Id = "".Equals(this.Id_TextBox.Text) ? 0 : int.Parse(this.Id_TextBox.Text);
                _model.Profile_Name = this.Profile_Name_TextBox.Text;
                _model.Created_By = this.Created_By_TextBox.Text;
                _model.Updated_By = this.Updated_By_TextBox.Text;
                try {
                    _model.Created_On = DateTime.Parse(this.Created_On_TextBox.Text);
                    _model.Updated_On = DateTime.Parse(this.Updated_On_TextBox.Text);
                } catch { }
                return _model;
            }
            set {
                this._model = value;
                if (value == null) _model = new ProfileModel();
                this.Id_TextBox.Text = _model.Id.ToString();
                this.Profile_Name_TextBox.Text = _model.Profile_Name;
                this.Created_By_TextBox.Text = _model.Created_By;
                this.Updated_By_TextBox.Text = _model.Updated_By;
                this.Created_On_TextBox.Text = _model.Created_By == null || "".Equals(_model.Created_By) ? "" : _model.Created_On.ToString();
                this.Updated_On_TextBox.Text = _model.Updated_By == null || "".Equals(_model.Updated_By) ? "" : _model.Updated_On.ToString();

            }
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new ProfileModel();
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox1.Items.AddRange(this.entitlements.ToArray());
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.save(this.Model);
            this.profile_EntitlementsController.clearEntitlementForProfile(this.Model.Profile_Name);
            this.profile_EntitlementsController.updateEntitlementForProfile(this.Model.Profile_Name,
                (from object entl in listBox2.Items select entl.ToString()).ToList());
            Utils.FormsHelper.successMessage("Successfully saved ...");
            Profile_Code_TextBox_OnLookUpSelected(this.Model.Profile_Name);
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.delete(this.Model);
            Utils.FormsHelper.successMessage("Successfully deleted ...");
            this.Model = new ProfileModel();
        }

        private void Profile_Code_TextBox_OnLookUpSelected(string value) {
            this.Model = this.controller.selectModelsAsList(this.controller.fields, new ProfileModel() {
                Profile_Name = value,
            }, "Profile_Name".Split(','))[0];
            var selectedEntitlements = from model in this.profile_EntitlementsController.selectModelsAsList(
                new string[] { "Entitlement_Name" },
                new Profile_EntitlementsModel() { Profile_Name = value },
                new string[] { "Profile_Name" }
            ) select model.Entitlement_Name;

            var notselectedEntitlements = from model in entitlements
                                          where !selectedEntitlements.Contains(model)
                                          orderby model
                                          select model;
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox1.Items.AddRange(notselectedEntitlements.ToArray());
            this.listBox2.Items.AddRange(selectedEntitlements.ToArray());
        }

        private void ProfileForm_Load(object sender, EventArgs e) {
            Utils.FormsHelper.registerEnterAsTab(this);
            this.controller = new ProfileController();
            this.Model = new ProfileModel();
            this.profile_EntitlementsController = new Profile_EntitlementsController();
            this.entitlements = (from model in new EntitlementController().selectModelsAsList(new string[] { "Entitlement_Name" })
                                orderby model.Entitlement_Name
                                select model.Entitlement_Name).ToList();
            Button2_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e) {
            if (this.listBox1.SelectedIndices.Count < 1) return;
            foreach (int i in this.listBox1.SelectedIndices) {
                this.listBox2.Items.Add(this.listBox1.Items[i]);
            }
            foreach (int i in (from int x in this.listBox1.SelectedIndices orderby -x select x)) {
                this.listBox1.Items.RemoveAt(i);
            }
        }

        private void Button5_Click(object sender, EventArgs e) {
            if (this.listBox2.SelectedIndices.Count < 1) return;
            foreach (int i in this.listBox2.SelectedIndices) {
                this.listBox1.Items.Add(this.listBox2.Items[i]);
            }
            foreach (int i in (from int x in this.listBox2.SelectedIndices orderby -x select x)) {
                this.listBox2.Items.RemoveAt(i);
            }
        }

        private void Button8_Click(object sender, EventArgs e) {
            this.listBox1.Items.Clear();
            this.listBox2.Items.AddRange(this.entitlements.ToArray());
        }

        private void Button7_Click(object sender, EventArgs e) {
            this.listBox2.Items.Clear();
            this.listBox1.Items.AddRange(this.entitlements.ToArray());
        }
    }
}
