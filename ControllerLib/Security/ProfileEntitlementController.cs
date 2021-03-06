﻿using MVCHIS.Common;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.ProfileEntitlement, Enabled = true)]
    public class ProfileEntitlementController : AbstractDBController<ProfileEntitlementModel> {
        public void InitializeDBValues() {
            foreach (var pe in Read()) { Delete(pe); }
            var es = DBControllersFactory.Entitlement().Read();
            var ps = DBControllersFactory.Profile().Read();
            foreach(ProfileModel p in ps) {
                foreach(EntitlementModel e in es) {
                    Save(new ProfileEntitlementModel() {
                        ProfileId=p.Id,
                        EntitlementId=e.Id,
                        AllowRead=true,
                        AllowUpdate=true,
                        AllowCreate=true,
                    });
                }
            }
        }

        public void ChangePermissions(int profileId,int entitlementId,bool create, bool read,bool update,bool delete) {
            var pes = Read(new ProfileEntitlementModel() {
                ProfileId = profileId,
                EntitlementId = entitlementId
            }, false, "ProfileId", "EntitlementId" );
            foreach (ProfileEntitlementModel pe in pes) {
                pe.AllowCreate = create  ; 
                pe.AllowRead   = read    ; 
                pe.AllowUpdate = update  ; 
                pe.AllowDelete = delete  ;
                Save(pe);
            }
        }
    }
}
