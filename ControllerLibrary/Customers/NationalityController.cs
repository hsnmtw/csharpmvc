using ControllerLibrary.Common;
using ModelLibrary.Customers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Customers {
    public class NationalityController : AbstractController<NationalityModel> {
        public override string TABLE_NAME { get{ return "Customers_Nationalities"; } }

        public override DataTable search(NationalityModel model) {
            return db.query(new DBManagerLibrary.Common.Statement() {
                sql = string.Format(@"SELECT * 
                                        FROM {0} 
                                       WHERE [Nationality_Code] LIKE @Nationality_Code
                                          OR [Nationality_Desc] LIKE @Nationality_Desc
                                          OR [Id]=@Id", this.TABLE_NAME),
                parameters = getParameters("Nationality_Code,Nationality_Desc,Id".Split(','), model)
            });
        }

        public override void updateMetaData() {
            MetaData["Nationality_Code"] = "TEXT(50)";
            MetaData["Nationality_Desc"] = "TEXT(100)";
            MetaData["Nationality_Arabic"] = "TEXT(100)";
        }
    }
}
