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
    public class ProfileEntitlementsController : AbstractController { 
    
        public ProfileEntitlementsController() : base(new ProfileEntitlementsCollection()) {

        }

        public DataTable GetEntitlementsByProfile(string profile)
        {
            var model = new ProfileEntitlementsModel() { Profile_Name = profile };
            return GetTable(model, new string[] { "Profile_Name" });
        }

        public void DeleteEntitlementForProfile(string profile)
        {
            var model = new ProfileEntitlementsModel() { Profile_Name = profile };
            var list = Read(model, new string[] { "Profile_Name" });
            foreach(var ent in list) {
                Delete(ent);
            }
        }

        public void UpdateEntitlementForProfile(string profile,List<string> entitlements)
        {
            foreach(var entitlement in entitlements)
            {
                var model = new ProfileEntitlementsModel() {
                    Profile_Name = profile,
                    Entitlement_Name = entitlement
                };
                Save(model);
            }
        }
    }
}
