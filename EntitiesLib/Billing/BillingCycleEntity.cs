using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.BillingCategory)]
    public class BillingCycleEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(BillingCycleModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "BillingCycleYear", "BillingCycleMonth" }
            , UniqueKeyFields  = new List<string> { "BillingCycleYear", "BillingCycleMonth" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"] = 50,
                ["UpdatedBy"] = 50,
            }
            , Source           = "BillingCycle"
        };
    }
}