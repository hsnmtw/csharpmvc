using MVCHIS.Common;
using System;

namespace MVCHIS.Billing {
    public class ReservationModel : BaseModel {
        public string ReservationCode   { get; set; }
        public DateTime FromDate        { get; set; }
        public DateTime ToDate          { get; set; }
        public int      RoomId          { get; set; }
        public int      ClientId        { get; set; }
        public int      CurrencyId      { get; set; }
        public bool     Confirmed       { get; set; }
        public double   Rate            { get; set; }
    }
}
