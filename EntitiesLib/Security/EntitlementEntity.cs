using MVCHIS.Common;
using MVCHIS.Tools;
using System;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.Entitlement)]
    public class EntitlementEntity : AbstractDBEntity<EntitlementModel> {

        public override MetaData MetaData => new MetaData() {
            //  ModelType       = typeof(EntitlementModel)
              PrimaryKeyField = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                     "EntitlementName","EntitlementGroupId","EntityId" }
            , RequiredFields  = new HashSet<string> { "Id","EntitlementName","EntitlementGroupId","EntityId" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "EntitlementName" } }
            , ForeignKeys     = new Dictionary<string, Tuple<string, string>> {
                ["EntityId"          ] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<EntityModel>().MetaData.Source,"Id"),
                ["EntitlementGroupId"] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<EntitlementGroupModel>().MetaData.Source, "Id")
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"           ] = 10,
                ["UpdatedBy"           ] = 10,
                ["EntitlementName"     ] = 50,
            }
            , Source = "SecurityEntitlement"
            
        };
    }
}
