using MVCHIS.Common;

namespace MVCHIS.Security {
    public class EntitlementModel : BaseModel
    {
        public string EntitlementName    { get; set; }
        public int    EntitlementGroupId { get; set; }        
        public int    EntityId           { get; set; }
    }
}
