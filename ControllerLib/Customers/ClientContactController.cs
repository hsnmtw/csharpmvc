using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForModel(MODELS.ClientContact, Enabled = true)]
    public class ClientContactController : AbstractDBController {
        public ClientContactController() : base(DBEntitiesFactory.GetEntity(MODELS.ClientContact)) {}

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
