using MVCHIS.Common;

namespace MVCHIS.Billing {
    public class VATModel : BaseModel {
        public string VATCode { get; set; }
        public double VATAmount { get; set; }
        public string VATDesc { get; set; }

    }
}
