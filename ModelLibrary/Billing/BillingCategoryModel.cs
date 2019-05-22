using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class BillingCategoryModel : BaseModel {
        public string BillingCategory      { get; set; }
        public string BillingCategoryDesc  { get; set; }
        public string AccomClass           { get; set; }
        public string FoodClass            { get; set; }
        public bool   ReservationOnly      { get; set; }
    }
}
