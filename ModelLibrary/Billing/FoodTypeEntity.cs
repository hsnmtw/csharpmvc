using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class FoodTypeEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(FoodTypeModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,FoodType".Split(',')
            , GetSource           = "BillingFoodTypes"
            , GetUniqueKeyFields  = new string[] { "FoodType" }
        };
    }
}
