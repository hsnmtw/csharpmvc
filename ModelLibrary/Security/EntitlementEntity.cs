using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Security
{
    public class EntitlementEntity : AbstractEntity{

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(EntitlementModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = new string[] { "Id","EntitlementName" }
            , GetSource = "SecurityEntitlements"
            , GetUniqueKeyFields = new string[] { "EntitlementName" }
        };

        public override DBModificationResult Delete(object model) {
            var em = (EntitlementModel)model;
            int id = em.Id;
            var pec = EntitiesFactory.GetEntity(Entities.ProfileEntitlement);
            var pc = EntitiesFactory.GetEntity(Entities.Profile);
            if (id != 0) {
                foreach (ProfileModel p in pc.Read()) {
                    pec.Delete(new ProfileEntitlementsModel() {
                        EntitlementName = em.EntitlementName,
                        ProfileName = p.ProfileName
                    }, new string[] { "EntitlementName", "ProfileName" });
                }
            }
            return base.Delete(model);
        }

        public override DBModificationResult Save(object model) {
            var em = (EntitlementModel)model;
            int id = em.Id;
            var pec = EntitiesFactory.GetEntity(Entities.ProfileEntitlement);
            var pc = EntitiesFactory.GetEntity(Entities.Profile);
            if (id != 0) {
                string entitlement = ((EntitlementModel)Read(new EntitlementModel() { Id=id },new string[] { "Id" }).First()).EntitlementName;
                foreach(ProfileModel p in pc.Read()) {
                    pec.Delete(new ProfileEntitlementsModel() {
                        ProfileName = p.ProfileName,
                        EntitlementName = entitlement
                    },new string[] { "EntitlementName", "ProfileName" });
                }
            }
            foreach (ProfileModel p in pc.Read()) {
                pec.Save(new ProfileEntitlementsModel() {
                    CreatedOn = DateTime.Now,
                    CreatedBy = em.CreatedBy,
                    ProfileName = p.ProfileName,
                    EntitlementName = em.EntitlementName
                });
            }
            return base.Save(model);
        }
    }
}
