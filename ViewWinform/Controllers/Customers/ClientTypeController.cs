using MVCWinform.Common;

namespace MVCWinform.Customers {
    [ForEntityAttribute(Entities.ClientType, Enabled = true)]
    public class ClientTypeController : AbstractDBController {
        public ClientTypeController() : base(DBEntitiesFactory.GetEntity(Entities.ClientType)) {}
    }
}
