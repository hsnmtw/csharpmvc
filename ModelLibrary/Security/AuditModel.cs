using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Security {
    public class AuditModel : BaseModel {
        public string   User_Name        { get; set; }
        public DateTime Event_Date       { get; set; }
        public string   Event_Comments   { get; set; }
    }
}
