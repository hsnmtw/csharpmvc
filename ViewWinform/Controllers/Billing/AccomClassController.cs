using MVCWinform.Common;

namespace MVCWinform.Billing {
    [ForEntityAttribute(Entities.AccomClass, Enabled = true)]
    public class AccomClassController : AbstractDBController {
        public AccomClassController() : base(DBEntitiesFactory.GetEntity(Entities.AccomClass)) {}
    }
}
