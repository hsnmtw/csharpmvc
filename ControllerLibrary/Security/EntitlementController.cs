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
    public class EntitlementController : AbstractController {

        public EntitlementController() : base(CollectionsFactory.GetCollection(CollectionsEnum.Entitlement)) {

        }

        public override DataTable GetTable() {
        
            DataView dvE = new DataView(this.GetTable());
            DataView dvP = new DataView(new ProfileController().GetTable());
            DataTable dvPE = new ProfileEntitlementsController().GetTable();

            dvE.Sort = "Entitlement_Name ASC";
            dvP.Sort = "Profile_Name ASC";


            DataTable result = new DataTable();
            result.Columns.Add("Entitlement_Name");
            foreach (DataRow row in dvP.ToTable().Rows) {
                result.Columns.Add(row["Profile_Name"].ToString());
            }
            IDictionary<string, int> dictonary = new Dictionary<string, int>();
            int i = 0;
            foreach (DataRow row in dvE.ToTable().Rows) {
                result.Rows.Add(new object[] { row["Entitlement_Name"].ToString() });
                dictonary[row["Entitlement_Name"].ToString()] = i++;
            }
            foreach (DataRow dataRow in dvPE.Rows) {
                string col = dataRow["Profile_Name"].ToString();
                int row = dictonary[dataRow["Entitlement_Name"].ToString()];
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
        //        sql = @"PARAMETERS @Entitlement_Name TEXT,@Id NUMBER;
        //                 TRANSFORM IIF(count(pe.[Profile_Name])>0,'✓',NULL) 
        //                    SELECT e.[Id], e.[Entitlement_Name] 
        //                           FROM " + this.TABLE_NAME + @"  e 
        //                      LEFT JOIN " + new Profile_EntitlementsController().TABLE_NAME + @" pe
        //                        ON pe.[Entitlement_Name] = e.[Entitlement_Name]
        //                     WHERE e.[Entitlement_Name] LIKE @Entitlement_Name
        //                        OR e.[Id] = @Id
        //                  GROUP BY e.[Id], e.[Entitlement_Name]
        //                  ORDER BY e.[Entitlement_Name]
        //                     PIVOT pe.[Profile_Name]
        //                         ",
        //        parameters = getParameters( "Entitlement_Name,Id".Split(',') , model)
        //    });
        //}
    }
}
