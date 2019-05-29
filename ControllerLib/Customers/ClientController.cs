using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForEntityAttribute(Entities.Client, Enabled = true)]
    public class ClientController : AbstractDBController {
        public ClientController() : base(DBEntitiesFactory.GetEntity(Entities.Client)) {}
    }
}
