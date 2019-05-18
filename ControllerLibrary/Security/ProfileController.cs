using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Security;
using ControllerLibrary.Common;

namespace ControllerLibrary.Security
{
    public class ProfileController : AbstractDBController<ProfileModel>
    {
        //public override string Source => "Security_Profiles";

        public override ProfileModel Save(ProfileModel model) {
            var pec = new ProfileEntitlementsController();
            return base.Save(model);
        }

        public override void Delete(ProfileModel model) {
            new ProfileEntitlementsController().clearEntitlementForProfile(model.Profile_Name);
            base.Delete(model);
        }
    }
}
