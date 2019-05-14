using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLibrary.Common;
using ModelLibrary.Security;
using ControllerLibrary.Utils;
using ControllerLibrary.Security;

namespace ViewWinform.Security.Profiles
{
    public partial class ProfilesFormView : UserControl,BaseView<ProfileModel>
    {

        public ProfileModel _model = new ProfileModel();
        public ProfileModel model
        {
            get {
                _model.Id = int.Parse( this.Id_TextBox.Text );
                _model.Profile_Name = Profile_Name_TextBox.Text;
                return _model;
            }
            set {
                _model = value;
                this.Id_TextBox.Text = _model == null ? "" : _model.Id.ToString();
                this.Profile_Name_TextBox.Text = _model == null ? "" : _model.Profile_Name;
                this.advancedCheckedListBox1.setAll(false);
                if (_model != null && _model.Id != null && !"".Equals(_model.Id)) {
                    var pec = new Profile_EntitlementsController();
                    var selected = pec.getEntitlementsByProfile(_model.Profile_Name);
                    foreach (DataRow row in selected.Rows) {
                        for (int i = 0; i < this.advancedCheckedListBox1.Items.Count; i++) {
                            if (row["Entitlement_Name"].Equals(this.advancedCheckedListBox1.getItemAtIndex(i))) {
                                this.advancedCheckedListBox1.setCheckedItem(i, true);
                            }
                        }
                    }
                }
            }
        }

        public ProfilesFormView()
        {
            InitializeComponent();
            Utils.FormsHelper.registerEnterAsTab(this);
            EntitlementController entitlement_controller = new EntitlementController();
            var all = entitlement_controller.getAllEntitlementsWithoutId();

            this.advancedCheckedListBox1.setDataSource(all);
        }

        public List<string> getSelectedEntitlements() {
            return this.advancedCheckedListBox1.getCheckedRows();
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    var controller = new ProfileController();


        //    if (Id_TextBox.Text.Equals(""))
        //    {
        //        //check if the profile will result in a duplicate entry
        //        var fmodel = controller.find(model);
        //        if (fmodel != null)
        //        {
        //            MessageBox.Show(string.Format("Profile Name : {0} is already in use", fmodel.Profile_Name), "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //    }


        //    if (Id_TextBox.Text.Equals("")) {
        //        controller.insert(model);
        //    }
        //    else
        //    {
        //        controller.update(model);
        //    }

        //    model = controller.find(model);
        //    Profile_EntitlementsController pec = new Profile_EntitlementsController();
        //    pec.clearEntitlementForProfile(model.Profile_Name);

        //    List<string> list = this.advancedCheckedListBox1.getCheckedRows();

        //    pec.updateEntitlementForProfile(model.Profile_Name, list);
        //    this.OnOKAction();
        //}
        

        private void ProfilesFormView_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.advancedCheckedListBox1.setAll(this.checkBox1.Checked);
        }
    }
}
