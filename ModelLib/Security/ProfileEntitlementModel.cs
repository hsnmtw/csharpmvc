using MVCHIS.Common;

namespace MVCHIS.Security {
    public class ProfileEntitlementModel : BaseModel
    {
        public int    ProfileId       { get; set; }
        public int    EntitlementId   { get; set; }
        public bool   AllowCreate     { get; set; }
        public bool   AllowRead       { get; set; }
        public bool   AllowUpdate     { get; set; }
        public bool   AllowDelete     { get; set; }
    }
}
