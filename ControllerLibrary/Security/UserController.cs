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
    [ForControllerAttribute(Entities.User, Enabled = true)]
    public class UserController : AbstractController {

        public UserController() : base(CollectionsFactory.GetCollection(Entities.User)) { }
       
        public override object Save(object _model) {
            var model = (UserModel)_model;
            if (model.User_Password.StartsWith("{ENC}") == false) {
                model.User_Password = CryptoFactory.Encrypt(model.User_Password);
            }
            return base.Save(model);
        }

        public override void Delete(object _model) {
            var model = (UserModel)_model;
            model = (UserModel)Read(model, new string[] { "Id" }).First();
            if ("admin".Equals($"{model.User_Name}".ToLower())) {
                throw new ArgumentException("You cannot delete Admin user");
            }
            base.Delete(model);
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

            var audit = (AuditController)ControllersFactory.GetController(Entities.Audit);

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
                    
                    audit.registerEvent(new AuditModel() {
                        User_Name = model.User_Name,
                        Event_Comments = $"Login denied : {user}"
                    });
                }
                return null;
            };

            model = (UserModel)models.First();

            model.Last_Login_Date = DateTime.Now;
            Save(model);

            audit.registerEvent(new AuditModel() {
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

            var audit = (AuditController)ControllersFactory.GetController(Entities.Audit);
            audit.registerEvent(new AuditModel() {
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
            var audit = (AuditController)ControllersFactory.GetController(Entities.Audit);
            audit.registerEvent(new AuditModel() {
                User_Name = model.User_Name,
                Event_Comments = "password reset for user : " + model.User_Name
            });
        }
    }
}
