using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    [ForModel(MODELS.ClientType)]
    public class ClientTypeEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(ClientTypeModel)
            , PrimaryKeyFields = new string[] { "Id" }
            , RequiredFields   = new string[] { "Id","ClientType" }            
            , UniqueKeyFields  = new string[] { "ClientType" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["ClientType"] = 50
            }
            , Source = "CustomersClientType"
        };
    }
}
