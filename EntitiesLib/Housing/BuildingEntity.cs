using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    //[ForModel(MODELS.Building)]
    public class BuildingEntity : AbstractDBEntity<BuildingModel> {

        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly", "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn",
                                                       "BuildingName", "BuildingTypeId", "CompoundId" }
            , RequiredFields   = new HashSet<string> { "Id","BuildingName","BuildingTypeId","CompoundId" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "BuildingName" } }
            , ForeignKeys      = new Dictionary<string, Tuple<MODELS, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                 ["CreatedBy"   ] = 10
                ,["UpdatedBy"   ] = 10
                ,["BuildingName"] = 10
            }
            , Source = ENTITIES.Building
            
        };
    }
}
