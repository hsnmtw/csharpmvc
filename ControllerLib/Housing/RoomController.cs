using MVCHIS.Common;

namespace MVCHIS.Housing {
    //[ForModel(MODELS.Room, Enabled = true)]
    public class RoomController : AbstractDBController {
        public RoomController() : base(DBEntitiesFactory.GetEntity(MODELS.Room)) {}

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
