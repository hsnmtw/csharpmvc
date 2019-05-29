using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForModel(MODELS.Contact, Enabled = true)]
    public class ContactController : AbstractDBController {
        public ContactController() : base(DBEntitiesFactory.GetEntity(MODELS.Contact)) {}
    }
}
