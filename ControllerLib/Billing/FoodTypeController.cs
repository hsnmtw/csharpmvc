using MVCHIS.Common;

namespace MVCHIS.Billing {
    [ForEntityAttribute(Entities.FoodType, Enabled = true)]
    public class FoodTypeController : AbstractDBController {
        public FoodTypeController() : base(DBEntitiesFactory.GetEntity(Entities.FoodType)) {}
    }
}
