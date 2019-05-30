using MVCHIS.Common;

namespace MVCHIS.Housing {
    //[ForModel(MODELS.Compound, Enabled = true)]
    public class CompoundController : AbstractDBController {
        public CompoundController() : base(DBEntitiesFactory.GetEntity(MODELS.Compound)) { }

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
