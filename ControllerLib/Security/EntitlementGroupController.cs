using MVCHIS.Common;

namespace MVCHIS.Security {
    //[ForModel(MODELS.EntitlementGroup, Enabled = true)]
    public class EntitlementGroupController : AbstractDBController {

        public EntitlementGroupController() : base(DBEntitiesFactory.GetEntity(MODELS.EntitlementGroup)) { }

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
