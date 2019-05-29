using MVCHIS.Common;

namespace MVCHIS.Security {
    public class ProfileEntitlementsModel : BaseModel
    {
        public string ProfileName     { get; set; }
        public string EntitlementName { get; set; }
        public bool   AllowCreate     { get; set; }
        public bool   AllowRead       { get; set; }
        public bool   AllowUpdate     { get; set; }
        public bool   AllowDelete     { get; set; }
    }
}
