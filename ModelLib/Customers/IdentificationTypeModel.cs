using MVCHIS.Common;

namespace MVCHIS.Customers {
    public class IdentificationTypeModel : BaseModel {
        public string IdentificationTypeCode      { get; set; }
        public string IdentificationTypeEnglish   { get; set; }
        public string IdentificationTypeArabic    { get; set; }
    }
}
