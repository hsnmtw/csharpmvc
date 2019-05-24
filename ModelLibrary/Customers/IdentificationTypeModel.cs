using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class IdentificationTypeModel : BaseModel {
        public string IdTypeCode      { get; set; }
        public string IdTypeEnglish   { get; set; }
        public string IdTypeArabic    { get; set; }
    }
}
