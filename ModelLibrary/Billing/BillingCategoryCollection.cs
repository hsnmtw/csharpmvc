using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class BillingCategoryCollection : AbstractCollection {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(BillingCategoryModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,BillingCategory,BillingClass,BillingCategoryDesc".Split(',')
            , GetSource           = "BillingCategories"
            , GetUniqueKeyFields  = new string[] { "BillingCategory" }
        };
    }
}
