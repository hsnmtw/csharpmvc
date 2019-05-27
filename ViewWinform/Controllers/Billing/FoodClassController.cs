using MVCWinform.Common;

namespace MVCWinform.Billing {
    [ForEntityAttribute(Entities.FoodClass, Enabled = true)]
    public class FoodClassController : AbstractDBController {
        public FoodClassController() : base(DBEntitiesFactory.GetEntity(Entities.FoodClass)) {}
    }
}
