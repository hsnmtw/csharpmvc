using ControllerLibrary.Customers;
using ControllerLibrary.Security;
using ModelLibrary.Customers;
using ModelLibrary.Security;
using System;
using System.Windows.Forms;

namespace ViewWinform.Security.Profiles {
    public partial class ProfilesListView : UserControl //, BaseView<ProfileModel>
    {


        public ProfilesListView()
        {
            InitializeComponent();
            this.dataGridView1.VirtualMode = true;
            //this.dataGridView1.AutoGenerateColumns = false;

            Button1_Click(null, null);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Search_TextBox.Text = "%";
            var controller = new ProfileController();
            this.dataGridView1.DataSource = controller.all();
        }

        private void Go_Button_Click(object sender, EventArgs e)
        {
            var controller = new ProfileController();
            this.dataGridView1.DataSource = controller.search(
                new ProfileModel() { Profile_Name=Search_TextBox.Text },
                "Profile_Name".Split(',')
            );
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form = new Form();// { Width = 550, Height = 450 };
            var prfform = new ProfilesFormView()
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
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());

            var form = new Form();// { Width = 550, Height = 450 };
            var prfform = new ProfilesFormView()
            {
                Dock = DockStyle.Fill
            };
            prfform.model = (new ProfileController().find(new ProfileModel() { Id = id }));
            form.Size = new System.Drawing.Size(prfform.Width + 20, prfform.Height + 120);
            form.Controls.Add(prfform);

            form.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) return;
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());
            if (MessageBox.Show("Are you sure of deleting this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new ProfileController().delete( new ProfileModel() { Id = id });
                Button1_Click(null, null);
            }
        }
    }                                                                                                                 
}
