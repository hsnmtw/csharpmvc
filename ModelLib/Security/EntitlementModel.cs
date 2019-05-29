using MVCHIS.Common;

namespace MVCHIS.Security {
    public class EntitlementModel : BaseModel
    {
        public string EntitlementName { get; set; }
        public string EntitlementGroupName { get; set; }

        
        public string EntityName { get; set; }
    }
}
