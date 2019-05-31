using MVCHIS.Common;
using System;
using System.Windows.Forms;

namespace MVCHIS.Security.Users {
    public partial class UserPasswordResetView : UserView {
        public UserPasswordResetView() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;
            base.Controller = (UserController)DBControllersFactory.GetController(Common.MODELS.User);
        }

        private void Button1Click(object sender, EventArgs e) {
            if (Model.UserPassword.Equals(txtConfirmPassword.Text.Trim())) {
                Controller.ResetPassword(this.Model);
                Utils.FormsHelper.Success("Password has been reset");
            } else {
                Utils.FormsHelper.Error("Password and confirmation don't match");
            }
        }

        private void Button2Click(object sender, EventArgs e) {
            //this.Close();
        }
    }
}
