using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Billing {
    public class ServiceModel : BaseModel {
        public int    BillingCategoryId   { get; set; }
        public int    ContractId          { get; set; }
        public double Price               { get; set; }
        public int      CurrencyId        { get; set; }
        public DateTime EffectiveFromDate { get; set; }
        public bool Expired               { get; set; }
        public int VATId                  { get; set; }
    }

}
