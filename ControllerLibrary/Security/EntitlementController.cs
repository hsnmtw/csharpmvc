using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Security;
using ControllerLibrary.Common;
using ModelLibrary.Common;
using System.Windows.Forms;

namespace ControllerLibrary.Security
{
    [ForControllerAttribute(Entities.Entitlement, Enabled = true)]
    public class EntitlementController : AbstractDBController {

        public EntitlementController() : base(DBEntitiesFactory.GetEntity(Entities.Entitlement)) { }

        public override DataTable GetTable() {
        
            DataView dvE = new DataView(this.GetTable());
            DataView dvP = new DataView(DBControllersFactory.GetController(Entities.Profile).GetTable());
            DataTable dvPE = DBControllersFactory.GetController(Entities.ProfileEntitlement).GetTable();

            dvE.Sort = "EntitlementName ASC";
            dvP.Sort = "ProfileName ASC";


            DataTable result = new DataTable();
            result.Columns.Add("EntitlementName");
            foreach (DataRow row in dvP.ToTable().Rows) {
                result.Columns.Add(row["ProfileName"].ToString());
            }
            IDictionary<string, int> dictonary = new Dictionary<string, int>();
            int i = 0;
            foreach (DataRow row in dvE.ToTable().Rows) {
                result.Rows.Add(new object[] { row["EntitlementName"].ToString() });
                dictonary[row["EntitlementName"].ToString()] = i++;
            }
            foreach (DataRow dataRow in dvPE.Rows) {
                string col = dataRow["ProfileName"].ToString();
                int row = dictonary[dataRow["EntitlementName"].ToString()];
                if (!result.Columns.Contains(col)) {
                    result.Columns.Add(col);
                }
                result.Rows[row][col] = "✓";
            }
            return result;
        }


        //public override DataTable search(EntitlementModel model)
        //{
        //    return db.query(new Statement(this.Source) {
        //        sql = @"PARAMETERS @EntitlementName TEXT,@Id NUMBER;
        //                 TRANSFORM IIF(count(pe.[ProfileName])>0,'✓',NULL) 
        //                    SELECT e.[Id], e.[EntitlementName] 
        //                           FROM " + this.TABLENAME + @"  e 
        //                      LEFT JOIN " + new ProfileEntitlementsController().TABLENAME + @" pe
        //                        ON pe.[EntitlementName] = e.[EntitlementName]
        //                     WHERE e.[EntitlementName] LIKE @EntitlementName
        //                        OR e.[Id] = @Id
        //                  GROUP BY e.[Id], e.[EntitlementName]
        //                  ORDER BY e.[EntitlementName]
        //                     PIVOT pe.[ProfileName]
        //                         ",
        //        parameters = getParameters( "EntitlementName,Id".Split(',') , model)
        //    });
        //}
    }
}
