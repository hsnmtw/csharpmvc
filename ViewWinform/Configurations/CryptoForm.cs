using ControllerLibrary.Configurations;
using ModelLibrary.Configurations;
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
    public partial class CryptoForm : Form {
        private CryptoModel model;
        private CryptoController controller;

        public CryptoModel Model {
            set {
                model = value;
                txtInput.Text     = model == null ? "" : model.InputText;
                txtEncrypted.Text = model == null ? "" : model.Encrypted;
                txtDecrypted.Text = model == null ? "" : model.Decrypted;
                txtHashed.Text    = model == null ? "" : model.Hashed;
            }
            get {
                if (model == null) model = new CryptoModel();
                model.InputText = txtInput.Text;
                model.Encrypted = txtEncrypted.Text;
                model.Decrypted = txtDecrypted.Text;
                model.Hashed    = txtHashed.Text;
                return model;
            }
        }

        public CryptoForm() {
            InitializeComponent();
            this.controller = new CryptoController();
        }

        private void Button1Click(object sender, EventArgs e) {
            this.Model = this.controller.Process(this.Model);
        }
    }
}
