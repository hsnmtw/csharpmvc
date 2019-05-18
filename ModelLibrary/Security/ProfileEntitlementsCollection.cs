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
            , GetRequiredFields = new string[] { "Id", "Profile_Name", "Entitlement_Name" }
            , GetSource = "Security_Profile_Entitlements"
            , GetUniqueKeyFields = new string[] {  }
        };

        public Statement GetEntitlementsStatement(ProfileEntitlementsModel model) {
            return new Statement($"EntitlementsForProfile:{model.Profile_Name}") {
                Sql = $@"SELECT * FROM [{MetaData.GetSource}] WHERE [Profile_Name]=@Profile_Name",
                Parameters = ParametersFactory.CreateParameters(model,new string[] { "Profile_Name" })
            };
        }
    }
}
