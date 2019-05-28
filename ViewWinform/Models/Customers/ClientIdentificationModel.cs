using MVCWinform.Common;
using System;

namespace MVCWinform.Customers {
    public class ClientIdentificationModel : BaseModel {
        public int ClientId         { get; set; }
        public int IdentificationId { get; set; }
    }
}
