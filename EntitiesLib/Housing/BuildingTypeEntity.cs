using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    //[ForModel(MODELS.BuildingType)]
    public class BuildingTypeEntity : AbstractDBEntity<BuildingTypeModel> {

        public override MetaData MetaData => new MetaData() {
            ////  ModelType        = typeof(BuildingTypeModel)
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly", "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn", "BuildingTypeCode" }
            , RequiredFields   = new HashSet<string> { "Id","BuildingTypeCode" }
            , UniqueKeyFields  = new HashSet<string> { "BuildingTypeCode" }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            } 
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"       ] = 50,
                ["UpdatedBy"       ] = 50,
                ["BuildingTypeCode"] = 50
            }
            , Source = "HousingBuildingType"
            
        };
    }
}
