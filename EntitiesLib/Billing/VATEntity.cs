using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.VAT)]
    public class VATEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(VATModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "VATCode", "VATAmount", "VATDesc" }
            , UniqueKeyFields  = new List<string> { "VATCode" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"   ] = 50,
                ["UpdatedBy"   ] = 50,
                ["VATCode"     ] = 5,
                ["VATDesc"     ] = 50,
            }
            , Source           = "BillingVAT"

        };
    }
}
