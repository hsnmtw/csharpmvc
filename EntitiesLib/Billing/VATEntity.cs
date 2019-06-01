using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.VAT)]
    public class VATEntity : AbstractDBEntity<VATModel> {
        public override MetaData MetaData => new MetaData() {
            //  ModelType        = typeof(VATModel)
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                       "VATCode", "VATAmount", "VATDesc" }
            , RequiredFields   = new HashSet<string> { "Id", "VATCode", "VATAmount", "VATDesc" }
            , UniqueKeyFields  = new HashSet<string> { "VATCode" }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"   ] = 50,
                ["UpdatedBy"   ] = 50,
                ["VATCode"     ] = 5,
                ["VATDesc"     ] = 50,
            }
            , Source           = "BillingVAT"

        };
    }
}
