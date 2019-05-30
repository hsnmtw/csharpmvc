using MVCHIS.Common;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.FoodType, Enabled = true)]
    public class FoodTypeController : AbstractDBController {
        public FoodTypeController() : base(DBEntitiesFactory.GetEntity(MODELS.FoodType)) {}

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
