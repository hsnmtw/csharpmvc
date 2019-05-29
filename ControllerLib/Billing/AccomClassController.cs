using MVCHIS.Common;

namespace MVCHIS.Billing {
    [ForEntityAttribute(Entities.AccommClass, Enabled = true)]
    public class AccommClassController : AbstractDBController {
        public AccommClassController() : base(DBEntitiesFactory.GetEntity(Entities.AccommClass)) {}
    }
}
