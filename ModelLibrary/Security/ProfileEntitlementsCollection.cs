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

        public Statement GetEntitlementsStatement(ProfileEntitlementsModel model) {
            return new Statement($"EntitlementsForProfile:{model.ProfileName}") {
                Sql = $@"SELECT * FROM [{MetaData.GetSource}] WHERE [ProfileName]=@ProfileName",
                Parameters = ParametersFactory.CreateParameters(model,new string[] { "ProfileName" })
            };
        }
    }
}
