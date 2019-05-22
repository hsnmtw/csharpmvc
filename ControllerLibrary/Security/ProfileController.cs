﻿using System;
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
    [ForControllerAttribute(Entities.Profile, Enabled = true)]
    public class ProfileController : AbstractController{


        public ProfileController() : base(CollectionsFactory.GetCollection(Entities.Profile)) { }

        public override DBModificationResult Delete(object model) {
            var controller = (ProfileEntitlementsController)ControllersFactory.GetController(Entities.ProfileEntitlement);
            controller.DeleteEntitlementForProfile(((ProfileModel)model).ProfileName);
            return base.Delete(model);
        }
    }
}
