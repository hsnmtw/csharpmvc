using MVCHIS.Common;
using MVCHIS.Tools;
using MVCHIS.Utils;
using MVCHIS.Utils.Extensions;
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
using ViewWpf.Views.Utils;

namespace ViewWpf.Views.Tools {
    /// <summary>
    /// Interaction logic for DictionaryUC.xaml
    /// </summary>
    public partial class DictionaryUC : UserControl {

        public DictionaryModel Model {
            get => new DictionaryModel {
                Id = id.Text.ToInteger(),
                WordInEnglish = english.Text,
                WordInArabic = arabic.Text
            };
            set {
                id.Text = value.Id.ToString();
                english.Text = value.WordInEnglish;
                arabic.Text = value.WordInArabic;
                cb.Text = value.CreatedBy;
                co.Text = value.CreatedOn.ToString();
                ub.Text = value.UpdatedBy;
                uo.Text = value.UpdatedOn.ToString();
            }
        }

        public DictionaryUC() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

        }

        private void Find_Click(object sender, RoutedEventArgs e) {
            var CntrlDC = DBControllersFactory.GetDictionaryController();
            ForeignKeys.Instance.Put(CntrlDC);
            PickListWindow picklist = new PickListWindow();
            picklist.SetData(ForeignKeys.Instance.GetLookUp("Dictionary"));
            picklist.Show();
            picklist.Selected += (id) => {
                Model = CntrlDC.Find(new DictionaryModel { Id=id }, "Id");
                picklist.Close();
            };
        }
    }
}
