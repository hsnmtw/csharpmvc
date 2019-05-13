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

namespace ViewWinform.Security.Users
{
    public partial class UsersLoginView : UserControl, BaseView<UserModel>
    {
        public UsersLoginView()
        {
            _model = new UserModel();
            InitializeComponent();
            Utils.FormsHelper.registerEnterAsTab(this);
        }

        public Action OnOKAction { get; set; }
        public Action OnCancelAction { get; set; }

        private UserModel _model;
        public UserModel model {
            set => throw new NotImplementedException();
            get {
                _model.User_Name = User_Name_TextBox.Text;
                _model.User_Password = Password_TextBox.Text;
                return _model;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserController ucon = new UserController();
            bool status = ucon.autheniticate(model);
            if (status)
            {
                this.OnOKAction();
            }
            else
            {
                Utils.FormsHelper.errorMessage(@"Login denied");
            }
            
        }

        private void User_Name_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
