using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.Entitlement)]
    public class EntitlementEntity : AbstractDBEntity{

        public override MetaData MetaData => new MetaData() {
              ModelType       = typeof(EntitlementModel)
            , PrimaryKeyField = "Id" 
            , RequiredFields  = new List<string> { "Id","EntitlementName","EntitlementGroupId","EntityId" }
            , UniqueKeyFields = new List<string> { "EntitlementName" }
            , ForeignKeys     = new Dictionary<string, System.Tuple<string, string>> {
                ["EntityId"]  = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Entity).MetaData.Source,"Id"),
                ["EntitlementGroupId"] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.EntitlementGroup).MetaData.Source, "Id")
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"           ] = 50,
                ["UpdatedBy"           ] = 50,
                ["EntitlementName"     ] = 50,
            }
            , Source = "SecurityEntitlement"
            
        };
    }
}
