using MVCWinform.Common;
using System.Collections.Generic;

namespace MVCWinform.Housing {
    [ForEntity(Entities.BuildingType)]
    public class BuildingTypeEntity : AbstractDBEntity,IDBEntity {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(BuildingTypeModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id","BuildingType" }
            , GetUniqueKeyFields  = new string[] { "BuildingType" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["BuildingType"]  = 50
            }
            , GetSource = "HousingBuildingTypes"
            
        };
    }
}
