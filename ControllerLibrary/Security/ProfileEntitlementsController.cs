using ModelLibrary.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;
using ControllerLibrary.Common;

namespace ControllerLibrary.Security
{
    [ForControllerAttribute(Entities.ProfileEntitlement, Enabled = true)]
    public class ProfileEntitlementsController : AbstractController {

        public ProfileEntitlementsController() : base(CollectionsFactory.GetCollection(Entities.ProfileEntitlement)) { }

        public DataTable GetEntitlementsByProfile(string profile)
        {
            var model = new ProfileEntitlementsModel() { ProfileName = profile };
            return GetTable(model, new string[] { "ProfileName" });
        }

        public void DeleteEntitlementForProfile(string profile)
        {
            var model = new ProfileEntitlementsModel() { ProfileName = profile };
            var list = Read(model, new string[] { "ProfileName" });
            foreach(var ent in list) {
                Delete(ent);
            }
        }

        public void UpdateEntitlementForProfile(string profile,List<string> entitlements)
        {
            foreach(var entitlement in entitlements)
            {
                var model = new ProfileEntitlementsModel() {
                    ProfileName = profile,
                    EntitlementName = entitlement
                };
                Save(model);
            }
        }
    }
}
