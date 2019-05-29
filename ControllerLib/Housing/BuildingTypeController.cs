using MVCHIS.Common;


namespace MVCHIS.Housing {
    [ForEntityAttribute(Entities.BuildingType, Enabled = true)]
    public class BuildingTypeController : AbstractDBController {
        public BuildingTypeController() : base(DBEntitiesFactory.GetEntity(Entities.BuildingType)) { }
    }
}
