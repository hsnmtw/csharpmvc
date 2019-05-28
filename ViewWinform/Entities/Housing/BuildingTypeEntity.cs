using MVCWinform.Common;
using System.Collections.Generic;

namespace MVCWinform.Housing {
    [ForEntity(Entities.BuildingType)]
    public class BuildingTypeEntity : AbstractDBEntity,IDBEntity {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(BuildingTypeModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id","BuildingTypeCode" }
            , GetUniqueKeyFields  = new string[] { "BuildingTypeCode" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["BuildingTypeCode"]  = 50
            }
            , GetSource = "HousingBuildingType"
            
        };
    }
}
