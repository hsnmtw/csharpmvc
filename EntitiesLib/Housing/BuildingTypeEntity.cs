using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    [ForModel(MODELS.BuildingType)]
    public class BuildingTypeEntity : AbstractDBEntity,IDBEntity {

        public override MetaData MetaData => new MetaData() {
            ModelType = typeof(BuildingTypeModel)
            , PrimaryKeyFields = new string[] { "Id" }
            , RequiredFields   = new string[] { "Id","BuildingTypeCode" }
            , UniqueKeyFields  = new string[] { "BuildingTypeCode" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["BuildingTypeCode"]  = 50
            }
            , Source = "HousingBuildingType"
            
        };
    }
}
