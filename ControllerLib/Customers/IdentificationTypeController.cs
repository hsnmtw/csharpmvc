using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForEntityAttribute(Entities.IdentificationType, Enabled = true)]
    public class IdentificationTypeController : AbstractDBController {
        public IdentificationTypeController() : base(DBEntitiesFactory.GetEntity(Entities.IdentificationType)) {}
    }
}
