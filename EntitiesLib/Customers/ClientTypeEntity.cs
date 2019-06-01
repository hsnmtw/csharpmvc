using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.ClientType)]
    public class ClientTypeEntity : AbstractDBEntity<ClientTypeModel> {
        public override MetaData MetaData => new MetaData() {
            ////  ModelType        = typeof(ClientTypeModel)
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly", "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn", "ClientTypeCode" }
            , RequiredFields   = new HashSet<string> { "Id","ClientTypeCode" }            
            , UniqueKeyFields  = new HashSet<string> { "ClientTypeCode" }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"] = 50,
                ["UpdatedBy"] = 50,
                ["ClientTypeCode"] = 50
            }
            , Source = "CustomersClientType"
        };
    }
}
