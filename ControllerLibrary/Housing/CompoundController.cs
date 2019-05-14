using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Housing;
using ControllerLibrary.Common;
using DBManagerLibrary.Common;

namespace ControllerLibrary.Housing
{
    public class CompoundController : AbstractController<CompoundModel>
    {
        public override string TABLE_NAME { get { return "Housing_Compounds"; } }
        public override void updateMetaData() {
            MetaData["Compound_Name"] = "TEXT(50)";
        }

        public override DataTable search(CompoundModel model)
        {
            return db.query(new Statement() {
                sql = @"SELECT * FROM " + this.TABLE_NAME + " WHERE [Id]=@Id OR [Compound_Name]=@Compound_Name",
                parameters = getParameters( "Compound_Name,Id".Split(',') , model)
            });
        }
    }
}
