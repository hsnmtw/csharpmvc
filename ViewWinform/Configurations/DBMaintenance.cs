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
using ModelLibrary.Configurations;

namespace ViewWinform.Configurations {
    public partial class DBMaintenance : Form {

        public DBMaintenance() {
            InitializeComponent();
        }

        private void DBMaintenance_Load(object sender, EventArgs e) {
            var configs = new ConfigurationsController().selectModelsAsDataTable();
        }
    }
}
