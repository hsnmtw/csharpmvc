using MVCHIS.Common;

namespace MVCHIS.Housing {
    [ForModel(MODELS.Room, Enabled = true)]
    public class RoomController : AbstractDBController {
        public RoomController() : base(DBEntitiesFactory.GetEntity(MODELS.Room)) { }
    }
}
