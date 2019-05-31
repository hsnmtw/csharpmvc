using MVCHIS.Common;
using MVCHIS.Configurations;
using MVCHIS.Tools;
using MVCHIS.Utils;
using System;
using System.Windows.Forms;

namespace MVCHIS.Security.Users {
    public partial class UsersLoginView: UserView
    {
        
       // public CryptoController Encryption;

        public UsersLoginView()
        {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;
            base.Controller = (UserController)DBControllersFactory.GetController(Common.MODELS.User);
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
                //this.DialogResult = DialogResult.OK;
                MainView.Instance.Show();
                this.Hide();
                
            }
            else
            {
                Utils.FormsHelper.Error(@"Login denied");
            }
            
        }

        private void UsersLoginView_Load(object sender, EventArgs e) {
            if(Site!=null && Site.DesignMode) return;
            //Encryption = new CryptoController();
        }
    }
}
