using MVCHIS.Common;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Country, Enabled = true)]
    public class CountryController : AbstractDBController {
        public CountryController() : base(DBEntitiesFactory.GetEntity(MODELS.Country)) {}

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }

        public void Initialize() {
            string[][] data = {
                 new string[]{"BGD","Bangladish","بنغلاديش"}
                ,new string[]{"EGY","Egypt","جمهورية مصر العربية"}
                ,new string[]{"FIL","Phillipens","الفلبين"}
                ,new string[]{"IND","India","الهند"}
                ,new string[]{"INS","Indonesia","اندونيسيا"}
                ,new string[]{"JOR","Jordan","الاردن"}
                ,new string[]{"KORN","Koria North","كوريا الشمالية"}
                ,new string[]{"LBN","Lebanon","لبنان"}
                ,new string[]{"NJR","Nijeria","نيجيريا"}
                ,new string[]{"PAK","Pakistan","باكستان"}
                ,new string[]{"SAF","South Africa","جنوب افريقيا"}
                ,new string[]{"SOM","Somal","الصومال"}
                ,new string[]{"SPN","Spain","اسبانيا"}
                ,new string[]{"SUD","Sudan North","السودان"}
                ,new string[]{"SYR","Syria","سوريا"}
                ,new string[]{"TNS","Tonisia","تونس"}
                ,new string[]{"TUR","Turkey","تركيا"}
                ,new string[]{"UAE","United Arab Emirates","الإمارات العربية المتحدة"}
                ,new string[]{"UK","United Kingdom","المملكة المتحدة"}
                ,new string[]{"USA","United States of America","امريكا"}
                ,new string[]{"YEM","Yemen","اليمن"}
                ,new string[]{"SAU","Saudi Arabia","السعودية"}
                ,new string[]{"BAH","Bahrain","البحرين"}
            };
            foreach(var country in data) {
                Save(new CountryModel() {
                    CountryCode=country[0],
                    CountryEnglish=country[1],
                    CountryArabic=country[2]
                });
            }
        }
    }
}
