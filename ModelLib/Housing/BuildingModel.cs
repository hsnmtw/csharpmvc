using MVCHIS.Common;

namespace MVCHIS.Housing {
    public class BuildingModel : BaseModel {
        public string BuildingName { get; set; }
        public int BuildingTypeId { get; set; }
        public int CompoundId { get; set; }
    }
}
