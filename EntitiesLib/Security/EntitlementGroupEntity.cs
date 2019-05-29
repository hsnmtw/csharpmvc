using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    [ForModel(MODELS.EntitlementGroup)]
    public class EntitlementGroupEntity : AbstractDBEntity{

        public override MetaData MetaData => new MetaData() {
            ModelType = typeof(EntitlementGroupModel)
            , PrimaryKeyFields = new string[]{ "Id" }
            , RequiredFields = new string[] { "Id","EntitlementGroupName" }
            , UniqueKeyFields = new string[] { "EntitlementGroupName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["EntitlementGroupName"] = 50
            }
            , Source = "SecurityEntitlementGroup"
            
        };
    }
}
