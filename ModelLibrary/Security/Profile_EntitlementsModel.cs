using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Security
{
    public class Profile_EntitlementsModel : BaseModel
    {
        public String Profile_Name     { get; set; }
        public String Entitlement_Name { get; set; }
    }
}
