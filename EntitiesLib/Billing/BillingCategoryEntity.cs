using System;
using System.Linq;
using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.BillingCategory)]
    public class BillingCategoryEntity : AbstractDBEntity<BillingCategoryModel> {
        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                  "BillingCategoryCode","BillingCategoryDesc","AccommClassId",
                                                  "FoodClassId","FoodTypeId","ReservationOnly"}
            , RequiredFields   = new HashSet<string> { "Id","BillingCategoryCode","BillingCategoryDesc","AccommClassId", "FoodClassId", "FoodTypeId" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "BillingCategoryCode" } }
            , ForeignKeys      = new Dictionary<string, Tuple<MODELS, string>> {
                ["FoodTypeId"   ] = new Tuple<MODELS, string>(MODELS.FoodType, "Id"),
                ["FoodClassId"  ] = new Tuple<MODELS, string>(MODELS.FoodClass,"Id"),
                ["AccommClassId"] = new Tuple<MODELS, string>(MODELS.AccommClass, "Id")
            }
            , Sizes = new Dictionary<string, int> {
                 ["CreatedBy"           ] = 10
                ,["UpdatedBy"           ] = 10
                ,["BillingCategoryCode" ] = 150
                ,["BillingCategoryDesc" ] = 250
            }
            , Source           = ENTITIES.BillingCategory
        };
    }
}