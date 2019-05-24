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
            InitializeComponent(); if (DesignMode) return;
            this.controller = new ConfigurationsController();
        }

        private void ConfigurationsFormLoad(object sender, EventArgs e) {
            this.textBox1.Text = this.controller.Source;
            this.DatabaseConfigDataGridView.DataSource = this.controller.Database;
            this.CultureInfoConfigDataGridView.DataSource = this.controller.CultureInfo;

            this.DatabaseConfigDataGridView.AutoGenerateColumns = false;
            this.CultureInfoConfigDataGridView.AutoGenerateColumns = false;
        }
    }
}
