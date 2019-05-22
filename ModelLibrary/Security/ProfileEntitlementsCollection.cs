using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Security
{
    public class ProfileEntitlementsCollection : AbstractCollection {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(ProfileEntitlementsModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = new string[] { "Id", "ProfileName", "EntitlementName" }
            , GetSource = "SecurityProfileEntitlements"
            , GetUniqueKeyFields = new string[] {  }
        };
    }
}
