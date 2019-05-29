using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    [ForEntity(Entities.ProfileEntitlement)]
    public class ProfileEntitlementsEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(ProfileEntitlementsModel)
            , GetPrimaryKeyFields = new string[]{ "Id" }
            , GetRequiredFields = new string[] { "Id", "ProfileName", "EntitlementName" }
            , GetUniqueKeyFields = new string[] { "ProfileName", "EntitlementName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["EntitlementName"] = 50,
                ["ProfileName"    ] = 50
            }
            , GetSource = "SecurityProfileEntitlement"            
        };
    }
}
