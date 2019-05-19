using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Security;
using ControllerLibrary.Common;
using ModelLibrary.Common;

namespace ControllerLibrary.Security
{
    [ForControllerAttribute(ControllersEnum.Profile, Enabled = true)]
    public class ProfileController : AbstractController{
    

        public ProfileController() : base(CollectionsFactory.GetCollection(CollectionsEnum.Profile)) {

        }

        public override void Delete(object model) {
            new ProfileEntitlementsController().DeleteEntitlementForProfile(((ProfileModel)model).Profile_Name);
            base.Delete(model);
        }
    }
}
