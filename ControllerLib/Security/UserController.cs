using MVCHIS.Common;
using MVCHIS.Configurations;
using System;

namespace MVCHIS.Security {
    //[ForModel(MODELS.User, Enabled = true)]
    public class UserController : AbstractDBController<UserModel> {

        public override int Save(UserModel model) {
            //UserModel model = (UserModel)userModel;
            if (model.UserPassword?.StartsWith("{ENC}") == false) {
                model.UserPassword = CryptoFactory.Encrypt(model.UserPassword);
            }
            return base.Save(model);
        }

        public override int Delete(UserModel model) {
            //var model = Find((UserModel)userModel, "Id" );
            if ("admin".Equals($"{model.UserName}".ToLower())) {
                throw new ArgumentException("You cannot delete Admin user");
            }
            return base.Delete(model);
        }

        public UserModel Autheniticate(UserModel model) {

            if (model!=null && model.UserPassword!=null && !model.UserPassword.StartsWith("{ENC}")) {
                model.UserPassword = new CryptoController().Process(new CryptoModel() { InputText = model.UserPassword }).Encrypted;
            }

            var audit = (AuditController)DBControllersFactory.GetController<AuditModel>();

            model.IsActive = true;
            UserModel modelf = Find(model, "UserName", "UserPassword", "IsActive");

            if (modelf == null) {
                modelf = Find(model, "UserName" );
                if(modelf != null) {
                    var user = (UserModel)modelf;
                    user.FailedLoginAttempts += 1;
                    if (user.FailedLoginAttempts > 5) {
                        user.IsActive = false;
                    }
                    Save(user);
                    
                    audit.RegisterEvent(new AuditModel() {
                        UserName = model.UserName,
                        EventComments = $"Login denied : {user}"
                    });
                }
                return null;
            };

            model = modelf;

            model.LastLoginDate = DateTime.Now;
            Save(model);

            audit.RegisterEvent(new AuditModel() {
                UserName = model.UserName,
                EventComments = "Login successful"
            });

            this.ResetLoginCounter(model);

            return model;
        }

        public bool ResetLoginCounter(UserModel model) {
            var modelf = Find(model, "UserName" );
            if (modelf == null) return false;
            model = (UserModel)modelf;
            model.FailedLoginAttempts = 0;
            this.Save(model);

            var audit = (AuditController)DBControllersFactory.GetController<AuditModel>();
            audit.RegisterEvent(new AuditModel() {
                UserName = model.UserName,
                EventComments = $"reset login counter : {model.UserName}"
            });
            return base.Validate(model);
        }

        public void ResetPassword(UserModel model) {
            if (model.UserPassword.StartsWith("{ENC}")) throw new Exception("password must in plain text");
            var password = CryptoFactory.Encrypt(model.UserPassword);
            model = (UserModel)Find(model, "UserName" );
            model.UserPassword = password;
            model.LastChangePassword = DateTime.Now;
            Save(model);
            var audit = (AuditController)DBControllersFactory.GetController<AuditModel>();
            audit.RegisterEvent(new AuditModel() {
                UserName = model.UserName,
                EventComments = "password reset for user : " + model.UserName
            });
        }
    }
}
