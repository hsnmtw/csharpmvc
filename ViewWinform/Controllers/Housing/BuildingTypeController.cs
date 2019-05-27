using MVCWinform.Common;


namespace MVCWinform.Housing {
    [ForEntityAttribute(Entities.BuildingType, Enabled = true)]
    public class BuildingTypeController : AbstractDBController {
        public BuildingTypeController() : base(DBEntitiesFactory.GetEntity(Entities.BuildingType)) { }
    }
}
