using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Housing {
    public class BuildingTypeCollection : AbstractCollection,BaseCollection {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(BuildingTypeModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = "Id,Building_Type".Split(',')
            , GetSource = "Housing_Building_Types"
            , GetUniqueKeyFields = new string[] { "Building_Type" }
        };
    }
}
