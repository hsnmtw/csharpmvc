using MVCWinform.Common;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MVCWinform.Security {
    [ForEntityAttribute(Entities.ProfileEntitlement, Enabled = true)]
    public class ProfileEntitlementsController : AbstractDBController {

        public ProfileEntitlementsController() : base(DBEntitiesFactory.GetEntity(Entities.ProfileEntitlement)) { }

        public void Initialize() {
            var es = DBControllersFactory.GetController(Entities.Entitlement).Read<EntitlementModel>();
            var ps = DBControllersFactory.GetController(Entities.Profile).Read<ProfileModel>();
            foreach(ProfileModel p in ps) {
                foreach(EntitlementModel e in es) {
                    Save(new ProfileEntitlementsModel() {
                        ProfileName=p.ProfileName,
                        EntitlementName=e.EntitlementName,
                        AllowRead=true
                    });
                }
            }
        }

        public void ChangePermissions(string profile,string entitlement,bool create, bool read,bool update,bool delete) {
            var pes = Read(new ProfileEntitlementsModel() {
                ProfileName = profile,
                EntitlementName = entitlement
            }, false, "ProfileName", "EntitlementName" );
            foreach (ProfileEntitlementsModel pe in pes) {
                pe.AllowCreate = create  ; 
                pe.AllowRead   = read    ; 
                pe.AllowUpdate = update  ; 
                pe.AllowDelete = delete  ;
                Save(pe);
            }
        }
    }
}
