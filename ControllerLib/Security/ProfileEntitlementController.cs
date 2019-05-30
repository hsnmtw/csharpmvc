﻿using MVCHIS.Common;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.ProfileEntitlement, Enabled = true)]
    public class ProfileEntitlementController : AbstractDBController {

        public ProfileEntitlementController() : base(DBEntitiesFactory.GetEntity(MODELS.ProfileEntitlement)) { }

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }

        public void Initialize() {
            var es = DBControllersFactory.GetController(Common.MODELS.Entitlement).Read<EntitlementModel>();
            var ps = DBControllersFactory.GetController(Common.MODELS.Profile).Read<ProfileModel>();
            foreach(ProfileModel p in ps) {
                foreach(EntitlementModel e in es) {
                    Save(new ProfileEntitlementModel() {
                        ProfileName=p.ProfileName,
                        EntitlementName=e.EntitlementName,
                        AllowRead=true,
                        AllowUpdate=true,
                        AllowCreate=true,
                    });
                }
            }
        }

        public void ChangePermissions(string profile,string entitlement,bool create, bool read,bool update,bool delete) {
            var pes = Read(new ProfileEntitlementModel() {
                ProfileName = profile,
                EntitlementName = entitlement
            }, false, "ProfileName", "EntitlementName" );
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