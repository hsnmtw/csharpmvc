using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.FoodClass)]
    public class FoodClassEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(FoodClassModel)
            , PrimaryKeyField = "Id" 
            , RequiredFields   = new List<string> { "Id", "FoodClassCode","FoodClassDesc" }
            , UniqueKeyFields  = new List<string> { "FoodClassCode" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["FoodClassCode"    ] = 50,
                ["FoodClassDesc"    ] = 100,
            }  
            , Source           = "BillingFoodClass"
            
        };
    }
}
