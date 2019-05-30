using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    //[ForModel(MODELS.Building)]
    public class BuildingEntity : AbstractDBEntity,IDBEntity {

        public override MetaData MetaData => new MetaData() {
              ModelType = typeof(BuildingModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id","BuildingName","BuildingTypeId","CompoundId" }
            , UniqueKeyFields  = new List<string> { "BuildingName" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> {
                 ["CreatedBy"   ] = 50
                ,["UpdatedBy"   ] = 50
                ,["BuildingName"] = 50
                //,["BuildingType"] = 50
                //,["CompoundName"] = 50
            }
            , Source = "HousingBuilding"
            
        };
    }
}
