using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.EntitlementGroup)]
    public class EntitlementGroupEntity : AbstractDBEntity{

        public override MetaData MetaData => new MetaData() {
              ModelType       = typeof(EntitlementGroupModel)
            , PrimaryKeyField = "Id" 
            , RequiredFields  = new List<string> { "Id","EntitlementGroupName" }
            , UniqueKeyFields = new List<string> { "EntitlementGroupName" }
            , ForeignKeys     = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["EntitlementGroupName"] = 50
            }
            , Source = "SecurityEntitlementGroup"
            
        };
    }
}
