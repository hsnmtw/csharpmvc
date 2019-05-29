using MVCHIS.Common;

namespace MVCHIS.Billing {
    [ForModel(MODELS.BillingCategory, Enabled = true)]
    public class BillingCategoryController : AbstractDBController {
        public BillingCategoryController() : base(DBEntitiesFactory.GetEntity(MODELS.BillingCategory)) {}

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
