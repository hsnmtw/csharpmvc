using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    [ForModel(MODELS.User)]
    public class UserEntity : AbstractDBEntity{

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(UserModel)
            , GetPrimaryKeyFields = new string[]{ "Id" }
            , GetRequiredFields = new string[]{"Id","UserName","FullName","UserPassword"}
            , GetUniqueKeyFields = new string[] { "UserName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["UserName"]     = 50,
                ["FullName"]     = 100,
                ["UserPassword"] = 100,
                ["ProfileName"]  = 50,
                ["Email"]        = 100,
            }
            , GetSource = "SecurityUser"
        };
    }
}
