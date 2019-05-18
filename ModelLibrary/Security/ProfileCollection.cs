using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelLibrary.Common;

namespace ModelLibrary.Security
{
    public class ProfileCollection : AbstractCollection {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(ProfileModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = new string[] { "Id", "Profile_Name" }
            , GetSource = "Security_Profiles"
            , GetUniqueKeyFields = new string[] { "Profile_Name" }
        };
    }
}
