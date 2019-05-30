using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.ProfileEntitlement)]
    public class ProfileEntitlementEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
              ModelType       = typeof(ProfileEntitlementModel)
            , PrimaryKeyField = "Id" 
            , RequiredFields  = new List<string> { "Id", "ProfileName", "EntitlementName" }
            , UniqueKeyFields = new List<string> { "ProfileName", "EntitlementName" }
            , ForeignKeys     = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"      ] = 50,
                ["UpdatedBy"      ] = 50,
                ["EntitlementName"] = 50,
                ["ProfileName"    ] = 50
            }
            , Source = "SecurityProfileEntitlement"            
        };
    }
}
