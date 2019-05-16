using ModelLibrary.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManagerLibrary.Common;
using ControllerLibrary.Common;

namespace ControllerLibrary.Security
{
    public class Profile_EntitlementsController : AbstractDBController<Profile_EntitlementsModel>
    {
        public override string Source => "Security_Profile_Entitlements"; 


        public DataTable getEntitlementsByProfile(string profile)
        {
            return db.query(new Statement() {
                sql = @"select e.*
                          from "+ this.Source +@" pe
                    inner join "+ new EntitlementController().Source + @" e
                            on pe.[Entitlement_Name] = e.[Entitlement_Name]
                         where pe.[Profile_Name]=@Profile_Name",
                parameters = new IDataParameter[] {
                    DBConnectionManager.Instance.getDbDataParameter("@Profile_Name", DbType.String,50,profile)
                }
            });
        }

        public void clearEntitlementForProfile(string profile)
        {
            db.execute(new Statement() {
                sql = @"delete from "+this.Source+" where [Profile_Name]=@Profile_Name",
                parameters = new IDataParameter[] {
                    DBConnectionManager.Instance.getDbDataParameter("@Profile_Name", DbType.String,50,profile)
                }
            });
        }

        public void updateEntitlementForProfile(string profile,List<string> entitlements)
        {
            foreach(var entitlement in entitlements)
            {
                Statement stmt = getInsertStatement(new Profile_EntitlementsModel() {
                    Profile_Name=profile,
                    Entitlement_Name=entitlement
                });
                db.execute(stmt);
            }
        }
    }
}
