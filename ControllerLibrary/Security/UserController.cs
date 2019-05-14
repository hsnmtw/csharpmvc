using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Security;
using System.Data.Common;
using ControllerLibrary.Utils;
using ControllerLibrary.Common;
using DBManagerLibrary.Common;

namespace ControllerLibrary.Security
{
    public class UserController : AbstractController<UserModel>
    {
        public override string TABLE_NAME { get { return "Security_Users"; } }

        public override void updateMetaData() {
            MetaData["User_Name"] = "TEXT(50)";
            MetaData["Full_Name"] = "TEXT(100)";
            MetaData["User_Password"] = "TEXT(100)";
            MetaData["Profile_Name"] = "TEXT(50)";
            MetaData["Is_Active"] = "YESNO";
            MetaData["Email"] = "TEXT(100)";
            MetaData["Failed_Login_Attempts"] = "NUMBER";
            MetaData["Last_Login_Date"] = "DATETIME";
            MetaData["Last_Change_Password"] = "DATETIME";
        }

        public bool autheniticate(UserModel model)
        {
            encryptPassword(ref model);
            var pswd = model.User_Password;
            var result = db.query(new Statement(@"SELECT [Is_Active],[Failed_Login_Attempts],[User_Password],[Id]
                                      FROM " + this.TABLE_NAME + @" 
                                     WHERE [User_Name]     = @User_Name 
                                     ",
                getParameters("User_Name".Split(','), model)
                ));
                

            if (result.Rows.Count < 1) return false;

            string is_active = result.Rows[0][0].ToString();
            string failed_login_attempts = result.Rows[0][1].ToString();
            

            model.Is_Active = bool.Parse( is_active );
            model.Failed_Login_Attempts = int.Parse( failed_login_attempts.Equals("") ? "0" : failed_login_attempts );
            model.User_Password = result.Rows[0][2].ToString();
            model.Id = result.Rows[0][3].ToString();

            bool authinticated = model.Is_Active && model.User_Password.Equals(pswd);

            

            if (authinticated) {
                db.execute(new Statement(@"UPDATE " + this.TABLE_NAME + @"
                                SET [Last_Login_Date] = now()
                              WHERE [Id] = @Id
                        ", getParameters("Id".Split(','), model)));

                new AuditController().registerEvent(new AuditModel() {
                    User_Name = model.User_Name,
                    Event_Comments = "Login successful"
                });

                this.resetLoginCounter(model);

            } else {
                model.Failed_Login_Attempts += 1;
                db.execute(new Statement(@"UPDATE " + this.TABLE_NAME + @"
                                SET [Failed_Login_Attempts] = @Failed_Login_Attempts
                              WHERE [Id]                    = @Id
                        ", getParameters("Failed_Login_Attempts,Id".Split(','), model)));

                if (model.Failed_Login_Attempts > 5) {
                    model.Is_Active = false;
                   db.execute(new Statement(@"UPDATE " + this.TABLE_NAME + @"
                                SET [Is_Active]             = @Is_Active
                              WHERE [Id]                    = @Id
                        ", getParameters("Is_Active,Id".Split(','), model)));
                }
            }

            return authinticated;
        }

        public void encryptPassword(ref UserModel model)
        {
            if (model.User_Password.StartsWith("{ENC}")) return;
            model.User_Password = new SimpleCrypto().encrypt(model.User_Password);
        }

        public void toggleActiveStatus(UserModel model) {
            db.execute(new Statement() {
                sql = @"UPDATE " + this.TABLE_NAME + @"
                           SET [Is_Active] = not [Is_Active]
                         WHERE [Id]=@Id
                ",
               parameters = getParameters("Id".Split(','),model)
            });

            new AuditController().registerEvent(new AuditModel() {
                Event_Comments = "toggle active status for user : [" + model.User_Name + "] new status : " + model.Is_Active
            });
        }

        public void resetLoginCounter(UserModel model) {
            db.execute(new Statement() {
                sql = @"UPDATE " + this.TABLE_NAME + @"
                           SET [Failed_Login_Attempts] = 0
                         WHERE [Id]=@Id
                ",
                parameters = getParameters("Id".Split(','), model)
            });
            new AuditController().registerEvent(new AuditModel() {
                Event_Comments = "reset login counter : " + model.User_Name
            });
        }

        public void resetPassword(UserModel model) {
            db.execute(new Statement() {
                sql = @"UPDATE " + this.TABLE_NAME + @"
                           SET [User_Password] = @User_Password
                         WHERE [Id]=@Id
                ",
                parameters = getParameters("User_Password,Id".Split(','), model)
            });
            new AuditController().registerEvent(new AuditModel() {
                Event_Comments = "password reset for user : " + model.User_Name
            });
        }

        public override DataTable search(UserModel model)
        {
            return db.query(new Statement(@"SELECT *
                                FROM "+ this.TABLE_NAME +@" 
                               WHERE [User_Name] LIKE @User_Name 
                                  OR [Id]=@Id", getParameters("User_Name,Id".Split(','),model)));
        }


    }
}
