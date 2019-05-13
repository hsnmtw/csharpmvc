using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerLibrary.Security;
using ModelLibrary.Security;

namespace ViewWinform.Security.Entitlements
{
    public partial class EntitlementListView : UserControl
    {
        public EntitlementListView()
        {
            InitializeComponent();
            //this.dataGridView1.VirtualMode = true;
            //this.dataGridView1.AutoGenerateColumns = false;
            Button1_Click(null, null);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Search_TextBox.Text = "%";
            var controller = new EntitlementController();
            this.dataGridView1.DataSource = controller.all();
        }

 
        private void Button2_Click(object sender, EventArgs e)
        {
            var form = new Form() { Width = 400 };
            var prfform = new EntitelmentFormView()
            {
                //OnOKAction = delegate ()
                //{
                //    form.Close();
                //    Button1_Click(null, null);
                //},
                //OnCancelAction = delegate ()
                //{
                //    form.Close();
                //},
                Dock = DockStyle.Fill
            };
            form.Size = new System.Drawing.Size(prfform.Width + 20, prfform.Height + 120);
            form.Controls.Add(prfform);

            form.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) return;
            string id = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();

            var form = new Form();// { Width = 400 };
            var prfform = new EntitelmentFormView()
            {
                //OnOKAction = delegate ()
                //{
                //    form.Close();
                //    Button1_Click(null, null);
                //},
                //OnCancelAction = delegate ()
                //{
                //    form.Close();
                //},
                Dock = DockStyle.Fill
            };
            prfform.model = (new EntitlementController().find(new EntitlementModel() { Id = id }));
            form.Size = new System.Drawing.Size(prfform.Width + 20, prfform.Height + 120);

            form.Controls.Add(prfform);
            form.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) return;
            string id = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
            //string name = dataGridView1.SelectedRows[0].Cells["Entitlement_Name"].Value.ToString();
            if (MessageBox.Show("Are you sure of deleting this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new EntitlementController().delete(new EntitlementModel() { Id = id }); //, Entitlement_Name = name });
                Button1_Click(null, null);
            }
        }

        private void Go_Button_Click_1(object sender, EventArgs e)
        {
            var controller = new EntitlementController();
            this.dataGridView1.DataSource = controller.search(new EntitlementModel() { Entitlement_Name = Search_TextBox.Text });
        }
    }
}
