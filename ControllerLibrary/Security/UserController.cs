using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Security;
using System.Data.Common;
using ControllerLibrary.Configurations;
using ControllerLibrary.Common;
using ModelLibrary.Common;

namespace ControllerLibrary.Security
{
    public class UserController : AbstractController { 
    
        public UserController() : base(new UserCollection()) {

        }
       
        public override object Save(object _model) {
            var model = (UserModel)_model;
            if (model.User_Password.StartsWith("{ENC}") == false) {
                model.User_Password = CryptoFactory.Encrypt(model.User_Password);
            }
            return base.Save(model);
        }

        public override List<object> Read(object _model, string[] whereFields) {
            var model = (UserModel)_model;
            if(!(model.User_Password == null || model.User_Password.StartsWith("{ENC}"))) {
                model.User_Password = CryptoFactory.Encrypt(model.User_Password);
            }
            return base.Read(model, whereFields);
        }

        public UserModel Autheniticate(object _model){
            var model = (UserModel)_model;
            if (model.User_Password.StartsWith("{ENC}")) return null;


            model.Is_Active = true;
            var models = Read(model, new string[] { "User_Name", "User_Password", "Is_Active" });

            if (models.Count < 1) {
                models = Read(model, new string[] { "User_Name"});
                if(models.Count > 0) {
                    var user = (UserModel)models.First();
                    user.Failed_Login_Attempts += 1;
                    if (user.Failed_Login_Attempts > 5) {
                        user.Is_Active = false;
                    }
                    Save(user);
                    new AuditController().registerEvent(new AuditModel() {
                        User_Name = model.User_Name,
                        Event_Comments = $"Login denied : {user}"
                    });
                }
                return null;
            };

            model = (UserModel)models.First();

            model.Last_Login_Date = DateTime.Now;
            Save(model);

            new AuditController().registerEvent(new AuditModel() {
                User_Name = model.User_Name,
                Event_Comments = "Login successful"
            });

            this.ResetLoginCounter(model);

            return model;
        }

        public bool ResetLoginCounter(UserModel model) {
            var models = Read(model, new string[] { "User_Name" });
            if (models.Count < 1) return false;
            model = (UserModel)models.First();
            model.Failed_Login_Attempts = 0;
            this.Save(model);

            new AuditController().registerEvent(new AuditModel() {
                User_Name = model.User_Name,
                Event_Comments = $"reset login counter : {model.User_Name}"
            });
            return true;
        }

        public void ResetPassword(UserModel model) {
            if (model.User_Password.StartsWith("{ENC}")) throw new Exception("password must in plain text");
            var password = CryptoFactory.Encrypt(model.User_Password);
            model = (UserModel)Read(model, new string[] { "User_Name" }).First();
            model.User_Password = password;
            model.Last_Change_Password = DateTime.Now;
            Save(model);
            new AuditController().registerEvent(new AuditModel() {
                User_Name = model.User_Name,
                Event_Comments = "password reset for user : " + model.User_Name
            });
        }
    }
}
