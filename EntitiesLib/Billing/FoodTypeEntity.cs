using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    [ForModel(MODELS.FoodType)]
    public class FoodTypeEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(FoodTypeModel)
            , PrimaryKeyFields = new string[] { "Id" }
            , RequiredFields   = new string[] { "Id", "FoodTypeCode","FoodTypeDesc" }
            , UniqueKeyFields  = new string[] { "FoodTypeCode" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["FoodTypeCode"]      = 50,
                ["FoodTypeDesc"]      = 100,
            }
            , Source           = "BillingFoodType"
            
        };
    }
}
