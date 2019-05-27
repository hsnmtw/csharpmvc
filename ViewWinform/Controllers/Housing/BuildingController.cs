using MVCWinform.Common;


namespace MVCWinform.Housing {
    [ForEntityAttribute(Entities.Building, Enabled = true)]
    public class BuildingController : AbstractDBController {
        public BuildingController() : base(DBEntitiesFactory.GetEntity(Entities.Building)) { }
    }
}
