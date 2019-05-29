using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForModel(MODELS.IdentificationType, Enabled = true)]
    public class IdentificationTypeController : AbstractDBController {
        public IdentificationTypeController() : base(DBEntitiesFactory.GetEntity(MODELS.IdentificationType)) {}
    }
}
