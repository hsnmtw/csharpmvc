using MVCWinform.Common;

namespace MVCWinform.Customers {
    [ForEntityAttribute(Entities.Contact, Enabled = true)]
    public class ContactController : AbstractDBController {
        public ContactController() : base(DBEntitiesFactory.GetEntity(Entities.Contact)) {}
    }
}
