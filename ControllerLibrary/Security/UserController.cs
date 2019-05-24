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
    public class UserController : AbstractDBController {

        public UserController() : base(DBEntitiesFactory.GetEntity(Entities.User)) { }
       
        public override DBModificationResult Save(object userModel) {
            var model = (UserModel)userModel;
            if (model.UserPassword.StartsWith("{ENC}") == false) {
                model.UserPassword = CryptoFactory.Encrypt(model.UserPassword);
            }
            return base.Save(model);
        }

        public override DBModificationResult Delete(object userModel) {
            var model = (UserModel)userModel;
            model = (UserModel)Read(model, new string[] { "Id" }).First();
            if ("admin".Equals($"{model.UserName}".ToLower())) {
                throw new ArgumentException("You cannot delete Admin user");
            }
            return base.Delete(model);
        }

        public override List<object> Read(object userModel, string[] whereFields) {
            var model = (UserModel)userModel;
            if(!(model.UserPassword == null || model.UserPassword.StartsWith("{ENC}"))) {
                model.UserPassword = CryptoFactory.Encrypt(model.UserPassword);
            }
            return base.Read(model, whereFields);
        }

        public UserModel Autheniticate(object userModel) {
            var model = (UserModel)userModel;
            if (model.UserPassword.StartsWith("{ENC}")) return null;

            var audit = (AuditController)DBControllersFactory.GetController(Entities.Audit);

            model.IsActive = true;
            var models = Read(model, new string[] { "UserName", "UserPassword", "IsActive" });

            if (models.Count < 1) {
                models = Read(model, new string[] { "UserName"});
                if(models.Count > 0) {
                    var user = (UserModel)models.First();
                    user.FailedLoginAttempts += 1;
                    if (user.FailedLoginAttempts > 5) {
                        user.IsActive = false;
                    }
                    Save(user);
                    
                    audit.registerEvent(new AuditModel() {
                        UserName = model.UserName,
                        EventComments = $"Login denied : {user}"
                    });
                }
                return null;
            };

            model = (UserModel)models.First();

            model.LastLoginDate = DateTime.Now;
            Save(model);

            audit.registerEvent(new AuditModel() {
                UserName = model.UserName,
                EventComments = "Login successful"
            });

            this.ResetLoginCounter(model);

            return model;
        }

        public bool ResetLoginCounter(UserModel model) {
            var models = Read(model, new string[] { "UserName" });
            if (models.Count < 1) return false;
            model = (UserModel)models.First();
            model.FailedLoginAttempts = 0;
            this.Save(model);

            var audit = (AuditController)DBControllersFactory.GetController(Entities.Audit);
            audit.registerEvent(new AuditModel() {
                UserName = model.UserName,
                EventComments = $"reset login counter : {model.UserName}"
            });
            return true;
        }

        public void ResetPassword(UserModel model) {
            if (model.UserPassword.StartsWith("{ENC}")) throw new Exception("password must in plain text");
            var password = CryptoFactory.Encrypt(model.UserPassword);
            model = (UserModel)Read(model, new string[] { "UserName" }).First();
            model.UserPassword = password;
            model.LastChangePassword = DateTime.Now;
            Save(model);
            var audit = (AuditController)DBControllersFactory.GetController(Entities.Audit);
            audit.registerEvent(new AuditModel() {
                UserName = model.UserName,
                EventComments = "password reset for user : " + model.UserName
            });
        }
    }
}
