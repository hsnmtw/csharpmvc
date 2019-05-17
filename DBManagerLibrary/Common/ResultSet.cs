using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManagerLibrary.Common {
    public class ResultSet {
        public string ResponseMessage { get; set; }
        public bool Status { get; set; } // true = ok, false = error
    }
}
