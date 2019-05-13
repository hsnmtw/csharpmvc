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
    public class Profile_EntitlementsController : AbstractController<Profile_EntitlementsModel>
    {
        public override string TABLE_NAME { get { return "Security_Profile_Entitlements"; } }

        public override void updateMetaData() {
            MetaData["Profile_Name"] = "TEXT(50)";
            MetaData["Entitlement_Name"] = "TEXT(50)";
        }


        public DataTable getEntitlementsByProfile(string profile)
        {
            return db.query(new Statement() {
                sql = @"select e.*
                          from "+ this.TABLE_NAME +@" pe
                    inner join "+ new EntitlementController().TABLE_NAME + @" e
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
                sql = @"delete from "+this.TABLE_NAME+" where [Profile_Name]=@Profile_Name",
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

        public override DataTable search(Profile_EntitlementsModel model)
        {
            Statement statement = getSelectStatement();
            statement.sql = string.Format("SELECT X0001.* FROM ({0}) AS X0001 WHERE ([Profile_Name]=? and [Entitlement_Name]=?) or [Id]=?", statement.sql);
            statement.parameters = getParameters("Profile_Name,Entitlement_Name,Id".Split(','),model);
            return db.query(statement);
        }

    }
}
