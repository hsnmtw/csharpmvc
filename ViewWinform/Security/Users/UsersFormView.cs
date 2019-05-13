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

namespace ViewWinform.Security.Users
{
        
    public partial class UsersFormView : UserControl,BaseView<UserModel>
    {
        private UserModel _model = new UserModel();
        public UserModel model {
            get {
                _model.Id = this.Id_TextBox.Text;
                _model.User_Name = User_Name_TextBox.Text;
                _model.Full_Name = Full_Name_TextBox.Text;
                _model.Profile_Name = Profile_Id_ComboBox.Text;
                _model.User_Password = new ControllerLibrary.Utils.SimpleCrypto().encrypt(User_Password_TextBox.Text);
                _model.Email = Email_TextBox.Text;
                return _model;
            }
            set {
                _model = value;
                this.Id_TextBox.Text = _model==null?"":_model.Id;
                this.User_Name_TextBox.Text = _model==null?"":_model.User_Name;
                this.Full_Name_TextBox.Text = _model==null?"":_model.Full_Name;
                this.Profile_Id_ComboBox.Text = _model==null?"":_model.Profile_Name;
                this.Email_TextBox.Text = _model==null?"":_model.Email;
                this.IsActive_TextBox.Text = _model==null?"":_model.Is_Active.ToString();
                this.LastLoginDate_TextBox.Text = _model==null?"":_model.Last_Login_Date.ToString();
                this.LastPasswordReset_TextBox.Text = _model==null?"":_model.Last_Change_Password.ToString();
                this.FailedLogins_TextBox.Text = _model==null?"":_model.Failed_Login_Attempts.ToString();
                this.User_Password_TextBox.Text = _model==null?"": new ControllerLibrary.Utils.SimpleCrypto().decrypt( _model.User_Password );
            }
        }

        public UsersFormView() : base()
        {
            InitializeComponent();

            this.Profile_Id_ComboBox.DataSource = new ProfileController().all();
            this.Profile_Id_ComboBox.DisplayMember = "Profile_Name";
            this.Profile_Id_ComboBox.ValueMember = "Id";

            Utils.FormsHelper.registerEnterAsTab(this);
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    var controller = new UserController();

        //    //model.User_Password = new ControllerLibrary.Utils.SimpleCrypto().encrypt(model.User_Password);
        //    if (Id_TextBox.Text.Equals("")) {
        //        var fmodel = controller.find(model);
        //        if (fmodel != null) {
        //            MessageBox.Show(string.Format("User Name : {0} is already in use", fmodel.User_Name), "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        controller.insert(model);
        //    }
        //    else
        //    {
        //        controller.update(model);
        //    }
        //    this.OnOKAction();
        //}

        //private void Button2_Click(object sender, EventArgs e)
        //{
        //    this.OnCancelAction();
        //}
    }
}
