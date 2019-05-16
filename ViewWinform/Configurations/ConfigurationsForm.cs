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
    public partial class ConfigurationsForm : Form {

        private ConfigurationsController controller;
        public ConfigurationsForm() {
            InitializeComponent();
            this.controller = new ConfigurationsController();
        }

        private void ConfigurationsForm_Load(object sender, EventArgs e) {
            this.textBox1.Text = this.controller.Source;
            this.DatabaseConfig_DataGridView.DataSource = this.controller.Database;
            this.CultureInfoConfig_DataGridView.DataSource = this.controller.CultureInfo;

            this.DatabaseConfig_DataGridView.AutoGenerateColumns = false;
            this.CultureInfoConfig_DataGridView.AutoGenerateColumns = false;
        }
    }
}
