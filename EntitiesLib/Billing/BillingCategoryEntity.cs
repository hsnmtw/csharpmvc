using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.BillingCategory)]
    public class BillingCategoryEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(BillingCategoryModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id","BillingCategory","BillingClass","BillingCategoryDesc" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                    ["BillingCategory"    ] = 150
                   ,["BillingCategoryDesc"] = 250
                   ,["AccommClass"         ] = 50
                   ,["FoodClass"          ] = 50
                   ,["FoodType"           ] = 50
            }
            , Source           = "BillingCategory"
            , UniqueKeyFields  = new string[] { "BillingCategory" }
        };
    }
}