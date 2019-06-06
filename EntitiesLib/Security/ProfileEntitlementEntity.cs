﻿using MVCHIS.Common;
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
            , ForeignKeys     = new Dictionary<string, Tuple<string, string>> {
                ["ProfileId"    ] = new Tuple<string, string>(ENTITIES.Profile    , "Id"),
                ["EntitlementId"] = new Tuple<string, string>(ENTITIES.Entitlement, "Id"),
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"      ] = 10,
                ["UpdatedBy"      ] = 10,
            }
            , Source = ENTITIES.ProfileEntitlement            
        };
    }
}
