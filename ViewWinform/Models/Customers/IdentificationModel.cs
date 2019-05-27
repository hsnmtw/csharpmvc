using MVCWinform.Common;
using System;

namespace MVCWinform.Customers {
    public class IdentificationModel : BaseModel {
        public string    IdNumber       { get; set; }
        public string    IdType         { get; set; }
        public string    IssuingCountry { get; set; }
        public DateTime? IssueDate      { get; set; }
        public DateTime? ExpiryDate     { get; set; }
        public bool      IsActive       { get; set; }

    }
}
