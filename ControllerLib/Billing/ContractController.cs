using MVCHIS.Common;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.Contract, Enabled = true)]
    public class ContractController : AbstractDBController {
        public ContractController() : base(DBEntitiesFactory.GetEntity(MODELS.Contract)) {}

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
