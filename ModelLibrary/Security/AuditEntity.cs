using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Security {
    public class AuditEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(AuditModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = "Id,EventDate,EventComments".Split(',')
            , GetSource = "SecurityAudit"
            , GetUniqueKeyFields = new string[] { }
        };
    }
}
