using MVCHIS.Common;

namespace MVCHIS.Billing {
    [ForModel(MODELS.FoodClass, Enabled = true)]
    public class FoodClassController : AbstractDBController {
        public FoodClassController() : base(DBEntitiesFactory.GetEntity(MODELS.FoodClass)) {}
    }
}
