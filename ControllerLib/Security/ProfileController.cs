using MVCHIS.Common;

namespace MVCHIS.Security {
    [ForModel(MODELS.Profile, Enabled = true)]
    public class ProfileController : AbstractDBController{
        public ProfileController() : base(DBEntitiesFactory.GetEntity(MODELS.Profile)) { }
        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }

        public void Initialize() {
            foreach(var profile in new string[] { "Admin","Users" })Save(new ProfileModel() {
                ProfileName=profile,
                ProfileDesc=$"{profile} Profile",
                ReadOnly=true
            });
        }
    }
}
