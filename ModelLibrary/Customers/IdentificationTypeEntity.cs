using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class IdentificationTypeEntity : AbstractEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(IdentificationTypeModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,IdentificationType".Split(',')
            , GetSource           = "CustomersIdentificationTypes"
            , GetUniqueKeyFields  = new string[] { "IdentificationType" }
        };
    }
}
