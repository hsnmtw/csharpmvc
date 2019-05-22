using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Security {
    public class AuditModel : BaseModel {
        public string   UserName        { get; set; }
        public DateTime EventDate       { get; set; }
        public string   EventComments   { get; set; }
    }
}
