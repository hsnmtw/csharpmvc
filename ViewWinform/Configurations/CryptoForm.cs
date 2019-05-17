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
        private CryptoModel _model;
        private CryptoController _controller;

        public CryptoModel Model {
            set {
                _model = value;
                txtInput.Text     = _model == null ? "" : _model.InputText;
                txtEncrypted.Text = _model == null ? "" : _model.Encrypted;
                txtDecrypted.Text = _model == null ? "" : _model.Decrypted;
                txtHashed.Text    = _model == null ? "" : _model.Hashed;
            }
            get {
                if (_model == null) _model = new CryptoModel();
                _model.InputText = txtInput.Text;
                _model.Encrypted = txtEncrypted.Text;
                _model.Decrypted = txtDecrypted.Text;
                _model.Hashed    = txtHashed.Text;
                return _model;
            }
        }

        public CryptoForm() {
            InitializeComponent();
            this._controller = new CryptoController();
        }

        private void Button1_Click(object sender, EventArgs e) {
            this.Model = this._controller.Process(this.Model);
        }
    }
}
