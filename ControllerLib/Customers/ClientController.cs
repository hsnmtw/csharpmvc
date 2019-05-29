using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForModel(MODELS.Client, Enabled = true)]
    public class ClientController : AbstractDBController {
        public ClientController() : base(DBEntitiesFactory.GetEntity(MODELS.Client)) {}
    }
}
