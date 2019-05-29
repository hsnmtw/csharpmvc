using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    [ForModel(MODELS.Building)]
    public class BuildingEntity : AbstractDBEntity,IDBEntity {

        public override MetaData MetaData => new MetaData() {
              ModelType = typeof(BuildingModel)
            , PrimaryKeyFields = new string[] { "Id" }
            , RequiredFields   = new string[] { "Id","BuildingName","BuildingType","CompoundName" }
            , UniqueKeyFields  = new string[] { "BuildingName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["BuildingName"] = 50
                ,["BuildingType"] = 50
                ,["CompoundName"] = 50
            }
            , Source = "HousingBuilding"
            
        };
    }
}
