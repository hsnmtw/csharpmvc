using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.BillingCategory)]
    public class BillingCategoryEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(BillingCategoryModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id","BillingCategoryCode","BillingCategoryDesc","AccommClassId", "FoodClassId", "FoodTypeId" }
            , UniqueKeyFields  = new List<string> { "BillingCategoryCode" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
                ["FoodTypeId"   ] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.FoodType).MetaData.Source, "Id"),
                ["FoodClassId"  ] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.FoodClass).MetaData.Source,"Id"),
                ["AccommClassId"] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.AccommClass).MetaData.Source, "Id")
            }
            , GetSizes = new Dictionary<string, int> {
                 ["CreatedBy"           ] = 50
                ,["UpdatedBy"           ] = 50
                ,["BillingCategoryCode" ] = 150
                ,["BillingCategoryDesc" ] = 250
            }
            , Source           = "BillingCategory"
        };
    }
}