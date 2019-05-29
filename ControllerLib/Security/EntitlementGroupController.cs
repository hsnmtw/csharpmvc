using MVCHIS.Common;

namespace MVCHIS.Security {
    [ForModel(MODELS.EntitlementGroup, Enabled = true)]
    public class EntitlementGroupController : AbstractDBController {

        public EntitlementGroupController() : base(DBEntitiesFactory.GetEntity(MODELS.EntitlementGroup)) { }

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }

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
