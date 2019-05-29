using MVCHIS.Common;

namespace MVCHIS.Billing {
    public class BillingCategoryModel : BaseModel {
        public string BillingCategory      { get; set; }
        public string BillingCategoryDesc  { get; set; }
        public string AccommClass           { get; set; }
        public string FoodClass            { get; set; }
        public string FoodType             { get; set; }
        public bool   ReservationOnly      { get; set; }
    }
}
