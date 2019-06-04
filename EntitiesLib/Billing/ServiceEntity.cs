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
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "BillingCategoryId", "ContractId" } }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
                ["ContractId"       ] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<ContractModel>().MetaData.Source,"Id"),
                ["BillingCategoryId"] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<BillingCategoryModel>().MetaData.Source, "Id"),
                ["CurrencyId"       ] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<CurrencyModel>().MetaData.Source, "Id"),
                ["VATId"            ] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<VATModel>().MetaData.Source, "Id")
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"   ] = 10,
                ["UpdatedBy"   ] = 10,
            }
            , Source           = ENTITIES.Service

        };
    }
}
