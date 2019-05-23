using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class FoodClassEntity : AbstractEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(FoodClassModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,FoodClass".Split(',')
            , GetSource           = "BillingFoodClasses"
            , GetUniqueKeyFields  = new string[] { "FoodClass" }
        };
    }
}
