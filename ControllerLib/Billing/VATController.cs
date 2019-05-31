using MVCHIS.Common;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.VAT, Enabled = true)]
    public class VATController : AbstractDBController {
        public VATController() : base(DBEntitiesFactory.GetEntity(MODELS.VAT)) {}

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
