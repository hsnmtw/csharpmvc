using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Security
{
    public class EntitlementGroupCollection : AbstractCollection{

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(EntitlementGroupModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = new string[] { "Id","EntitlementGroupName" }
            , GetSource = "SecurityEntitlementGroups"
            , GetUniqueKeyFields = new string[] { "EntitlementGroupName" }
        };
    }
}
