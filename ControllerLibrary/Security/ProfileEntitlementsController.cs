using ModelLibrary.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;
using ControllerLibrary.Common;

namespace ControllerLibrary.Security
{
    public class ProfileEntitlementsController : AbstractDBController<ProfileEntitlementsModel>
    {
        //public override string Source => "Security_Profile_Entitlements"; 


        public DataTable GetEntitlementsByProfile(string profile)
        {
            return database.Query(new Statement("P:ID") {
                Sql = $@"select e.*
                          from {new ProfileEntitlementsModel().GetSource()} pe
                    inner join {new EntitlementModel().GetSource()} e
                            on pe.[Entitlement_Name] = e.[Entitlement_Name]
                         where pe.[Profile_Name]=@Profile_Name",
                Parameters = new IDataParameter[] {
                    DBConnectionManager.Instance.GetDbDataParameter("@Profile_Name", DbType.String,50,profile)
                }
            });
        }

        public void clearEntitlementForProfile(string profile)
        {
            var model = new ProfileEntitlementsModel() { Profile_Name = profile };
            Statement statement = model.GetSelectStatement(new string[] { "Profile_Name" });


            //database.execute(new Statement(model.GetSource()) {
            //    Sql = $"delete from {model.GetSour y    ce()} where [Profile_Name]=@Profile_Name",
            //    Parameters = new IDataParameter[] {
            //        DBConnectionManager.Instance.GetDbDataParameter("@Profile_Name", DbType.String,50,profile)
            //    }
            //});
        }

        public void updateEntitlementForProfile(string profile,List<string> entitlements)
        {
            foreach(var entitlement in entitlements)
            {
                var model = new ProfileEntitlementsModel() {
                    Profile_Name = profile,
                    Entitlement_Name = entitlement
                };
                Statement stmt = model.GetInsertStatement();
                database.execute(stmt);
            }
        }
    }
}
