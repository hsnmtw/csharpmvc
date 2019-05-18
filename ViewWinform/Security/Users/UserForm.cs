using ControllerLibrary.Security;
using ModelLibrary.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinform.Security.Users {
    public partial class UserForm : Form {
        public UserForm() {
            InitializeComponent();
        }


        private UserController controller;
        private UserModel _model;
        private List<object> profile_Entitlements;

        public UserModel Model {
            get {
                _model.Id = int.Parse($"0{this.Id_TextBox.Text}");
                _model.User_Name = this.User_Name_TextBox.Text;


                _model.Full_Name = this.Full_Name_TextBox.Text;
                _model.Profile_Name = this.Profile_Name_TextBox.Text;
                _model.Email = this.Email_TextBox.Text;
                _model.Is_Active = this.Is_Active_CheckBox.Checked;

                _model.User_Password = this.User_Password_TextBox.Text;

                _model.Created_By = this.Created_By_TextBox.Text;
                _model.Updated_By = this.Updated_By_TextBox.Text;
                try {
                    _model.Created_On = DateTime.Parse(this.Created_On_TextBox.Text);
                    _model.Updated_On = DateTime.Parse(this.Updated_On_TextBox.Text);
                } catch { }
                return _model;
            }
            set {
                this._model = value;
                if (value == null) _model = new UserModel();
                this.Id_TextBox.Text = _model.Id.ToString();
                this.User_Name_TextBox.Text = _model.User_Name;
                this.Created_By_TextBox.Text = _model.Created_By;
                this.Updated_By_TextBox.Text = _model.Updated_By;
                this.Created_On_TextBox.Text = _model.Created_By == null || "".Equals(_model.Created_By) ? "" : _model.Created_On.ToString();
                this.Updated_On_TextBox.Text = _model.Updated_By == null || "".Equals(_model.Updated_By) ? "" : _model.Updated_On.ToString();
                this.Full_Name_TextBox.Text =_model.Full_Name;
                this.Profile_Name_TextBox.Text =_model.Profile_Name;
                this.Email_TextBox.Text =_model.Email;
                this.Is_Active_CheckBox.Checked =_model.Is_Active ;
                this.LastLoginDate_TextBox.Text = "";  if (_model.Last_Login_Date != null) this.LastLoginDate_TextBox.Text = _model.Last_Login_Date.ToString() ;
                this.LastPasswordReset_TextBox.Text = "";  if(_model.Last_Change_Password != null) this.LastPasswordReset_TextBox.Text = _model.Last_Change_Password.ToString();
                this.FailedLogins_TextBox.Text =_model.Failed_Login_Attempts.ToString();
                this.User_Password_TextBox.Text = _model.User_Password;
                this.Confirm_User_Password_TextBox.Text = this.User_Password_TextBox.Text;
            }
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new UserModel();
        }

        private void Button3_Click(object sender, EventArgs e) {
            if(this.User_Password_TextBox.Text.Equals(this.Confirm_User_Password_TextBox.Text)==false) {
                Utils.FormsHelper.errorMessage("Password and confirmation don't match");
                return;
            }
            this.controller.Save(this.Model);
            Utils.FormsHelper.successMessage("Successfully saved ...");
            User_Code_TextBox_OnLookUpSelected(this.Model.User_Name);
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.Delete(this.Model);
            Utils.FormsHelper.successMessage("Successfully deleted ...");
            this.Model = new UserModel();
        }

        private void User_Code_TextBox_OnLookUpSelected(string value) {
            this.Model = (UserModel)this.controller.Read(new UserModel() {
                User_Name = value,
            }, "User_Name".Split(','))[0];
        }

        private void UserForm_Load(object sender, EventArgs e) {
            Utils.FormsHelper.registerEnterAsTab(this);
            this.controller = new UserController();
            this.Model = new UserModel();
            this.profile_Entitlements = new ProfileEntitlementsController().Read();
        }

        private void Button1_Click(object sender, EventArgs e) {
            if (this.controller.ResetLoginCounter(this.Model)) {
                this.FailedLogins_TextBox.Text = "0";
                Utils.FormsHelper.successMessage("Failed Login attempts counter has been reset");
            } else {
                Utils.FormsHelper.errorMessage("Something went wrong, please try again later...");
            }
        }

        private void Profile_Name_Lookup_OnLookUpSelected(object sender, EventArgs e) {

        }

        private void User_Name_Lookup_OnLookUpSelected(object sender, EventArgs e) {
            this.Model = (UserModel)this.controller.Read(new UserModel() {
                User_Name = this.User_Name_TextBox.Text 
            }, new string[]{"User_Name"}).First();
        }

        private void Profile_Name_TextBox_TextChanged(object sender, EventArgs e) {
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange((
                from ProfileEntitlementsModel model in profile_Entitlements
                where model.Profile_Name.Equals(Profile_Name_TextBox.Text)
                orderby model.Entitlement_Name
                select model.Entitlement_Name
            ).ToArray());
        }
    }
}
