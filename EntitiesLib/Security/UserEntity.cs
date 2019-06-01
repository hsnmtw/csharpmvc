using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.User)]
    public class UserEntity : AbstractDBEntity <UserModel> {

        public override MetaData MetaData => new MetaData() {
            //ModelType = typeof(UserModel)
              PrimaryKeyField = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                     "UserName", "FullName", "UserPassword", "ProfileId",
                                                     "IsActive", "Email", "FailedLoginAttempts",
                                                     "LastLoginDate", "LastChangePassword" }
            , RequiredFields  = new HashSet<string> {"Id","UserName","FullName","UserPassword","ProfileId"}
            , UniqueKeyFields = new HashSet<string> {"UserName"}
            , ForeignKeys     = new Dictionary<string, Tuple<string, string>> {
                ["ProfileId"] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<ProfileModel>().MetaData.Source,"Id") 
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"   ] = 50,
                ["UpdatedBy"   ] = 50,
                ["UserName"    ] = 50,
                ["FullName"    ] = 100,
                ["UserPassword"] = 100,
                ["Email"       ] = 100,
            }
            , Source = "SecurityUser"
        };
    }
}
