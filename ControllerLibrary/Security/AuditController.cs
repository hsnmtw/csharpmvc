using ControllerLibrary.Common;
using DBManagerLibrary.Common;
using ModelLibrary.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Security {
    public class AuditController : AbstractController<AuditModel> {
        public override string TABLE_NAME { get { return "Security_Audit"; } }

        public override DataTable search(AuditModel model) {
            return db.query(new Statement() {
                sql = "SELECT "+ string.Join(",",this.fields) +" FROM " + this.TABLE_NAME + " WHERE [User_Name]=@User_Name OR Format([Event_Date],'yyyyMMdd')=Format(@Event_Date,'yyyyMMdd')",
                parameters = getParameters("User_Name,Event_Date".Split(','),model)
            });
        }

        public void registerEvent(AuditModel model) {
            model.Updated_By = "SYSTEM";
            model.Created_By = "SYSTEM";
            model.Event_Date = DateTime.Now;
            model.Updated_On = DateTime.Now;
            model.Created_On = DateTime.Now; 
            insert(model);
        }

        public override void updateMetaData() {
            MetaData["User_Name"] = "TEXT(50)";
            MetaData["Event_Date"] = "DATETIME";
            MetaData["Event_Comments"] = "TEXT(255)";
        }
    }
}
