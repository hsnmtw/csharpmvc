using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class AccomClassEntity : AbstractEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(AccomClassModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,AccomClass".Split(',')
            , GetSource           = "BillingAccomodationClasses"
            , GetUniqueKeyFields  = new string[] { "AccomClass" }
        };
    }
}
