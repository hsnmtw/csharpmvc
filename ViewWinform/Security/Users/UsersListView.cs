using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLibrary.Security;
using ControllerLibrary.Security;
using System.Threading;

namespace ViewWinform.Security.Users
{
    public partial class UsersListView : UserControl //, BaseView<UserModel>
    {

        public UsersListView()
        {
            InitializeComponent();
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.AutoGenerateColumns = false;
            Button1_Click(null, null);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Search_TextBox.Text = "%";
            var controller = new UserController();
            this.dataGridView1.DataSource = controller.all();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //var form = new Form();// { Width = 400 };
            //var userform = new UsersFormView()
            //{
            //    Dock = DockStyle.Fill
            //};
            //form.Size = new System.Drawing.Size(userform.Width + 20, userform.Height + 120);
            //form.Controls.Add(userform);
            //form.ShowDialog();
            new UserView("Id".Split(','), new UserModel() { Id = "-1" }) { MdiParent = this.ParentForm.MdiParent }.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) return;

            //var form = new Form();// { Width=400 };
            //var userform = new UsersFormView()
            //{
            //    Dock = DockStyle.Fill
            //};
            //string id = this.dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
            //UserModel model = new UserModel() { Id = id };
            //model = new UserController().find(model);
            //model.User_Password = new ControllerLibrary.Utils.SimpleCrypto().decrypt(model.User_Password);
            //userform.model = (model);

            //form.Size = new System.Drawing.Size(userform.Width + 20, userform.Height + 120);
            //form.Controls.Add(userform);
            //form.ShowDialog();

            string id = this.dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
            new UserView("Id".Split(','), new UserModel() { Id = id }) { MdiParent=this.ParentForm.MdiParent }.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) return;
            string id = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
            if (MessageBox.Show("Are you sure of deleting this record","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new UserController().delete(new UserModel() { Id = id });
                Button1_Click(null, null);
            }
        }

        private void Go_Button_Click(object sender, EventArgs e)
        {
            var controller = new UserController();
            this.dataGridView1.DataSource = controller.search(new UserModel() { User_Name = Search_TextBox.Text });
        }

        private void Button5_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count < 1) return;
            string id = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
            UserController controller = new UserController();
            controller.toggleActiveStatus(new UserModel() {Id = id});
            Button1_Click(null, null);
        }

        private void Button6_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count < 1) return;
            string id = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
            UserController controller = new UserController();
            controller.resetLoginCounter(new UserModel() { Id = id });
            Button1_Click(null, null);
        }

        private void Button7_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count < 1) return;
            string id = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
            string username = dataGridView1.SelectedRows[0].Cells["User_Name"].Value.ToString();

            UserPasswordResetView userPasswordResetView = new Security.Users.UserPasswordResetView();
            userPasswordResetView.model = (new UserModel() {
                Id = id,
                User_Name = username
            });
            Form pswdresetform = Utils.FormsHelper.showView(this.ParentForm.MdiParent, userPasswordResetView);
            userPasswordResetView.OnOKAction = delegate () {
                new UserController().resetPassword(userPasswordResetView.model);
                Utils.FormsHelper.successMessage("Password has been reset");
                pswdresetform.Close();
            };
            userPasswordResetView.OnCancelAction = delegate () { pswdresetform.Close(); };
        }
    }
}
