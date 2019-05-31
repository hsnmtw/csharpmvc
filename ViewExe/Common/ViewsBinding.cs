using MVCHIS.Billing;
using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Common {
    public class ViewsBinding {
    }
    public class AuditView : BaseView<AuditModel, AuditController> { }
    public class FoodTypeView : BaseView<FoodTypeModel, FoodTypeController> { }
    public class RoomView : BaseView<RoomModel, RoomController> { }
    public class AccommClassView : BaseView<AccommClassModel, AccommClassController> { }
    public class BillingCategoryView : BaseView<BillingCategoryModel, BillingCategoryController> { }
    public class CompoundView : BaseView<CompoundModel, CompoundController> { }
    public class ClientView : BaseView<ClientModel, ClientController> { }
    public class ClientTypeView : BaseView<ClientTypeModel, ClientTypeController> { }
    public class ContactView : BaseView<ContactModel, ContactController> { }
    public class IdentificationTypeView : BaseView<IdentificationTypeModel, IdentificationTypeController> { }
    public class ProjectView : BaseView<ProjectModel, ProjectController> { }
    public class BuildingView : BaseView<BuildingModel, BuildingController> { }
    public class BillingCycleView : BaseView<BillingCycleModel, BillingCycleController> { }
    public class ProfileEntitlementsView : BaseView<ProfileEntitlementModel, ProfileEntitlementController> { }
    public class FoodClassView : BaseView<FoodClassModel, FoodClassController> { }
    public class CountryView : BaseView<CountryModel, CountryController> { }
    public class IdentificationView : BaseView<IdentificationModel, IdentificationController> { }
    public class BuildingTypeView : BaseView<BuildingTypeModel, BuildingTypeController> { }

}
