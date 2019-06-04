using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCHIS.Utils {
    public partial class InputBox : Form {
        public readonly static InputBox Instance = new InputBox();
        private InputBox() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        public static string Prompt(string title,string prompt) {
            Instance.Text = title;
            Instance.lblPrompt.Text = prompt;
            Instance.txtPrompt.Text = "";
            if (Instance.ShowDialog() == DialogResult.OK) {
                return Instance.txtPrompt.Text;
            }
            return null;
        }

        private void BtnAccept_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void InputBox_Load(object sender, EventArgs e) {
            txtPrompt.Select();
            txtPrompt.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
