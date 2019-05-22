using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class NationalityModel : BaseModel {
        public string NationalityCode   { get; set; }
        public string NationalityDesc   { get; set; }
        public string NationalityArabic { get; set; }
    }
}
