using ViewWinform.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerLibrary.Security;
using ModelLibrary.Security;

namespace ViewWinform.Security.Users {
    public partial class UserView : CommonView {

        private MVCAdaptor<UserController, UserModel> adaptor;

        public UserView() : base() {
            InitializeComponent();
            this.adaptor = new MVCAdaptor<UserController, UserModel>();
            this.adaptor.Requery();
            this.TotalRecords = adaptor.Count;
            this.SetRecordPosition(1);
        }

        public UserView(string[]fields, UserModel model) : base() {
            InitializeComponent();
            this.adaptor = new MVCAdaptor<UserController, UserModel>(fields, model);
            adaptor.Requery();
            this.TotalRecords = adaptor.Count;
            this.SetRecordPosition(1);
        }


        private void UserView_OnSaveInvoked() {
            UserModel model = this.usersFormView1.model;
            if(model.Profile_Name == null || "".Equals(model.Profile_Name)) {
                this.ResponseMessage = "Failed, you need to select a profile !!!";
                return;
            }
            this.adaptor.Controller.save(model);
            adaptor.Requery();
            this.SetRecordPosition(1);
            this.TotalRecords = adaptor.Count;
            this.ResponseMessage = "Saved";
        }

        private void UserView_OnTableInvoked() {
            this.ResponseMessage = "Not implemented !!!";
        }

        private void UserView_OnNewInvoked() {
            this.usersFormView1.model = new UserModel();
        }

        private void UserView_OnDeleteInvoked() {
            this.adaptor.Controller.delete(this.usersFormView1.model);
            adaptor.Requery();
            this.SetRecordPosition(1);
            this.TotalRecords = adaptor.Count;
            this.ResponseMessage = "Deleted";
        }

        private void UserView_OnRecordPositionChanged(int index) {
            this.usersFormView1.model = adaptor[index];
        }


    }
}
