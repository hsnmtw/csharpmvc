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
        public UserModel Model {
            set => _model = value;
            get {
                _model.User_Name = User_Name_TextBox.Text;
                _model.User_Password = Password_TextBox.Text;
                return _model;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserController ucon = new UserController();
            var  model = ucon.Autheniticate(this.Model);
            if (model != null)
            {
                this.Model = (UserModel)model;
                this.OnOKAction();
            }
            else
            {
                Utils.FormsHelper.errorMessage(@"Login denied");
            }
            
        }
    }
}
