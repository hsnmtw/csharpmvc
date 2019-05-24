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
    public class ProfileEntitlementsController : AbstractDBController {

        public ProfileEntitlementsController() : base(DBEntitiesFactory.GetEntity(Entities.ProfileEntitlement)) { }

        public void ChangePermissions(string profile,string entitlement,bool create, bool read,bool update,bool delete) {
            var pes = Read(new ProfileEntitlementsModel() {
                ProfileName = profile,
                EntitlementName = entitlement
            }, new string[] { "ProfileName", "EntitlementName" });
            foreach (ProfileEntitlementsModel pe in pes) {
                pe.AllowCreate = create;
                pe.AllowRead   = read;
                pe.AllowUpdate = update;
                pe.AllowDelete = delete;
                Save(pe);
            }
        }
    }
}
