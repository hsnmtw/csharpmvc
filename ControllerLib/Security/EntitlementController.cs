using MVCHIS.Common;
using System.Linq;

namespace MVCHIS.Security {
    //[ForModel(MODELS.Entitlement, Enabled = true)]
    public class EntitlementController : AbstractDBController {

        public EntitlementController() : base(DBEntitiesFactory.GetEntity(MODELS.Entitlement)) { }

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
