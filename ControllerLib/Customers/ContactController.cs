using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForEntityAttribute(Entities.Contact, Enabled = true)]
    public class ContactController : AbstractDBController {
        public ContactController() : base(DBEntitiesFactory.GetEntity(Entities.Contact)) {}
    }
}
