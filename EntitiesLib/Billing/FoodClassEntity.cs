using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.FoodClass)]
    public class FoodClassEntity : AbstractDBEntity<FoodClassModel> {
        public override MetaData MetaData => new MetaData() {
            //  ModelType        = typeof(FoodClassModel)
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly", "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn", "FoodClassCode", "FoodClassDesc" }
            , RequiredFields   = new HashSet<string> { "Id", "FoodClassCode","FoodClassDesc" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "FoodClassCode" } }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"] = 10,
                ["UpdatedBy"] = 10,
                ["FoodClassCode"    ] = 50,
                ["FoodClassDesc"    ] = 100,
            }  
            , Source           = "BillingFoodClass"
            
        };
    }
}
