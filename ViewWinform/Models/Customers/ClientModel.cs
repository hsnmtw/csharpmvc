using MVCWinform.Common;

namespace MVCWinform.Customers {
    public class ClientModel : BaseModel {
        public string ClientType     { get; set; }
        public string ShortName      { get; set; }
        public string LongName       { get; set; }
        public string Email          { get; set; }
        public string FaxNumber      { get; set; }
        public string BillingAddress { get; set; }
        public string PhoneNumber    { get; set; }
        public string ContactPerson  { get; set; }
    }
}
