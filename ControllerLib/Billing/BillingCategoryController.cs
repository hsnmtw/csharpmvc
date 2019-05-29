using MVCHIS.Common;

namespace MVCHIS.Billing {
    [ForModel(MODELS.BillingCategory, Enabled = true)]
    public class BillingCategoryController : AbstractDBController {
        public BillingCategoryController() : base(DBEntitiesFactory.GetEntity(MODELS.BillingCategory)) {}
    }
}
