using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.Audit)]
    public class AuditEntity : AbstractDBEntity<AuditModel> {
        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "UserName","EventDate", "EventComments" }
            , RequiredFields   = new HashSet<string> { "Id", "EventDate", "EventComments" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "Id" } }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
                ["UserName"]   = new Tuple<string, string>(DBEntitiesFactory.GetEntity<UserModel>().MetaData.Source,"UserName")
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"    ] = 10,
                ["UpdatedBy"    ] = 10,
                ["EventComments"] = 200,
                ["UserName"     ] = 10 
            }
            , Source = ENTITIES.Audit
        };
    }
}   
