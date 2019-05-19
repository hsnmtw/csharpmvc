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

        private void Button1_Click(object sender, EventArgs e) {
            CompactAndRepairAsync();
        }

        public async void CompactAndRepairAsync() {
            this.button1.Enabled = false;
            MainView.Instance.setProgress("Closing database", 0);
            ModelLibrary.Common.DBConnectionManager.Instance.Close();
            await Task.Delay(1000);

            MainView.Instance.setProgress("Database is closed", 10);
            await Task.Delay(3000); 

            
            //engine.OpenDatabase(this.lblDatabaseFileName.Text).Close();
            string FORMAT = "yyyyMMdd.HHmmss";
            MainView.Instance.setProgress("Taking backup of database file", 20);
            System.IO.File.Copy(this.lblDatabaseFileName.Text, this.lblDatabaseFileName.Text + $".bak.{DateTime.Now.ToString(FORMAT)}",true);
            System.IO.File.Copy(this.lblDatabaseFileName.Text, this.lblDatabaseFileName.Text + $".bak", true);

            MainView.Instance.setProgress("Deleting previous compact and repair files", 30);
            if (System.IO.File.Exists(this.lblDatabaseFileName.Text + ".car")) {
                System.IO.File.Delete(this.lblDatabaseFileName.Text + ".car");
            }

            MainView.Instance.setProgress("Performing DAO engine Compact and Repair action ...", 40);
            var engine = new DAO.DBEngine();
            engine.CompactDatabase(
                this.lblDatabaseFileName.Text+".bak",
                this.lblDatabaseFileName.Text+".car"
            );

            await Task.Delay(3000);
            MainView.Instance.setProgress("Compact and repair is completed successfully", 70);
            
            engine = null;

            await Task.Delay(2000);
            MainView.Instance.setProgress("DAO engine is closed", 80);
            //this.lblDatabaseFileSize.Text = $"{new System.IO.FileInfo(lblDatabaseFileName.Text+".car").Length/1024} MB";

            await Task.Delay(2000);
            System.IO.File.Delete(this.lblDatabaseFileName.Text);

            MainView.Instance.setProgress("database file is deleted", 90);

            System.IO.File.Copy(this.lblDatabaseFileName.Text+".car", this.lblDatabaseFileName.Text, true);
            this.lblNewDatabaseFileSize.Text = $"{new System.IO.FileInfo(this.lblDatabaseFileName.Text).Length / 1024} MB";
            MainView.Instance.setProgress("Compact and Repair is completed", 95);
            await Task.Delay(3000);
            ModelLibrary.Common.DBConnectionManager.Instance.Open();

            MainView.Instance.setProgress("Database connection is re-opened after compact and rapair", 100);

            Utils.FormsHelper.successMessage("Compact and Repair completed successfully !!");
            this.button1.Enabled = true;
        }

        private void CompactAndRepairForm_Load(object sender, EventArgs e) {
            ConfigurationsController con = new ConfigurationsController();
            string databasefile = null;

            foreach(var confModel in new ConfigurationsController().Database) {
                if (confModel.Key.ToLower().Equals("database_source")) {
                    databasefile = confModel.Value;
                    break;
                }
            }

            this.lblDatabaseFileName.Text = databasefile;

            this.lblDatabaseFileSize.Text = $"{new System.IO.FileInfo(this.lblDatabaseFileName.Text).Length / 1024} MB";


        }
    }
}
