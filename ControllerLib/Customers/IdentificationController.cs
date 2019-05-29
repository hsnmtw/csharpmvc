using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForEntityAttribute(Entities.Identification, Enabled = true)]
    public class IdentificationController : AbstractDBController {
        public IdentificationController() : base(DBEntitiesFactory.GetEntity(Entities.Identification)) {}
    }
}
