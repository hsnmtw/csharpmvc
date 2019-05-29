using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    [ForModel(MODELS.ProfileEntitlement)]
    public class ProfileEntitlementsEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
            ModelType = typeof(ProfileEntitlementsModel)
            , PrimaryKeyFields = new string[]{ "Id" }
            , RequiredFields = new string[] { "Id", "ProfileName", "EntitlementName" }
            , UniqueKeyFields = new string[] { "ProfileName", "EntitlementName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["EntitlementName"] = 50,
                ["ProfileName"    ] = 50
            }
            , Source = "SecurityProfileEntitlement"            
        };
    }
}
