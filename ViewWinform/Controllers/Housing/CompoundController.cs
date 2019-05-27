using MVCWinform.Common;

namespace MVCWinform.Housing {
    [ForEntityAttribute(Entities.Compound, Enabled = true)]
    public class CompoundController : AbstractDBController {
        public CompoundController() : base(DBEntitiesFactory.GetEntity(Entities.Compound)) { }
    }
}
