using MVCHIS.Common;

namespace MVCHIS.Customers {
    public class IdentificationTypeModel : BaseModel {
        public string IdTypeCode      { get; set; }
        public string IdTypeEnglish   { get; set; }
        public string IdTypeArabic    { get; set; }
    }
}
