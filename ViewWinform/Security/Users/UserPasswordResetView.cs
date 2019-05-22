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

namespace ViewWinform.Security.Users {
    public partial class UserPasswordResetView : Form {
        public UserPasswordResetView() {
            InitializeComponent();
            Utils.FormsHelper.BindViewToModel(this, ref this.model);
        }

        public UserController Controller = (UserController)ControllersFactory.GetController(Entities.User);
        private UserModel model = new UserModel();

        public UserModel Model {
            get {
                model.Id = int.Parse($"0{this.txtId.Text}");
                model.UserName = this.txtUserName.Text.Trim();
                model.UserPassword = this.txtUserPassword.Text.Trim();
                return model;
            }
            set {
                model = value;
                this.txtId.Text = $"{model.Id}";
                this.txtUserName.Text = model.UserName;
            }
        }

        private void Button1Click(object sender, EventArgs e) {
            if (Model.UserPassword.Equals(txtConfirmPassword.Text.Trim())) {
                Controller.ResetPassword(this.Model);
                Utils.FormsHelper.Success("Password has been reset");
            } else {
                Utils.FormsHelper.Error("Password and confirmation don't match");
            }
        }

        private void Button2Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
