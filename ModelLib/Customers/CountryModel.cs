using MVCHIS.Common;

namespace MVCHIS.Customers {
    public class CountryModel : BaseModel {
        public string CountryCode    { get; set; }
        public string CountryEnglish { get; set; }
        public string CountryArabic  { get; set; }
    }
}
