using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.Audit)]
    public class AuditEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType = typeof(AuditModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "EventDate", "EventComments" }
            , UniqueKeyFields  = new List<string> { "Id" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["EventComments"] = 1000,
                ["UserName"     ] = 50 
            }
            , Source = "SecurityAudit"
        };
    }
}
