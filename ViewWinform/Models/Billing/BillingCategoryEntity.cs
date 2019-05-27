using MVCWinform.Common;
using System.Collections.Generic;

namespace MVCWinform.Customers {
    [ForEntity(Entities.BillingCategory)]
    public class BillingCategoryEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(BillingCategoryModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id","BillingCategory","BillingClass","BillingCategoryDesc" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                    ["BillingCategory"    ] = 150
                   ,["BillingCategoryDesc"] = 250
                   ,["AccomClass"         ] = 50
                   ,["FoodClass"          ] = 50
                   ,["FoodType"           ] = 50
            }
            , GetSource           = "BillingCategories"
            , GetUniqueKeyFields  = new string[] { "BillingCategory" }
        };
    }
}
/*
    ["BillingCategory"    ] = 50
   ,["BillingCategoryDesc"] = 50
   ,["AccomClass"         ] = 50
   ,["FoodClass"          ] = 50
   ,["FoodType"           ] = 50
   ,["ReservationOnly"    ] = BOOLEAN
*/