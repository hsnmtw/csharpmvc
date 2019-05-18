using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class NationalityModel : BaseModel {
        public string Nationality_Code   { get; set; }
        public string Nationality_Desc   { get; set; }
        public string Nationality_Arabic { get; set; }
    }
}
