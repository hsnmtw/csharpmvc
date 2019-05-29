using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    [ForModel(MODELS.BillingCategory)]
    public class BillingCategoryEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(BillingCategoryModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id","BillingCategory","BillingClass","BillingCategoryDesc" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                    ["BillingCategory"    ] = 150
                   ,["BillingCategoryDesc"] = 250
                   ,["AccommClass"         ] = 50
                   ,["FoodClass"          ] = 50
                   ,["FoodType"           ] = 50
            }
            , GetSource           = "BillingCategory"
            , GetUniqueKeyFields  = new string[] { "BillingCategory" }
        };
    }
}