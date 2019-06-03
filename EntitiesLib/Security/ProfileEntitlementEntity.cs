using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.ProfileEntitlement)]
    public class ProfileEntitlementEntity : AbstractDBEntity<ProfileEntitlementModel> {

        public override MetaData MetaData => new MetaData() {
            //  ModelType       = typeof(ProfileEntitlementModel)
              PrimaryKeyField = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                     "ProfileId","EntitlementId","AllowCreate","AllowRead","AllowUpdate","AllowDelete" }
            , RequiredFields  = new HashSet<string> { "Id", "ProfileId", "EntitlementId" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "ProfileId", "EntitlementId" } }
            , ForeignKeys     = new Dictionary<string, Tuple<string, string>> {
                ["ProfileId"    ] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<ProfileModel    >().MetaData.Source, "Id"),
                ["EntitlementId"] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<EntitlementModel>().MetaData.Source, "Id"),
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"      ] = 10,
                ["UpdatedBy"      ] = 10,
            }
            , Source = "SecurityProfileEntitlement"            
        };
    }
}
