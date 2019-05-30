using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.ClientType)]
    public class ClientTypeEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(ClientTypeModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id","ClientType" }            
            , UniqueKeyFields  = new List<string> { "ClientType" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"] = 50,
                ["UpdatedBy"] = 50,
                ["ClientType"] = 50
            }
            , Source = "CustomersClientType"
        };
    }
}
