using MVCWinform.Common;

namespace MVCWinform.Security {
    [ForEntityAttribute(Entities.EntitlementGroup, Enabled = true)]
    public class EntitlementGroupController : AbstractDBController {

        public EntitlementGroupController() : base(DBEntitiesFactory.GetEntity(Entities.EntitlementGroup)) { }

        public void Initialize() {
            var egsdynamic = new string[] {
                "Security",
                "Operations",
                "Billing",
                "Housing",
                "Customers",
                "Reports",
                "Tools",
            };

            var egsnondynamic = new string[] {
                "File",
                "Window",
                "Developer",
                "Help",
            };
            foreach (var eg in egsdynamic) Save(new EntitlementGroupModel() { EntitlementGroupName = eg, Dynamic = true });
            foreach (var eg in egsnondynamic) Save(new EntitlementGroupModel() { EntitlementGroupName = eg, Dynamic = false });
        }
    }
}
