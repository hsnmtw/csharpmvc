using MVCHIS.Common;

namespace MVCHIS.Billing {
    public class BillingCategoryModel : BaseModel {
        public string BillingCategoryCode { get; set; }
        public string BillingCategoryDesc { get; set; }
        public int    AccommClassId       { get; set; }
        public int    FoodClassId         { get; set; }
        public int    FoodTypeId          { get; set; }
        public bool   ReservationOnly     { get; set; }
    }
}
