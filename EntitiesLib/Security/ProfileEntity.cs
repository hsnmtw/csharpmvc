using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    [ForModel(MODELS.Profile)]
    public class ProfileEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
            ModelType = typeof(ProfileModel)
            , PrimaryKeyFields = new string[]{ "Id" }
            , RequiredFields = new string[] { "Id", "ProfileName" }
            , UniqueKeyFields = new string[] { "ProfileName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["ProfileName"] = 50,
                ["ProfileDesc"] = 100,
            }
            , Source = "SecurityProfile"
            
        };
    }
}
