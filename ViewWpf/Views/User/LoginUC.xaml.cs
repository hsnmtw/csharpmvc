using MVCHIS.Common;
using MVCHIS.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ViewWpf.Views.User {
    /// <summary>
    /// Interaction logic for LoginUC.xaml
    /// </summary>
    public partial class LoginUC : UserControl {
        public LoginUC() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            UserModel um = new UserModel {
                UserName = txtUserName.Text,
                UserPassword = txtPassword.Password
            };
            UserController controller = DBControllersFactory.GetUserController();
            if (controller.Autheniticate(um) == null) {
                MessageBox.Show("Access Denied");
            } else {
                //MessageBox.Show("Successful");
                MainWindow.Instance.WhenAuthenticated(um);
            }
        }
    }
}
