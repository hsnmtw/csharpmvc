using MVCHIS.Common;

namespace MVCHIS.Customers {
    public class ContactModel : BaseModel {
        public string MobileNumber   { get; set; }
        public string Email          { get; set; }
        public string FaxNumber      { get; set; }
        public string PhoneNumber    { get; set; }
        public string FullName       { get; set; }
    }
}
