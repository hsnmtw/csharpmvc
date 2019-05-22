using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Security
{
    public class ProfileEntitlementsModel : BaseModel
    {
        public string ProfileName     { get; set; }
        public string EntitlementName { get; set; }
        public bool   AllowCreate     { get; set; }
        public bool   AllowRead       { get; set; }
        public bool   AllowUpdate     { get; set; }
        public bool   AllowDelete     { get; set; }
    }
}
