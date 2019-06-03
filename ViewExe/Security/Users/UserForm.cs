using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MVCHIS.Security.Users {
    //[ForModel(Common.MODELS.User)]
    public partial class UserForm: UserView {

        private ProfileController CntrlPR;


        public UserForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["FullName"] = txtFullName;
            Mapper["UserName"] = txtUserName;
            Mapper["UserPassword"] = txtUserPassword;
            Mapper["FailedLoginAttempts"] = txtFailedLoginAttempts;
            Mapper["LastChangePassword"] = txtLastPasswordReset;
            Mapper["LastLoginDate"] = txtLastLoginDate;
            Mapper["IsActive"] = chkIsActive;
            Mapper["ProfileId"] = txtProfileId;
            Mapper["Email"] = txtEmail;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void UserFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            CntrlPR = (ProfileController)DBControllersFactory.GetController<ProfileModel>();


        }

        private void Button1Click(object sender, EventArgs e) {
            if (((UserController)Controller).ResetLoginCounter(Model)) {
                txtFailedLoginAttempts.Text = "0";
                Utils.FormsHelper.Success("Failed Login attempts counter has been reset");
            } else {
                Utils.FormsHelper.Error("Something went wrong, please try again later...");
            }
        }

        private void ProfileNameTextBoxTextChanged(object sender, EventArgs e) {

        }

        private void TxtProfileId_TextChanged(object sender, EventArgs e) {
            int.TryParse(txtProfileId.Text, out int profileId);
            txtProfileName.Text = CntrlPR.Find(new ProfileModel() { Id = profileId }, "Id")?.ProfileName;
        }

        private void UserNameLookup_LookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new UserModel() { UserName = selected }, "UserName");
        }
    }
}
