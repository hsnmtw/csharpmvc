using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class CountryModel : BaseModel {
        public string CountryCode    { get; set; }
        public string CountryEnglish { get; set; }
        public string CountryArabic  { get; set; }
    }
}
