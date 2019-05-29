using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    [ForModel(MODELS.ClientContact)]
    public class ClientContactEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(ClientContactModel)
            , PrimaryKeyFields = new string[] { "Id" }
            , RequiredFields   = new string[] { "Id", "ClientId", "ContactId" }
            , UniqueKeyFields  = new string[] { "ClientId", "ContactId" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,}
            , Source           = "CustomersClientContact"
        };
    }
}
