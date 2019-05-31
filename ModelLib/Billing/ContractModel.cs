using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Billing{
    public class ContractModel : BaseModel {
        public string    ContractCode       { get; set; }
        public DateTime  StartDate          { get; set; }
        public DateTime? EndDate            { get; set; }
        public bool      IsActive           { get; set; }
        public string    Conditions         { get;set;}
        public int       ClientId           { get; set; }
        //public int       BillingCategoryId  { get; set; }
    }
}
