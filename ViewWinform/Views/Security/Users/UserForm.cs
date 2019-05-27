using MVCWinform.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MVCWinform.Security.Users {
    [ForEntity(Entities.User)]
    public partial class UserForm : SingleForm {
        public UserForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
        }


        private UserController Controller => (UserController)DBControllersFactory.GetController(Entities.User);
        private UserModel model = new UserModel();
        private List<ProfileEntitlementsModel> profileEntitlements;

        public UserModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;

                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);
                this.txtUserPasswordConfirm.Text = this.txtUserPassword.Text;
                this.txtUserName.Select();
                this.txtUserName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }

        private void UserCodeTextBoxLookUpSelected(string value) {
            this.Model = (UserModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);
        }

        private void UserFormLoad(object sender, EventArgs e) {
            Utils.FormsHelper.BindViewToModel(this,ref this.model);
            
            this.Model = new UserModel();
            this.profileEntitlements = 
                (from ProfileEntitlementsModel row 
                   in DBControllersFactory.GetController(Entities.ProfileEntitlement).Read()
               select row).ToList();
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
            //this.txtUserName.Text  = selected;
            this.Model = (UserModel)this.Controller.Find(new UserModel() { UserName=selected }, "UserName");
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
