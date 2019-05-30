using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MVCHIS.Security.Users {
    //[ForModel(Common.MODELS.User)]
    public partial class UserForm: UserView {
        public UserForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;
            base.Controller = (UserController)DBControllersFactory.GetController(Common.MODELS.User);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["FullName           ".Trim()] = txtFullName;
            Mapper["UserName           ".Trim()] = txtUserName;
            Mapper["UserPassword       ".Trim()] = txtUserPassword;
            Mapper["FailedLoginAttempts".Trim()] = txtFailedLoginAttempts;
            Mapper["LastChangePassword ".Trim()] = txtLastPasswordReset;
            Mapper["LastLoginDate      ".Trim()] = txtLastLoginDate;
            Mapper["IsActive           ".Trim()] = chkIsActive;
            Mapper["ProfileName        ".Trim()] = txtProfileName;
            Mapper["Email              ".Trim()] = txtEmail;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }


        //private UserController Controller => (UserController)DBControllersFactory.GetController(Entities.User);
        private List<ProfileEntitlementsModel> profileEntitlements;


        

        private void UserFormLoad(object sender, EventArgs e) {
            
            Model = new UserModel();
            profileEntitlements = 
                (from row 
                   in DBControllersFactory.GetController(Common.MODELS.ProfileEntitlement).Read<ProfileEntitlementsModel>()
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
            Model = Controller.Find(new UserModel() { UserName=selected }, "UserName");
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
    public class UserView : BaseView<UserModel, UserController> { }
}
