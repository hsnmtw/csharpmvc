using MVCHIS.Common;
using MVCHIS.Configurations;
using MVCHIS.Tools;
using MVCHIS.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

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

        private AuditController CntrlAU;
        private EntitlementGroupController CntrlEG;
        private EntityController CntrlET;
        private EntitlementController CntrlEN;
        private ProfileEntitlementController CntrlPE;

        public UserController() {
            CntrlAU = DBControllersFactory.Audit();
            CntrlEG = DBControllersFactory.EntitlementGroup();
            CntrlET = DBControllersFactory.Entity();
            CntrlEN = DBControllersFactory.Entitlement();
            CntrlPE = DBControllersFactory.ProfileEntitlement();
        }

        public IEnumerable<STriple> GetMenu(UserModel model) {
            
            var eids = CntrlPE.Read(new ProfileEntitlementModel {
                ProfileId = model.ProfileId,
                AllowRead =true
            }).Select(x => x.EntitlementId);

            var eg = CntrlEG.Select(new EntitlementGroupModel(), "Id,EntitlementGroupName").ToDictionary(x=>x.Id,x=>x.EntitlementGroupName);
            var et = CntrlET.Select(new EntityModel(), "Id,EntityName").ToDictionary(x => x.Id, x => x.EntityName);
            
            return CntrlEN.FindById(eids).Select(x => new STriple(eg[x.EntitlementGroupId],x.EntitlementName, et[x.EntityId])).Ordered();
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
                    
                    CntrlAU.RegisterEvent(new AuditModel() {
                        UserName = model.UserName,
                        EventComments = $"Login denied : {user}"
                    });
                }
                return null;
            };

            model = modelf;

            model.LastLoginDate = DateTime.Now;
            Save(model);

            CntrlAU.RegisterEvent(new AuditModel() {
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
            int save = Save(model);

           
            CntrlAU.RegisterEvent(new AuditModel() {
                UserName = model.UserName,
                EventComments = $"reset login counter : {model.UserName}"
            });
            return save > 0;
        }

        public void ResetPassword(UserModel model) {
            if (model.UserPassword.StartsWith("{ENC}")) throw new Exception("password must in plain text");
            var password = CryptoFactory.Encrypt(model.UserPassword);
            model = (UserModel)Find(model, "UserName" );
            model.UserPassword = password;
            model.LastChangePassword = DateTime.Now;
            Save(model);
            
            CntrlAU.RegisterEvent(new AuditModel() {
                UserName = model.UserName,
                EventComments = "password reset for user : " + model.UserName
            });
        }
    }
}
