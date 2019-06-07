using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.Service)]
    public class ServiceEntity : AbstractDBEntity<ServiceModel> {
        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                  "BillingCategoryId","ContractId","Price","CurrencyId","EffectiveFromDate","Expired","VATId" }
            , RequiredFields   = new HashSet<string> { "Id", "BillingCategoryId", "ContractId", "Price", "CurrencyId","EffectiveFromDate","VATId" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "ContractId", "BillingCategoryId" } }
            , ForeignKeys      = new Dictionary<string, Tuple<MODELS, string>> {
                ["ContractId"       ] = new Tuple<MODELS, string>(MODELS.Contract,"Id"),
                ["BillingCategoryId"] = new Tuple<MODELS, string>(MODELS.BillingCategory, "Id"),
                ["CurrencyId"       ] = new Tuple<MODELS, string>(MODELS.Currency, "Id"),
                ["VATId"            ] = new Tuple<MODELS, string>(MODELS.VAT, "Id")
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"   ] = 10,
                ["UpdatedBy"   ] = 10,
            }
            , Source           = ENTITIES.Service

        };
    }
}
