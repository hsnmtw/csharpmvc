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

namespace ViewWinform.Security.Users
{
    public partial class UsersLoginView : Form
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
            this.RightToLeft = RightToLeft.Yes;
        }

        private void RdoEnglish_CheckedChanged(object sender, EventArgs e) {
            DictionaryController.LanguageState = LanguageState.English;
            this.RightToLeft = RightToLeft.No;
        }
    }
}
