using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Billing {
    public class BillingCycleModel : BaseModel {
        public int BillingCycleYear   { get; set; }
        public int BillingCycleMonth { get; set; }
    }
}
