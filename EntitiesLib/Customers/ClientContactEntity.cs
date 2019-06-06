using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.ClientContact)]
    public class ClientContactEntity : AbstractDBEntity<ClientContactModel> {
        public override MetaData MetaData => new MetaData() {
            ////  ModelType        = typeof(ClientContactModel)
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly", "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn", "ClientId", "ContactId" }
            , RequiredFields   = new HashSet<string> { "Id", "ClientId", "ContactId" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "ClientId", "ContactId" } }
            , ForeignKeys = new Dictionary<string, Tuple<string, string>> {
                ["ClientId"]  = new Tuple<string, string>(ENTITIES.Client, "Id"),
                ["ContactId"] = new Tuple<string, string>(ENTITIES.Contact, "Id"),
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"] = 10,
                ["UpdatedBy"] = 10,
            }
            , Source           = ENTITIES.ClientContact
        };
    }
}
