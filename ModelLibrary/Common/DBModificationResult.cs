using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Common {
    public struct DBModificationResult {
        public object Result { get; set; }
        public int Status { get; set; }
    }
}
