using MVCHIS.Common;

namespace MVCHIS.Security {
    [ForEntityAttribute(Entities.Profile, Enabled = true)]
    public class ProfileController : AbstractDBController{
        public ProfileController() : base(DBEntitiesFactory.GetEntity(Entities.Profile)) { }

        public void Initialize() {
            foreach(var profile in new string[] { "Admin","Users" })Save(new ProfileModel() {
                ProfileName=profile,
                ProfileDesc=$"{profile} Profile",
                ReadOnly=true
            });
        }
    }
}
