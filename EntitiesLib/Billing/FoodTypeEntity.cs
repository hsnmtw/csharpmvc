using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    [ForModel(MODELS.FoodType)]
    public class FoodTypeEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(FoodTypeModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "FoodTypeCode","FoodTypeDesc" }
            , GetUniqueKeyFields  = new string[] { "FoodTypeCode" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["FoodTypeCode"]      = 50,
                ["FoodTypeDesc"]      = 100,
            }
            , GetSource           = "BillingFoodType"
            
        };
    }
}
