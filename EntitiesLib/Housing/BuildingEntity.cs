using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    [ForModel(MODELS.Building)]
    public class BuildingEntity : AbstractDBEntity,IDBEntity {

        public override MetaData MetaData => new MetaData() {
              GetModelType = typeof(BuildingModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id","BuildingName","BuildingType","CompoundName" }
            , GetUniqueKeyFields  = new string[] { "BuildingName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["BuildingName"] = 50
                ,["BuildingType"] = 50
                ,["CompoundName"] = 50
            }
            , GetSource = "HousingBuilding"
            
        };
    }
}
