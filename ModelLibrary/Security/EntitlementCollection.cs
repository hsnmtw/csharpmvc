using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Security
{
    public class EntitlementCollection : AbstractCollection{

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(EntitlementModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = new string[] { "Id","EntitlementName" }
            , GetSource = "SecurityEntitlements"
            , GetUniqueKeyFields = new string[] { "EntitlementName" }
        };
    }
}
