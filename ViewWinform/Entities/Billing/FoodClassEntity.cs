using MVCWinform.Common;
using System.Collections.Generic;

namespace MVCWinform.Customers {
    [ForEntity(Entities.FoodClass)]
    public class FoodClassEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(FoodClassModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "FoodClassCode","FoodClassDesc" }
            , GetUniqueKeyFields  = new string[] { "FoodClassCode" }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["FoodClassCode"    ] = 50,
                ["FoodClassDesc"    ] = 100,
            }  
            , GetSource           = "BillingFoodClass"
            
        };
    }
}
