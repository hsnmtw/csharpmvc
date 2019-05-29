using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForEntityAttribute(Entities.ClientIdentification, Enabled = true)]
    public class ClientIdentificationController : AbstractDBController {
        public ClientIdentificationController() : base(DBEntitiesFactory.GetEntity(Entities.ClientIdentification)) {}
    }
}
