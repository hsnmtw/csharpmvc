using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System.Data;

namespace ModelLibrary.Common
{
    public abstract class BaseModel
    {       
        public String Id           { get; set; }
        public String Created_By   { get; set; }
        public String Updated_By   { get; set; }
        public DateTime Created_On { get; set; }
        public DateTime Updated_On { get; set; }       
    }
}