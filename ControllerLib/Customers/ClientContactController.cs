using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForEntityAttribute(Entities.ClientContact, Enabled = true)]
    public class ClientContactController : AbstractDBController {
        public ClientContactController() : base(DBEntitiesFactory.GetEntity(Entities.ClientContact)) {}
    }
}
