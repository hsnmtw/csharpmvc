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
using MVCHIS.Common;
using MVCHIS.Security;
using ViewWpf.Views;
using ViewWpf.Views.Tools;
using ViewWpf.Views.User;

namespace ViewWpf {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public static MainWindow Instance { get; private set; }
        public MainWindow() {
            InitializeComponent();
            Instance = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            MVCHIS.Common.MVCHISSession.Instance.Initialize();
        }

        private void Window_SourceInitialized(object sender, EventArgs e) {
            TabItem tabItem = new TabItem() {
                Content = new LoginUC()
            };
            Tab.Items.Add(tabItem);
            tabItem.Header = "MAIN : Login to HIS";
            tabItem.IsSelected = true;
        }

        internal void WhenAuthenticated(UserModel um) {
            UserController CntrlUS = DBControllersFactory.GetUserController();
            var menu = CntrlUS.GetMenu(um);
            var megs = new Dictionary<string,TreeViewItem>();
            foreach(var t in menu) {
                if (megs.ContainsKey(t.Item1) == false) {
                    megs[t.Item1] = new TreeViewItem { Name = t.Item1, Header = t.Item1 };
                    Tree.Items.Add(megs[t.Item1]);
                }
                TreeViewItem mitem = new TreeViewItem { Name = t.Item3, Header = t.Item2 };
                megs[t.Item1].Items.Add(mitem);
                if ("Dictionary".Equals(mitem.Header)) {
                    mitem.Foreground = Brushes.Red;
                    mitem.MouseDoubleClick += (s, e) => {
                        TabItem tabItem = new TabItem() {
                            Content = new DictionaryUC()
                        };
                        Tab.Items.Add(tabItem);
                        tabItem.Header = "Dictionary";
                        tabItem.IsSelected = true;
                    };
                }

            }
        }
    }
}
