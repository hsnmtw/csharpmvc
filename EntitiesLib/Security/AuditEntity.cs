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
            , ForeignKeys      = new Dictionary<string, Tuple<MODELS, string>> {
                ["UserName"]   = new Tuple<MODELS, string>(MODELS.User,"UserName")
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"    ] = 10,
                ["UpdatedBy"    ] = 10,
                ["EventComments"] = 200,
                ["UserName"     ] = 10 
            }
            , Source = ENTITIES.Audit
        };

        public override string Validate(AuditModel model) {
            return "[]"; //disable validation
        }
        public override int Create(AuditModel model) {
            if (model.EventComments.Length > 200) model.EventComments = model.EventComments.Substring(0, 200);
            return base.Create(model);
        }
    }
}   
