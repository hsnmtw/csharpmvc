using MVCWinform.Common;

namespace MVCWinform.Customers {
    [ForEntityAttribute(Entities.Client, Enabled = true)]
    public class ClientController : AbstractDBController {
        public ClientController() : base(DBEntitiesFactory.GetEntity(Entities.Client)) {}
    }
}
