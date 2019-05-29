using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    [ForModel(MODELS.Entitlement)]
    public class EntitlementEntity : AbstractDBEntity{

        public override MetaData MetaData => new MetaData() {
            ModelType = typeof(EntitlementModel)
            , PrimaryKeyFields = new string[]{ "Id" }
            , RequiredFields = new string[] { "Id","EntitlementName" }
            , UniqueKeyFields = new string[] { "EntitlementName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["EntitlementName"] = 50,
                ["EntitlementGroupName"] = 50,
                ["EntityName"] = 50
            }
            , Source = "SecurityEntitlement"
            
        };
    }
}
