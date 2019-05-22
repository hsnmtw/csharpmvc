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

namespace ViewWinform.Security.Users
{
    public partial class UsersLoginView : Form
    {
        public BaseController Controller = ControllersFactory.GetController(Entities.User);

        public UsersLoginView()
        {
            model = new UserModel();
            InitializeComponent();
            Utils.FormsHelper.BindViewToModel(this,ref this.model);
        }



        private UserModel model = new UserModel();
        public UserModel Model {
            set => model = value;
            get {
                model.UserName = UserNameTextBox.Text;
                model.UserPassword = PasswordTextBox.Text;
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
    }
}
