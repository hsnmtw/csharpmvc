using MVCHIS.Common;
using System;

namespace MVCHIS.Security {
    public class AuditModel : BaseModel {
        public string   UserName        { get; set; }
        public DateTime EventDate       { get; set; }
        public string   EventComments   { get; set; }

        public AuditModel() {
            this.EventDate = DateTime.Now;
            this.ReadOnly = true;
        }
    }
}
