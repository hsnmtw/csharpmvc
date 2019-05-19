using ControllerLibrary.Common;
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
            //this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;

            DataTable dt = new DataTable();
            dt.Columns.Add("SN",typeof(int));
            dt.Columns.Add("Controller",typeof(ControllersEnum));
            dt.Columns.Add("Implementation",typeof(Type));
            dt.Columns.Add("Enabled",typeof(bool));

            int sn = 0;
            foreach (ControllersEnum num in typeof(ControllersEnum).GetEnumValues()) {
                foreach (Type type in ControllersRegistery.Instance[num]) {
                    ForControllerAttribute forca = (ForControllerAttribute)type.GetCustomAttributes(true).First();
                    bool isEnabled = type.Equals(ControllersFactory.GetController(num).GetType());
                    dt.Rows.Add(new object[] { sn++,num,type,isEnabled });
                }
            }

            this.dataGridView1.DataSource = dt;
        }

        private void Button1_Click(object sender, EventArgs e) {
            if(this.dataGridView1.SelectedRows.Count > 0) {
                var row = this.dataGridView1.SelectedRows[0];
                ControllersEnum num;
                Enum.TryParse( row.Cells[1].Value.ToString(), out num);
//                Type type = Type.GetType( );
                //Type type = Type.GetType("")

                ControllersFactory.SetController(num, ControllersFactory.GetController(row.Cells[2].Value.ToString()));
            }
            ControllersSelectionForm_Load(sender, e);
        }
    }
}
