using System;
using System.Collections.Generic;
using System.Text;
using ModelLibrary.Common;

namespace ModelLibrary.Security
{
    public class UserCollection : AbstractCollection{

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(UserModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = "Id,User_Name,User_Password,Created_By,Created_On".Split(',')
            , GetSource = "Security_Users"
            , GetUniqueKeyFields = new string[] { "User_Name" }
        };
    }
}
