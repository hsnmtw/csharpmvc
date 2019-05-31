using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Billing {
    public class CurrencyModel : BaseModel {
        public string CurrencyCode    { get; set; }
        public string CurrencyEnglish { get; set; }
        public string CurrencyArabic  { get; set; }
        public string CurrencySymbol  { get; set; }
    }
}
