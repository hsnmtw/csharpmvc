using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    [ForEntity(Entities.Entitlement)]
    public class EntitlementEntity : AbstractDBEntity{

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(EntitlementModel)
            , GetPrimaryKeyFields = new string[]{ "Id" }
            , GetRequiredFields = new string[] { "Id","EntitlementName" }
            , GetUniqueKeyFields = new string[] { "EntitlementName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["EntitlementName"] = 50,
                ["EntitlementGroupName"] = 50,
                ["EntityName"] = 50
            }
            , GetSource = "SecurityEntitlement"
            
        };
    }
}
