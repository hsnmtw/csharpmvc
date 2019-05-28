using MVCWinform.Common;
using System;

namespace MVCWinform.Customers {
    public class ClientModel : BaseModel {
        public int ClientTypeId      { get; set; }
        public string ShortName      { get; set; }
        public string LongName       { get; set; }
        public string NameArabic     { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool IsActive         { get; set; }
        public string BillingAddress { get; set; }
        public string PhoneNumber    { get; set; }
        public string FaxNumber      { get; set; }
        public string Website        { get; set; }
        public string Nationality    { get; set; }
    }
}
