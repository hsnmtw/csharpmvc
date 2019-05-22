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
            , GetRequiredFields = "Id,UserName,UserPassword,CreatedBy,CreatedOn".Split(',')
            , GetSource = "SecurityUsers"
            , GetUniqueKeyFields = new string[] { "UserName" }
        };
    }
}
