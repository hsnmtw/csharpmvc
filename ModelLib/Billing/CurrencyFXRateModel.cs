using MVCHIS.Common;
using System;

namespace MVCHIS.Billing {
    public class CurrencyFXRateModel : BaseModel {
        public int       FromCurrencyId        { get; set; }
        public int       ToCurrencyId          { get; set; }
        public DateTime  FXDate                { get; set; }
        public double    FXRate                { get; set; }
    }
}
