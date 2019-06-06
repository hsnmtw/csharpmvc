using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace ViewWpf.Views.Utils {
    /// <summary>
    /// Interaction logic for PickListWindow.xaml
    /// </summary>
    public partial class PickListWindow : Window {

        public Action<int> Selected { get; set; }

        public PickListWindow() {
            InitializeComponent();
        }

        public void SetData(Dictionary<int,string> data) {
            dg.ItemsSource = data;
        }

        private int id;

        private void Button_Click(object sender, RoutedEventArgs e) {
            
            Selected?.Invoke(id);
        }

        private void Dg_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var row = (KeyValuePair<int, string>)((DataGrid)sender).SelectedValue;
            id = row.Key;
        }
    }
}
