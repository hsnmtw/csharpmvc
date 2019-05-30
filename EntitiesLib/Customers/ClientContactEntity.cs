using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.ClientContact)]
    public class ClientContactEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(ClientContactModel)
            , PrimaryKeyField = "Id" 
            , RequiredFields   = new List<string> { "Id", "ClientId", "ContactId" }
            , UniqueKeyFields  = new List<string> { "ClientId", "ContactId" }
            , ForeignKeys = new Dictionary<string, System.Tuple<string, string>> {
                ["ClientId"]  = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Client).MetaData.Source, "Id"),
                ["ContactId"] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Contact).MetaData.Source, "Id"),
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,}
            , Source           = "CustomersClientContact"
        };
    }
}
