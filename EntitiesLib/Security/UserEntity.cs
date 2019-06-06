using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.User)]
    public class UserEntity : AbstractDBEntity <UserModel> {

        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                     "UserName", "FullName", "UserPassword", "ProfileId",
                                                     "IsActive", "Email", "FailedLoginAttempts",
                                                     "LastLoginDate", "LastChangePassword" }
            , RequiredFields  = new HashSet<string> {"Id","UserName","FullName","UserPassword","ProfileId"}
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "UserName" } }
            , ForeignKeys     = new Dictionary<string, Tuple<string, string>> {
                ["ProfileId"] = new Tuple<string, string>(ENTITIES.Profile,"Id") 
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"   ] = 10,
                ["UpdatedBy"   ] = 10,
                ["UserName"    ] = 10,
                ["FullName"    ] = 100,
                ["UserPassword"] = 100,
                ["Email"       ] = 100,
            }
            , Source = ENTITIES.User
        };
    }
}
