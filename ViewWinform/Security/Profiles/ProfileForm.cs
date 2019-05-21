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
        private BaseController controller;
        private BaseController peController;
        private ProfileModel _model;

        public ProfileModel Model {
            get {
                _model.Id = int.Parse($"0{this.Id_TextBox.Text}");
                _model.Profile_Name = this.Profile_Name_TextBox.Text;
                _model.Created_By = this.Created_By_TextBox.Text;
                _model.Updated_By = this.Updated_By_TextBox.Text;
                _model.Profile_Desc = this.Profile_Desc_TextBox.Text;
                try {
                    _model.Created_On = DateTime.Parse(this.Created_On_TextBox.Text);
                    _model.Updated_On = DateTime.Parse(this.Updated_On_TextBox.Text);
                } catch { }
                return _model;
            }
            set {
                this._model = value;
                this.listBox2.Items.Clear();
                this.listBox1.Items.Clear();
                if(this.entitlements!=null) this.listBox1.Items.AddRange(this.entitlements.ToArray());
                if (value == null) _model = new ProfileModel();
                this.Id_TextBox.Text = _model.Id.ToString();
                this.Profile_Name_TextBox.Text = _model.Profile_Name;
                this.Created_By_TextBox.Text = _model.Created_By;
                this.Updated_By_TextBox.Text = _model.Updated_By;
                this.Profile_Desc_TextBox.Text = _model.Profile_Desc;
                this.Created_On_TextBox.Text = _model.Created_By == null || "".Equals(_model.Created_By) ? "" : _model.Created_On.ToString();
                this.Updated_On_TextBox.Text = _model.Updated_By == null || "".Equals(_model.Updated_By) ? "" : _model.Updated_On.ToString();

                this.Profile_Name_TextBox.Select();
                this.Profile_Name_TextBox.Focus();
            }
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new ProfileModel();
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox1.Items.AddRange(this.entitlements.ToArray());
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.Save(this.Model);
            this.peController.Dispatch("DeleteEntitlementForProfile",this.Model.Profile_Name);
            this.peController.Dispatch("UpdateEntitlementForProfile", this.Model.Profile_Name,
                (from object entl in listBox2.Items select entl.ToString()).ToList());
            Utils.FormsHelper.successMessage("Successfully saved ...");
            this.Profile_Name_Lookup_LookUpSelected(e,new LookupEventArgs(this.Model.Profile_Name));
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.Delete(this.Model);
            Utils.FormsHelper.successMessage("Successfully deleted ...");
            this.Model = new ProfileModel();
        }


        private void ProfileForm_Load(object sender, EventArgs e) {
            Utils.FormsHelper.registerEnterAsTab(this);
            this.controller = ControllersFactory.GetController(Entities.Profile);
            this.Model = new ProfileModel();
            this.peController = (ProfileEntitlementsController)ControllersFactory.GetController(Entities.ProfileEntitlement);
            this.entitlements = (from EntitlementModel model in ControllersFactory.GetController(Entities.Entitlement).Read()
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
            this.listBox2.Items.Clear();
            this.listBox2.Items.AddRange(this.entitlements.ToArray());
        }

        private void Button7_Click(object sender, EventArgs e) {
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox1.Items.AddRange(this.entitlements.ToArray());
        }

        private void Profile_Name_Lookup_LookUpSelected(object sender, EventArgs e) {
            string value = ((LookupEventArgs)e).SelectedValueFromLookup;

            this.Model = (ProfileModel)this.controller.Read(this.Model, this.controller.GetMetaData().GetUniqueKeyFields).First();

            var selectedEntitlements = from ProfileEntitlementsModel model in this.peController.Read
                                       (
                                            new ProfileEntitlementsModel() { Profile_Name = value },
                                            new string[] { "Profile_Name" }
                                        )
                                       select model.Entitlement_Name;

            var notselectedEntitlements = from model in entitlements
                                          where !selectedEntitlements.Contains(model)
                                          orderby model
                                          select model;
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox1.Items.AddRange(notselectedEntitlements.ToArray());
            this.listBox2.Items.AddRange(selectedEntitlements.ToArray());
        }
    }
}
