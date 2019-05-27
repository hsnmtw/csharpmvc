using MVCWinform.Common;
using MVCWinform.Configurations;
using MVCWinform.Tools;
using MVCWinform.Utils;
using System;
using System.Windows.Forms;

namespace MVCWinform.Security.Users {
    public partial class UsersLoginView : SingleForm
    {
        public IDBController Controller;
        public CryptoController Encryption;

        public UsersLoginView()
        {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
        }



        private UserModel model = new UserModel();
        public UserModel Model {
            set => model = value;
            get {
                model.UserName = txtUserName.Text;
                model.UserPassword = Encryption.Process(new CryptoModel() { InputText = txtPassword.Text }).Encrypted;
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
            Controller = DBControllersFactory.GetController(Entities.User);
            model = new UserModel();
            Utils.FormsHelper.BindViewToModel(this, ref this.model);
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
