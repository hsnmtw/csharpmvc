using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    //[ForModel(MODELS.BuildingType)]
    public class BuildingTypeEntity : AbstractDBEntity,IDBEntity {

        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(BuildingTypeModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id","BuildingTypeCode" }
            , UniqueKeyFields  = new List<string> { "BuildingTypeCode" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            } 
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"       ] = 50,
                ["UpdatedBy"       ] = 50,
                ["BuildingTypeCode"] = 50
            }
            , Source = "HousingBuildingType"
            
        };
    }
}
