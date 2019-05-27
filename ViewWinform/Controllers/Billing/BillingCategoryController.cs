using MVCWinform.Common;

namespace MVCWinform.Billing {
    [ForEntityAttribute(Entities.BillingCategory, Enabled = true)]
    public class BillingCategoryController : AbstractDBController {
        public BillingCategoryController() : base(DBEntitiesFactory.GetEntity(Entities.BillingCategory)) {}
    }
}
