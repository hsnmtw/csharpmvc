using MVCWinform.Common;
using System.Collections.Generic;

namespace MVCWinform.Customers {
    [ForEntity(Entities.FoodClass)]
    public class FoodClassEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(FoodClassModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "FoodClass" }
            , GetUniqueKeyFields  = new string[] { "FoodClass" }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["FoodClass"    ] = 50
            }  
            , GetSource           = "BillingFoodClasses"
            
        };
    }
}
