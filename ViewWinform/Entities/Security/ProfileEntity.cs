using MVCWinform.Common;
using System.Collections.Generic;

namespace MVCWinform.Security {
    [ForEntity(Entities.Profile)]
    public class ProfileEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(ProfileModel)
            , GetPrimaryKeyFields = new string[]{ "Id" }
            , GetRequiredFields = new string[] { "Id", "ProfileName" }
            , GetUniqueKeyFields = new string[] { "ProfileName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["ProfileName"] = 50,
                ["ProfileDesc"] = 100,
            }
            , GetSource = "SecurityProfile"
            
        };
    }
}
