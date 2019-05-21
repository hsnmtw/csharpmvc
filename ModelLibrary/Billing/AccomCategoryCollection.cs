using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class AccomCategoryCollection : AbstractCollection {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(AccomCategoryModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,Accom_Category,Accom_Class".Split(',')
            , GetSource           = "Billing_Accomodation_Categories"
            , GetUniqueKeyFields  = new string[] { "Accom_Category" }
        };
    }
}
