using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class IdentificationTypeEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(IdentificationTypeModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,IdTypeCode".Split(',')
            , GetSource           = "CustomersIdentificationType"
            , GetUniqueKeyFields  = new string[] { "IdTypeCode" }
        };
    }
}
