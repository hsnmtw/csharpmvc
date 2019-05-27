using MVCWinform.Common;
using System.Collections.Generic;

namespace MVCWinform.Customers {
    [ForEntity(Entities.FoodType)]
    public class FoodTypeEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(FoodTypeModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "FoodType" }
            , GetUniqueKeyFields  = new string[] { "FoodType" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["FoodType"]      = 50
            }
            , GetSource           = "BillingFoodTypes"
            
        };
    }
}
