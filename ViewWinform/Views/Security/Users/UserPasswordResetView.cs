﻿using MVCWinform.Common;
using System;
using System.Windows.Forms;
using ViewWinform.Common;

namespace MVCWinform.Security.Users {
    public partial class UserPasswordResetView : UserView {
        public UserPasswordResetView() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (UserController)DBControllersFactory.GetController(Entities.User);
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
            this.Close();
        }
    }
}
