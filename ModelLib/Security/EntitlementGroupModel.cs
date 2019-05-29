using MVCHIS.Common;

namespace MVCHIS.Security {
    public class EntitlementGroupModel : BaseModel
    {
        public string EntitlementGroupName { get; set; }
        public bool Dynamic { get; set; }
    }
}
