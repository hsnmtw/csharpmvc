using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.ProfileEntitlement)]
    public class ProfileEntitlementEntity : AbstractDBEntity<ProfileEntitlementModel> {

        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                     "ProfileId","EntitlementId","AllowCreate","AllowRead","AllowUpdate","AllowDelete" }
            , RequiredFields  = new HashSet<string> { "Id", "ProfileId", "EntitlementId" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "ProfileId", "EntitlementId" } }
            , ForeignKeys     = new Dictionary<string, Tuple<MODELS, string>> {
                ["ProfileId"    ] = new Tuple<MODELS, string>(MODELS.Profile    , "Id"),
                ["EntitlementId"] = new Tuple<MODELS, string>(MODELS.Entitlement, "Id"),
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"      ] = 10,
                ["UpdatedBy"      ] = 10,
            }
            , Source = ENTITIES.ProfileEntitlement            
        };
    }
}
