using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.Profile)]
    public class ProfileEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
            ModelType = typeof(ProfileModel)
            , PrimaryKeyField = "Id" 
            , RequiredFields  = new List<string> { "Id", "ProfileName" }
            , UniqueKeyFields = new List<string> { "ProfileName" }
            , ForeignKeys     = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"  ] = 50,
                ["UpdatedBy"  ] = 50,
                ["ProfileName"] = 50,
                ["ProfileDesc"] = 100,
            }
            , Source = "SecurityProfile"
            
        };
    }
}
