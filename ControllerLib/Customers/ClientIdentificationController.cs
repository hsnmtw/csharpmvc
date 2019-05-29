using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForModel(MODELS.ClientIdentification, Enabled = true)]
    public class ClientIdentificationController : AbstractDBController {
        public ClientIdentificationController() : base(DBEntitiesFactory.GetEntity(MODELS.ClientIdentification)) {}
    }
}
