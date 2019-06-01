using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.FoodType)]
    public class FoodTypeEntity : AbstractDBEntity<FoodTypeModel> {
        public override MetaData MetaData => new MetaData() {
            //  ModelType        = typeof(FoodTypeModel)
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly", "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn", "FoodTypeCode", "FoodTypeDesc" }
            , RequiredFields   = new HashSet<string> { "Id", "FoodTypeCode","FoodTypeDesc" }
            , UniqueKeyFields  = new HashSet<string> { "FoodTypeCode" }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"] = 50,
                ["UpdatedBy"] = 50,
                ["FoodTypeCode"]      = 50,
                ["FoodTypeDesc"]      = 100,
            }
            , Source           = "BillingFoodType"
            
        };
    }
}
