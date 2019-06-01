using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    //[ForModel(MODELS.Building)]
    public class BuildingEntity : AbstractDBEntity<BuildingModel> {

        public override MetaData MetaData => new MetaData() {
            //  ModelType = typeof(BuildingModel)
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly", "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn",
                                                       "BuildingName", "BuildingTypeId", "CompoundId" }
            , RequiredFields   = new HashSet<string> { "Id","BuildingName","BuildingTypeId","CompoundId" }
            , UniqueKeyFields  = new HashSet<string> { "BuildingName" }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
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
