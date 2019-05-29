using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForModel(MODELS.Identification, Enabled = true)]
    public class IdentificationController : AbstractDBController {
        public IdentificationController() : base(DBEntitiesFactory.GetEntity(MODELS.Identification)) {}
    }
}
