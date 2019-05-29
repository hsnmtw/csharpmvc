using MVCHIS.Common;

namespace MVCHIS.Billing {
    [ForModel(MODELS.AccommClass, Enabled = true)]
    public class AccommClassController : AbstractDBController {
        public AccommClassController() : base(DBEntitiesFactory.GetEntity(MODELS.AccommClass)) {}
    }
}
