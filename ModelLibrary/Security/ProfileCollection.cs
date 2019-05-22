﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelLibrary.Common;

namespace ModelLibrary.Security
{
    public class ProfileCollection : AbstractCollection {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(ProfileModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = new string[] { "Id", "ProfileName" }
            , GetSource = "SecurityProfiles"
            , GetUniqueKeyFields = new string[] { "ProfileName" }
        };

        public override DBModificationResult Save(object model) {
            DBModificationResult result = base.Save(model);
            var profile = ((ProfileModel)model);
            var pec = CollectionsFactory.GetCollection(Entities.ProfileEntitlement);
            var ec = CollectionsFactory.GetCollection(Entities.Entitlement);
            var es = ec.Read().OfType<EntitlementModel>();
            foreach (var e in es) {
                pec.Save(new ProfileEntitlementsModel() {
                    ProfileName = profile.ProfileName,
                    EntitlementName = e.EntitlementName,
                    CreatedBy = profile.CreatedBy,
                    CreatedOn = DateTime.Now,
                    AllowRead = true
                });
            }
            return result;
        }

        public override DBModificationResult Delete(object model) {
            var profilename = ((ProfileModel)model).ProfileName;
            var pec = CollectionsFactory.GetCollection(Entities.ProfileEntitlement);
            var pes = pec.Read(new ProfileEntitlementsModel() { ProfileName = profilename },new string[] { "ProfileName" });
            foreach(var pe in pes) {
                pec.Delete(pe);
            }
            return base.Delete(model);
        }
    }
}
