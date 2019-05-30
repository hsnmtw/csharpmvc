using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.ClientIdentification)]
    public class ClientIdentificationEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(ClientIdentificationModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "ClientId", "IdentificationId" }
            , UniqueKeyFields  = new List<string> { "ClientId", "IdentificationId" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
                ["ClientId"        ] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Client).MetaData.Source,"Id"),
                ["IdentificationId"] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Identification).MetaData.Source,"Id"),
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,}
            , Source           = "CustomersClientIdentification"
        };
    }
}
