using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class AccomClassCollection : AbstractCollection {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(AccomClassModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,Accom_Class".Split(',')
            , GetSource           = "Billing_Accomodation_Classes"
            , GetUniqueKeyFields  = new string[] { "Accom_Class" }
        };
    }
}
