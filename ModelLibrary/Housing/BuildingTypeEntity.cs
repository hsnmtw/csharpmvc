using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Housing {
    public class BuildingTypeEntity : AbstractDBEntity,IDBEntity {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(BuildingTypeModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = "Id,BuildingType".Split(',')
            , GetSource = "HousingBuildingTypes"
            , GetUniqueKeyFields = new string[] { "BuildingType" }
        };
    }
}
