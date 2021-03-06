﻿using MVCHIS.Common;
using MVCHIS.Configurations;
using MVCHIS.Tools;
using MVCHIS.Utils;
using System;
using System.Windows.Forms;

namespace MVCHIS.Security.Users {
    public partial class UsersLoginView: UserView
    {

        public Action<UserModel> GoClicked;

        public UsersLoginView(){
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            Mapper["UserName"] = txtUserName;
            Mapper["UserPassword"] = txtPassword;
            PickList[btnPLUser] = txtId;
        }

        private void UsersLoginView_Load(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            GoClicked?.Invoke(Model);
        }

        private void TxtId_TextChanged(object sender, EventArgs e) {
            txtUserName.Text = DBControllersFactory.FK(MODELS.User, txtId.Text);
        }
    }
}
