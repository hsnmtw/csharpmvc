using MVCHIS.Common;
using MVCHIS.Tools;
using System;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.Entitlement)]
    public class EntitlementEntity : AbstractDBEntity<EntitlementModel> {

        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                     "EntitlementName","EntitlementGroupId","EntityId" }
            , RequiredFields  = new HashSet<string> { "Id","EntitlementName","EntitlementGroupId","EntityId" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "EntitlementName" } }
            , ForeignKeys     = new Dictionary<string, Tuple<MODELS, string>> {
                ["EntityId"          ] = new Tuple<MODELS, string>(MODELS.Entity,"Id"),
                ["EntitlementGroupId"] = new Tuple<MODELS, string>(MODELS.EntitlementGroup, "Id")
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"           ] = 10,
                ["UpdatedBy"           ] = 10,
                ["EntitlementName"     ] = 50,
            }
            , Source = ENTITIES.Entitlement
            
        };
    }
}
