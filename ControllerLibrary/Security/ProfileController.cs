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
        public override string Source => "Security_Profiles";

        public override void save(ProfileModel model) {
            var pec = new Profile_EntitlementsController();
            base.save(model);
        }

        public override void delete(ProfileModel model) {
            new Profile_EntitlementsController().clearEntitlementForProfile(model.Profile_Name);
            base.delete(model);
        }
    }
}
