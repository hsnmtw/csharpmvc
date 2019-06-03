using MVCHIS.Common;
using System;

namespace MVCHIS.Tools {
    public class DateConversionModel : BaseModel
    {
        public DateTime GregorianDate  { get; set; }
        public int      GregorianYear  { get; set; }
//        public int      GregorianMonth { get; set; }
//        public int      GregorianDay   { get; set; }
        public int      HijriYear      { get; set; }
        public int      HijriMonth     { get; set; }
        public int      HijriDay       { get; set; }
    }
}
