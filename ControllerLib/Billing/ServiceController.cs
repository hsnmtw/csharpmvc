using MVCHIS.Common;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.Service, Enabled = true)]
    public class ServiceController : AbstractDBController {
        public ServiceController() : base(DBEntitiesFactory.GetEntity(MODELS.Service)) {}

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
