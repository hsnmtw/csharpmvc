using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    [ForModel(MODELS.ClientIdentification)]
    public class ClientIdentificationEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(ClientIdentificationModel)
            , PrimaryKeyFields = new string[] { "Id" }
            , RequiredFields   = new string[] { "Id", "ClientId", "IdentificationId" }
            , UniqueKeyFields  = new string[] { "ClientId", "IdentificationId" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,}
            , Source           = "CustomersClientIdentification"
        };
    }
}
