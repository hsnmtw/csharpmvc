using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.ClientIdentification)]
    public class ClientIdentificationEntity : AbstractDBEntity<ClientIdentificationModel> {
        public override MetaData MetaData => new MetaData() {
            ////  ModelType        = typeof(ClientIdentificationModel)
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly", "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn", "ClientId", "IdentificationId" }
            , RequiredFields   = new HashSet<string> { "Id", "ClientId", "IdentificationId" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "ClientId", "IdentificationId" } }
            , ForeignKeys      = new Dictionary<string, Tuple<MODELS, string>> {
                ["ClientId"        ] = new Tuple<MODELS, string>(MODELS.Client,"Id"),
                ["IdentificationId"] = new Tuple<MODELS, string>(MODELS.Identification,"Id"),
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"] = 10,
                ["UpdatedBy"] = 10,
            }
            , Source           = ENTITIES.ClientIdentification
        };
    }
}
