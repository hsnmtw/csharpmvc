using MVCWinform.Common;

namespace MVCWinform.Customers {
    [ForEntityAttribute(Entities.Identification, Enabled = true)]
    public class IdentificationController : AbstractDBController {
        public IdentificationController() : base(DBEntitiesFactory.GetEntity(Entities.Identification)) {}
    }
}
