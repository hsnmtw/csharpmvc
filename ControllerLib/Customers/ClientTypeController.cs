using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForEntityAttribute(Entities.ClientType, Enabled = true)]
    public class ClientTypeController : AbstractDBController {
        public ClientTypeController() : base(DBEntitiesFactory.GetEntity(Entities.ClientType)) {}
    }
}
