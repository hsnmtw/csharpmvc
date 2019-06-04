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
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
                ["FoodTypeId"   ] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<FoodTypeModel>().MetaData.Source, "Id"),
                ["FoodClassId"  ] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<FoodClassModel>().MetaData.Source,"Id"),
                ["AccommClassId"] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<AccommClassModel>().MetaData.Source, "Id")
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