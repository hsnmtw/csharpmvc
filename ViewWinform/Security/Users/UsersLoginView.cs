using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLibrary.Security;
using ControllerLibrary.Security;
using ControllerLibrary.Common;
using ModelLibrary.Common;
using ControllerLibrary.Tools;
using ViewWinform.Utils;
using ViewWinform.Common;

namespace ViewWinform.Security.Users
{
    public partial class UsersLoginView : SingleForm
    {
        public IDBController Controller = DBControllersFactory.GetController(Entities.User);

        public UsersLoginView()
        {
            InitializeComponent(); if (DesignMode) return;
            model = new UserModel();
            Utils.FormsHelper.BindViewToModel(this,ref this.model);
        }



        private UserModel model = new UserModel();
        public UserModel Model {
            set => model = value;
            get {
                model.UserName = txtUserName.Text;
                model.UserPassword = txtPassword.Text;
                return model;
            }
        }

        private void Button1Click(object sender, EventArgs e)
        {
            
            var model = (UserModel)Controller.Dispatch("Autheniticate", this.Model); //ucon.Autheniticate(this.Model);
            if (model != null)
            {
                this.Model = model;
                MainView.Instance.WhenAuthenticated(model);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Utils.FormsHelper.Error(@"Login denied");
            }
            
        }

        private void UsersLoginView_Load(object sender, EventArgs e) {

        }

        private void RdoArabic_CheckedChanged(object sender, EventArgs e) {
            DictionaryController.LanguageState = LanguageState.Arabic;
            FormsHelper.ApplyLanguageLocalization(this);
            MainView.Instance.RightToLeft = RightToLeft.Yes;
            MainView.Instance.RightToLeftLayout = true;
            this.SuspendLayout();
            //this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ResumeLayout();
        }

        private void RdoEnglish_CheckedChanged(object sender, EventArgs e) {
            DictionaryController.LanguageState = LanguageState.English;
            MainView.Instance.RightToLeft = RightToLeft.No;
            MainView.Instance.RightToLeftLayout = false;
            FormsHelper.ApplyLanguageLocalization(this);
            this.SuspendLayout();
            //this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ResumeLayout();
        }
    }
}
