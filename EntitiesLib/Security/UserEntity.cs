using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Security {
    [ForModel(MODELS.User)]
    public class UserEntity : AbstractDBEntity{

        public override MetaData MetaData => new MetaData() {
            ModelType = typeof(UserModel)
            , PrimaryKeyFields = new string[]{ "Id" }
            , RequiredFields = new string[]{"Id","UserName","FullName","UserPassword"}
            , UniqueKeyFields = new string[] { "UserName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["UserName"]     = 50,
                ["FullName"]     = 100,
                ["UserPassword"] = 100,
                ["ProfileName"]  = 50,
                ["Email"]        = 100,
            }
            , Source = "SecurityUser"
        };
    }
}
