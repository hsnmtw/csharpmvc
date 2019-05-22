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

namespace ViewWinform.Security.Users {
    public partial class UserForm : SingleForm {
        public UserForm() {
            InitializeComponent();
        }


        private UserController Controller => (UserController)ControllersFactory.GetController(Entities.User);
        private UserModel model = new UserModel();
        private List<object> profileEntitlements;

        public UserModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;

                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);
                this.txtUserPasswordConfirm.Text = this.txtUserPassword.Text;
                this.txtUserName.Select();
                this.txtUserName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }

        private void UserCodeTextBoxLookUpSelected(string value) {
            this.Model = (UserModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }

        private void UserFormLoad(object sender, EventArgs e) {
            Utils.FormsHelper.BindViewToModel(this,ref this.model);
            
            this.Model = new UserModel();
            this.profileEntitlements = ControllersFactory.GetController(Entities.ProfileEntitlement).Read();
        }

        private void Button1Click(object sender, EventArgs e) {
            if (this.Controller.ResetLoginCounter(this.Model)) {
                this.txtFailedLoginAttempts.Text = "0";
                Utils.FormsHelper.Success("Failed Login attempts counter has been reset");
            } else {
                Utils.FormsHelper.Error("Something went wrong, please try again later...");
            }
        }

        private void ProfileNameLookupLookUpSelected(object sender, EventArgs e) {

        }

        private void UserNameLookupLookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtUserName.Text  = selected;
            this.Model = (UserModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }

        private void ProfileNameTextBoxTextChanged(object sender, EventArgs e) {
            this.lstEntitlements.Items.Clear();
            this.lstEntitlements.Items.AddRange((
                from ProfileEntitlementsModel model in profileEntitlements
                where model.ProfileName.Equals(txtProfileName.Text)
                orderby model.EntitlementName
                select model.EntitlementName
            ).ToArray());
        }
    }
}
