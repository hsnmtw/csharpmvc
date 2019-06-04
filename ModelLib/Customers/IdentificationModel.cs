using MVCHIS.Common;
using System;

namespace MVCHIS.Customers {
    public class IdentificationModel : BaseModel {
        public string    IdentificationNumber       { get; set; }
        public int       IdentificationTypeId       { get; set; }
        public int       CityId         { get; set; }
        public DateTime? IssueDate      { get; set; }
        public DateTime? ExpiryDate     { get; set; }
        public bool      IsActive       { get; set; }

    }
}
