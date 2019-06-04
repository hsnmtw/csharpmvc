using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.FoodType)]
    public class FoodTypeEntity : AbstractDBEntity<FoodTypeModel> {
        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField    = "Id" 
            , Fields             = new HashSet<string> {"ReadOnly", "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn", "FoodTypeCode", "FoodTypeDesc" }
            , RequiredFields     = new HashSet<string> { "Id", "FoodTypeCode","FoodTypeDesc" }
            , UniqueKeyFields    = new HashSet<HashSet<string>> { new HashSet<string> { "FoodTypeCode" } }
            , ForeignKeys        = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"   ] = 10,
                ["UpdatedBy"   ] = 10,
                ["FoodTypeCode"] = 10,
                ["FoodTypeDesc"] = 100,
            }
            , Source           = ENTITIES.FoodType
        };
    }
}
