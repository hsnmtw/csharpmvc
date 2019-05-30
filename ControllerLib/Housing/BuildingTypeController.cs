using MVCHIS.Common;


namespace MVCHIS.Housing {
    //[ForModel(MODELS.BuildingType, Enabled = true)]
    public class BuildingTypeController : AbstractDBController {
        public BuildingTypeController() : base(DBEntitiesFactory.GetEntity(MODELS.BuildingType)) { }

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
