using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    [ForModel(MODELS.FoodClass)]
    public class FoodClassEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(FoodClassModel)
            , PrimaryKeyFields = new string[] { "Id" }
            , RequiredFields   = new string[] { "Id", "FoodClassCode","FoodClassDesc" }
            , UniqueKeyFields  = new string[] { "FoodClassCode" }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["FoodClassCode"    ] = 50,
                ["FoodClassDesc"    ] = 100,
            }  
            , Source           = "BillingFoodClass"
            
        };
    }
}
