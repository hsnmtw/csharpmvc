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
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
                ["ClientId"        ] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<ClientModel        >().MetaData.Source,"Id"),
                ["IdentificationId"] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<IdentificationModel>().MetaData.Source,"Id"),
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"] = 10,
                ["UpdatedBy"] = 10,
            }
            , Source           = ENTITIES.ClientIdentification
        };
    }
}
