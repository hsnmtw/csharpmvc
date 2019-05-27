using MVCWinform.Common;
using MVCWinform.Configurations;
using System;

namespace MVCWinform.Security {
    [ForEntityAttribute(Entities.User, Enabled = true)]
    public class UserController : AbstractDBController {

        public UserController() : base(DBEntitiesFactory.GetEntity(Entities.User)) { }
       
        public void Initialize() {
            Save(new UserModel() {
                UserName = "Admin",
                UserPassword = "123",
                ProfileName = "Admin",
                FullName = "Administrator",
                IsActive = true,
            });
        }

        public override int Save(object userModel) {
            var model = (UserModel)userModel;
            if (model.UserPassword.StartsWith("{ENC}") == false) {
                model.UserPassword = CryptoFactory.Encrypt(model.UserPassword);
            }
            return base.Save(model);
        }

        public override int Delete(object userModel) {
            var model = (UserModel)userModel;
            model = (UserModel)Find(model, "Id" );
            if ("admin".Equals($"{model.UserName}".ToLower())) {
                throw new ArgumentException("You cannot delete Admin user");
            }
            return base.Delete(model);
        }

        //public override List<object> Read(object userModel, string[] whereFields) {
        //    var model = (UserModel)userModel;
        //    if(!(model.UserPassword == null || model.UserPassword.StartsWith("{ENC}"))) {
        //        model.UserPassword = CryptoFactory.Encrypt(model.UserPassword);
        //    }
        //    return base.Read(model, whereFields);
        //}

        

        public UserModel Autheniticate(UserModel model) {
         
            //if (model.UserPassword.StartsWith("{ENC}")) return null;

            var audit = (AuditController)DBControllersFactory.GetController(Entities.Audit);

            model.IsActive = true;
            var modelf = Find(model, "UserName", "UserPassword", "IsActive");

            if (modelf == null) {
                modelf = Find(model, "UserName" );
                if(modelf != null) {
                    var user = (UserModel)modelf;
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

            model = (UserModel)modelf;

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
            var modelf = Find(model, "UserName" );
            if (modelf == null) return false;
            model = (UserModel)modelf;
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
            model = (UserModel)Find(model, "UserName" );
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
