using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MVCHIS.Configurations {
    public partial class ControllersSelectionForm : Form {

        public ControllersSelectionForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;;
        }

        private void ControllersSelectionFormLoad(object sender, EventArgs e) {
            string WIDTHS = "{0,2}   {1,-25} {2,-70} {3}";
            this.label1.Text = string.Format(WIDTHS, "SN", "Controller", "Implementation", "Status");
            this.listBox1.Items.Clear();
            int sn = 0;
            foreach (MODELS num in typeof(MODELS).GetEnumValues()) {
                foreach (Type type in ControllersRegistery.Instance[num]) {
                    //var forca = (ForModelAttribute)type.GetCustomAttributes(true).OfType<ForModelAttribute>().First();
                    //bool isEnabled = type.Equals(DBControllersFactory.GetController(num).GetType());
                    listBox1.Items.Add(string.Format(WIDTHS, sn++,num,type, FormsHelper.TICK ));
                }
            }

        }

        private void Button1Click(object sender, EventArgs e) {
            if (this.listBox1.SelectedIndex > -1) {
                var row = this.listBox1.SelectedItem.ToString();
                MODELS num;
                Enum.TryParse( row.Substring(4,25).Trim(), out num);
                DBControllersFactory.SetController(num, DBControllersFactory.GetController( row.Substring(31,70).Trim() ));
            }
            ControllersSelectionFormLoad(sender, e);
        }
    }
}