using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllerLibrary.Utils
{
    public partial class EncryptionView : Form
    {
        private SimpleCrypto simpleCrypto { get; set; }
        public EncryptionView()
        {
            InitializeComponent();
            this.simpleCrypto = new SimpleCrypto();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            try
            {
                this.textBox2.Text = this.simpleCrypto.encrypt(this.textBox1.Text);
            }
            catch { }
            try { 
                this.textBox3.Text = this.simpleCrypto.decrypt(this.textBox1.Text);
            }
            catch { }
        }
    }
}
