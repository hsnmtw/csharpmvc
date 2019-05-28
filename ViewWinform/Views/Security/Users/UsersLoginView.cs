﻿using MVCWinform.Common;
using MVCWinform.Configurations;
using MVCWinform.Tools;
using MVCWinform.Utils;
using System;
using System.Windows.Forms;
using ViewWinform.Common;

namespace MVCWinform.Security.Users {
    public partial class UsersLoginView: UserView
    {
        //public IDBController Controller;
        public CryptoController Encryption;

        public UsersLoginView()
        {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (UserController)DBControllersFactory.GetController(Entities.User);
            Mapper["UserName"     ] = txtUserName;
            Mapper["UserPassword" ] = txtPassword;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            
            var model = Controller.Autheniticate(this.Model);
            if (model != null)
            {
                this.Model = model;
                MainView.Instance.WhenAuthenticated(model);
                this.DialogResult = DialogResult.OK;
                MainView.Instance.Show();
                this.Visible = false;
                
            }
            else
            {
                Utils.FormsHelper.Error(@"Login denied");
            }
            
        }

        private void UsersLoginView_Load(object sender, EventArgs e) {
            if(Site != null && Site.DesignMode) return;
            Encryption = new CryptoController();
        }

        private void RdoArabic_CheckedChanged(object sender, EventArgs e) {
            DictionaryController.LanguageState = LanguageState.Arabic;
            FormsHelper.ApplyLanguageLocalization(this);
            FormsHelper.ApplyLanguageLocalization(MainView.Instance);
        }

        private void RdoEnglish_CheckedChanged(object sender, EventArgs e) {
            DictionaryController.LanguageState = LanguageState.English;
            FormsHelper.ApplyLanguageLocalization(this);
            FormsHelper.ApplyLanguageLocalization(MainView.Instance);
        }
    }
}
