using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    [ForEntity(Entities.ClientIdentification)]
    public class ClientIdentificationEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(ClientIdentificationModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "ClientId", "IdentificationId" }
            , GetUniqueKeyFields  = new string[] { "ClientId", "IdentificationId" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,}
            , GetSource           = "CustomersClientIdentification"
        };
    }
}
