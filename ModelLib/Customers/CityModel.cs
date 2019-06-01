using MVCHIS.Common;

namespace MVCHIS.Customers {
    public class CityModel : BaseModel {
        public int    CountryId   { get; set; }
        public string CityEnglish { get; set; }
        public string CityArabic  { get; set; }
    }
}
