using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.Service)]
    public class ServiceEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(ServiceModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "BillingCategoryId", "ContractId", "Price", "CurrencyId","EffectiveFromDate","VATId" }
            , UniqueKeyFields  = new List<string> { "BillingCategoryId", "ContractId" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
                ["ContractId"       ] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Contract).MetaData.Source,"Id"),
                ["BillingCategoryId"] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.BillingCategory).MetaData.Source, "Id"),
                ["CurrencyId"       ] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Currency).MetaData.Source, "Id"),
                ["VATId"            ] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.VAT).MetaData.Source, "Id")
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"   ] = 50,
                ["UpdatedBy"   ] = 50,
            }
            , Source           = "BillingService"

        };
    }
}
