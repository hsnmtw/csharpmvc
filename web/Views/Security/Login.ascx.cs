using MVCHIS.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web.Views.Security {
    public partial class Login1 : System.Web.UI.UserControl {
        protected void Page_Load(object sender, EventArgs e) {

        }

        private UserModel Model {
            get => new UserModel {
                UserName = txtUserName.Text,
                UserPassword = txtUserPassword.Text
            };
        }

        public Action<UserModel> GoClicked { get; set; }


        protected void Button1_Click(object sender, EventArgs e) {
            GoClicked?.Invoke(Model);
        }
    }
}