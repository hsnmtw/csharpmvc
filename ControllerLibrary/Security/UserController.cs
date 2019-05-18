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
    public class UserController : AbstractDBController<UserModel>
    {
       // public override string Source => "Security_Users";

        public override UserModel Save(UserModel model) {
            if (model.User_Password.StartsWith("{ENC}") == false) {
                model.User_Password = CryptoFactory.Encrypt(model.User_Password);
            }
            return base.Save(model);
        }


        public bool autheniticate(UserModel model)
        {
            var pswd = CryptoFactory.Encrypt(model.User_Password);
            var result = database.Query(new Statement(model.GetSource(),@"SELECT [Is_Active],[Failed_Login_Attempts],[User_Password],[Id]
                                      FROM " + model.GetSource() + @" 
                                     WHERE [User_Name]     = @User_Name 
                                     ",
                model.GetParameters("User_Name".Split(','))
                ));
                

            if (result.Rows.Count < 1) return false;

            string is_active = result.Rows[0][0].ToString();
            string failed_login_attempts = result.Rows[0][1].ToString();
            

            model.Is_Active = bool.Parse( is_active );
            model.Failed_Login_Attempts = int.Parse( failed_login_attempts.Equals("") ? "0" : failed_login_attempts );
            model.User_Password = result.Rows[0][2].ToString();
            model.Id = int.Parse(result.Rows[0][3].ToString());

            bool authinticated = model.Is_Active && model.User_Password.Equals(pswd);

            

            if (authinticated) {
                database.execute(new Statement(model.GetSource(),$@"UPDATE {model.GetSource()}
                                SET [Last_Login_Date] = now()
                              WHERE [Id]              = @Id
                                 OR [User_Name]       = @User_Name
                        ", model.GetParameters("Id,User_Name".Split(','))));

                new AuditController().registerEvent(new AuditModel() {
                    User_Name = model.User_Name,
                    Event_Comments = "Login successful"
                });

                this.resetLoginCounter(model);

            } else {
                model.Failed_Login_Attempts += 1;
                database.execute(new Statement(model.GetSource(),$@"UPDATE {model.GetSource()}
                                SET [Failed_Login_Attempts] = @Failed_Login_Attempts
                              WHERE [Id]                    = @Id
                                 OR [User_Name]             = @User_Name
                        ", model.GetParameters("Failed_Login_Attempts,Id,User_Name".Split(','))));

                if (model.Failed_Login_Attempts > 5) {
                    model.Is_Active = false;
                   database.execute(new Statement(model.GetSource(),@"UPDATE " + model.GetSource() + @"
                                SET [Is_Active]             = @Is_Active
                              WHERE [Id]                    = @Id
                                 OR [User_Name]             = @User_Name
                        ", model.GetParameters("Is_Active,Id,User_Name".Split(','))));
                }
            }

            return authinticated;
        }

        public void toggleActiveStatus(UserModel model) {
            database.execute(new Statement(model.GetSource()) {
                Sql = $@"UPDATE {model.GetSource()}
                           SET [Is_Active] = not [Is_Active]
                         WHERE [Id]        = @Id
                            OR [User_Name] = @User_Name
                ",
               Parameters = model.GetParameters("Id,User_Name".Split(','))
            });

            new AuditController().registerEvent(new AuditModel() {
                User_Name = model.User_Name,
                Event_Comments = $"toggle active status for user : [{model.User_Name}] new status : {model.Is_Active}"
            });
        }

        public void resetLoginCounter(UserModel model) {
            database.execute(new Statement(model.GetSource()) {
                Sql = $@"UPDATE {model.GetSource()}
                           SET [Failed_Login_Attempts] = 0
                         WHERE [Id]=@Id
                            OR [User_Name]=@User_Name
                ",
                Parameters = model.GetParameters("Id,User_Name".Split(','))
            });
            new AuditController().registerEvent(new AuditModel() {
                User_Name = model.User_Name,
                Event_Comments = $"reset login counter : {model.User_Name}"
            });
        }

        public void resetPassword(UserModel model) {
            if (model.User_Password.StartsWith("{ENC}")) throw new Exception("password must in plain text");
            model.User_Password = CryptoFactory.Encrypt(model.User_Password);
            model.Last_Change_Password = DateTime.Now;
            database.execute(new Statement(model.GetSource()) {
                Sql = $@"UPDATE {model.GetSource()}
                           SET [User_Password]        = @User_Password
                             , [Last_Change_Password] = @Last_Change_Password
                         WHERE [Id]                   = @Id
                            OR [User_Name]            = @User_Name
                ",
                Parameters = model.GetParameters("User_Password,Last_Change_Password,Id,User_Name".Split(','))
            });
            new AuditController().registerEvent(new AuditModel() {
                User_Name = model.User_Name,
                Event_Comments = "password reset for user : " + model.User_Name
            });
        }
    }
}
