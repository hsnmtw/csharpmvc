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

namespace ViewWinform.Security.Users {
    public partial class UserPasswordResetView : UserControl , BaseView<UserModel>{
        public UserPasswordResetView() {
            InitializeComponent();
            Utils.FormsHelper.registerEnterAsTab(this);
        }

        public Action OnOKAction { get; set; }
        public Action OnCancelAction { get; set; }

        private UserModel _model;

        public UserModel Model {
            get {
                _model.Id = int.Parse(this.Id_TextBox.Text,0);
                _model.User_Name = this.UserName_TextBox.Text;
                _model.User_Password = this.Password_TextBox.Text;
                return _model;
            }
            set {
                _model = value;
                this.Id_TextBox.Text = _model.Id.ToString();
                this.UserName_TextBox.Text = _model.User_Name;
            }
        }

        private void Button1_Click(object sender, EventArgs e) {
            if (this.Password_TextBox.Text.Equals(this.Confirm_TextBox.Text)) {
                OnOKAction();
            } else {
                Utils.FormsHelper.errorMessage("Password and confirmation don't match");
            }
        }

        private void Button2_Click(object sender, EventArgs e) {
            OnCancelAction();
        }
    }
}
