using ControllerLibrary.Common;
using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinform.Configurations {
    public partial class ControllersSelectionForm : Form {

        public ControllersSelectionForm() {
            InitializeComponent();
        }

        private void ControllersSelectionForm_Load(object sender, EventArgs e) {
            string WIDTHS = "{0,2}   {1,-25} {2,-70} {3}";
            this.label1.Text = string.Format(WIDTHS, "SN", "Controller", "Implementation", "Status");
            this.listBox1.Items.Clear();
            int sn = 0;
            foreach (Entities num in typeof(Entities).GetEnumValues()) {
                foreach (Type type in ControllersRegistery.Instance[num]) {
                    var forca = (ForControllerAttribute)type.GetCustomAttributes(true).First();
                    bool isEnabled = type.Equals(ControllersFactory.GetController(num).GetType());
                    listBox1.Items.Add(string.Format(WIDTHS, sn++,num,type,isEnabled? "✓" : ""));
                }
            }

        }

        private void Button1_Click(object sender, EventArgs e) {
            if (this.listBox1.SelectedIndex > -1) {
                var row = this.listBox1.SelectedItem.ToString();
                Entities num;
                Enum.TryParse( row.Substring(4,25).Trim(), out num);
                ControllersFactory.SetController(num, ControllersFactory.GetController( row.Substring(31,70).Trim() ));
            }
            ControllersSelectionForm_Load(sender, e);
        }
    }
}