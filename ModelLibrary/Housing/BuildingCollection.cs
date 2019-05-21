using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Housing {
    public class BuildingCollection : AbstractCollection,BaseCollection {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(BuildingModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = "Id,Building_Name,Building_Type,Compound_Name".Split(',')
            , GetSource = "Housing_Building"
            , GetUniqueKeyFields = new string[] { "Building_Name" }
        };
    }
}
