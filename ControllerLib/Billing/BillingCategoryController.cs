using MVCHIS.Common;

namespace MVCHIS.Billing {
    [ForEntityAttribute(Entities.BillingCategory, Enabled = true)]
    public class BillingCategoryController : AbstractDBController {
        public BillingCategoryController() : base(DBEntitiesFactory.GetEntity(Entities.BillingCategory)) {}
    }
}
