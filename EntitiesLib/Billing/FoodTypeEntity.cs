using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.FoodType)]
    public class FoodTypeEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(FoodTypeModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "FoodTypeCode","FoodTypeDesc" }
            , UniqueKeyFields  = new List<string> { "FoodTypeCode" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["FoodTypeCode"]      = 50,
                ["FoodTypeDesc"]      = 100,
            }
            , Source           = "BillingFoodType"
            
        };
    }
}
