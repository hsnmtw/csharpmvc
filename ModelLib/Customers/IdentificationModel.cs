﻿using MVCHIS.Common;
using System;

namespace MVCHIS.Customers {
    public class IdentificationModel : BaseModel {
        public string    IdNumber       { get; set; }
        public int       IdTypeId       { get; set; }
        public int       CountryId      { get; set; }
        public DateTime? IssueDate      { get; set; }
        public DateTime? ExpiryDate     { get; set; }
        public bool      IsActive       { get; set; }

    }
}
