using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Security {
    public class AuditCollection : AbstractCollection {
        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(AuditModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = "Id,Event_Date,Event_Comments".Split(',')
            , GetSource = "Security_Audit"
            , GetUniqueKeyFields = new string[] { }
        };
    }
}
