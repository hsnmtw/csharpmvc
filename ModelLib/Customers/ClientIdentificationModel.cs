using MVCHIS.Common;
using System;

namespace MVCHIS.Customers {
    public class ClientIdentificationModel : BaseModel {
        public int ClientId         { get; set; }
        public int IdentificationId { get; set; }
    }
}
