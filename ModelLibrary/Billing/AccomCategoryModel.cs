using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class AccomCategoryModel : BaseModel {
        public string Accom_Category { get; set; }
        public string Accom_Class    { get; set; }
        public string Food_Class     { get; set; }
    }
}
