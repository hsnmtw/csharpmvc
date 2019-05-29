using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    [ForModel(MODELS.Audit)]
    public class AuditEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType = typeof(AuditModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "EventDate", "EventComments" }
            , GetUniqueKeyFields  = new string[] { "Id" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["EventComments"] = 1000,
                ["UserName"     ] = 50 
            }
            , GetSource = "SecurityAudit"
        };
    }
}
