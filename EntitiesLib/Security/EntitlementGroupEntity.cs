using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    [ForModel(MODELS.EntitlementGroup)]
    public class EntitlementGroupEntity : AbstractDBEntity{

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(EntitlementGroupModel)
            , GetPrimaryKeyFields = new string[]{ "Id" }
            , GetRequiredFields = new string[] { "Id","EntitlementGroupName" }
            , GetUniqueKeyFields = new string[] { "EntitlementGroupName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["EntitlementGroupName"] = 50
            }
            , GetSource = "SecurityEntitlementGroup"
            
        };
    }
}
