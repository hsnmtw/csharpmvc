using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerLibrary.Configurations;
using DAO;

namespace ViewWinform.Utils {
    public partial class CompactAndRepairForm : Form {
        public CompactAndRepairForm() {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e) {
            CompactAndRepairAsync();
        }

        public void CompactAndRepairAsync() {
            this.button1.Enabled = false;
            listBox1.Items.Clear();
            var pu = new ModelLibrary.Common.ProgressUpdate("CompactAndRepair");
            
            pu.Updated = delegate {
                MainView.Instance.setProgress(pu.Message, pu.Progress);
                listBox1.Items.Add(pu);
                this.button1.Enabled = (pu.Progress == 100) ;
            };

            ModelLibrary.Common.DBConnectionManager.Instance.CompactAndRepair(pu);
        }

        private void CompactAndRepairFormLoad(object sender, EventArgs e) {
            ConfigurationsController con = new ConfigurationsController();
            string databasefile = null;

            foreach(var confModel in new ConfigurationsController().Database) {
                if (confModel.Key.ToLower().Equals("databasesource")) {
                    databasefile = confModel.Value;
                    break;
                }
            }
        }
    }
}
