using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.Contract)]
    public class ContractEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(ContractModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "ContractCode","ClientId", "StartDate" }
            , UniqueKeyFields  = new List<string> { "ContractCode" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
                ["ClientId"] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Client).MetaData.Source,"Id")
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"   ] = 50,
                ["UpdatedBy"   ] = 50,
                ["ContractCode"] = 20,
                ["Conditions"  ] = 1000,
            }
            , Source           = "BillingContract"

        };
    }
}
