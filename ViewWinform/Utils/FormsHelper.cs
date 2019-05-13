using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinform.Utils
{
    public class FormsHelper
    {

        public static void errorMessage(string message)
        {
            MessageBox.Show(message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public static void successMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static Form showView(Form owner,UserControl userControl)
        {
            var form = new Form() { MdiParent = owner, Text = userControl.Name };
            form.Controls.Add(userControl);
            form.Show();
            form.Size = new System.Drawing.Size(userControl.Width+20,userControl.Height+20);
            userControl.Dock = DockStyle.Fill;
            //form.WindowState = FormWindowState.Maximized;
            return form;
        }

        public static void registerEnterAsTab(Control userControl)
        {
            foreach (Control control in userControl.Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)) || control.GetType().Equals(typeof(ComboBox)))
                {
                    control.KeyDown += delegate (object sender, KeyEventArgs e)
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            e.SuppressKeyPress = true;
                            e.Handled = true;
                            SendKeys.Send("\t");
                        }
                    };
                }
            }
        }
    }
}
