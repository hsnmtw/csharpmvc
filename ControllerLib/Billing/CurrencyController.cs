using MVCHIS.Common;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.Currency, Enabled = true)]
    public class CurrencyController : AbstractDBController {
        public CurrencyController() : base(DBEntitiesFactory.GetEntity(MODELS.Currency)) {}

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
