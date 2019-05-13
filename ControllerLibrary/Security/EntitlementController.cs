using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Security;
using ControllerLibrary.Common;
using DBManagerLibrary.Common;

namespace ControllerLibrary.Security
{
    public class EntitlementController : AbstractController<EntitlementModel>
    {
        public override string TABLE_NAME { get { return "Security_Entitlements"; } }
        public override void updateMetaData() {
            MetaData["Entitlement_Name"] = "TEXT(50)";
        }

        public DataTable getAllEntitlementsWithoutId()
        {
            return db.query(new Statement() {
                sql = @"SELECT [Entitlement_Name] 
                                FROM "+ this.TABLE_NAME +@" 
                            ORDER BY 1"
            });
        }

        public override DataTable search(EntitlementModel model)
        {
            return db.query(new Statement() {
                sql = @"PARAMETERS @Entitlement_Name TEXT,@Id NUMBER;
                         TRANSFORM IIF(count(pe.[Profile_Name])>0,'✓',NULL) 
                            SELECT e.[Id], e.[Entitlement_Name] 
                                   FROM " + this.TABLE_NAME + @"  e 
                              LEFT JOIN " + new Profile_EntitlementsController().TABLE_NAME + @" pe
                                ON pe.[Entitlement_Name] = e.[Entitlement_Name]
                             WHERE e.[Entitlement_Name] LIKE @Entitlement_Name
                                OR e.[Id] = @Id
                          GROUP BY e.[Id], e.[Entitlement_Name]
                          ORDER BY e.[Entitlement_Name]
                             PIVOT pe.[Profile_Name]
                                 ",
                parameters = getParameters( "Entitlement_Name,Id".Split(',') , model)
            });
        }
    }
}
