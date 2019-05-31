using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.ProfileEntitlement)]
    public class ProfileEntitlementEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
              ModelType       = typeof(ProfileEntitlementModel)
            , PrimaryKeyField = "Id" 
            , RequiredFields  = new List<string> { "Id", "ProfileId", "EntitlementId" }
            , UniqueKeyFields = new List<string> { "ProfileId", "EntitlementId" }
            , ForeignKeys     = new Dictionary<string, System.Tuple<string, string>> {
                ["ProfileId"    ] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Profile).MetaData.Source, "Id"),
                ["EntitlementId"] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Entitlement).MetaData.Source, "Id"),
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"      ] = 50,
                ["UpdatedBy"      ] = 50,
            }
            , Source = "SecurityProfileEntitlement"            
        };
    }
}
