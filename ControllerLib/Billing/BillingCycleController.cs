using MVCHIS.Common;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.BillingCycle, Enabled = true)]
    public class BillingCycleController : AbstractDBController {
        public BillingCycleController() : base(DBEntitiesFactory.GetEntity(MODELS.BillingCycle)) {}

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
