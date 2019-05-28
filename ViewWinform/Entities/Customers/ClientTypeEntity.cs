using MVCWinform.Common;
using System.Collections.Generic;

namespace MVCWinform.Customers {
    [ForEntity(Entities.ClientType)]
    public class ClientTypeEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(ClientTypeModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id","ClientType" }            
            , GetUniqueKeyFields  = new string[] { "ClientType" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["ClientType"] = 50
            }
            , GetSource = "CustomersClientType"
        };
    }
}
