using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class FoodClassCollection : AbstractCollection {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(FoodClassModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,Food_Class".Split(',')
            , GetSource           = "Billing_Food_Classes"
            , GetUniqueKeyFields  = new string[] { "Food_Class" }
        };
    }
}
