namespace MVCHIS.Common {
    [ForModel(MODELS.Entity, Enabled = true)]
    public class EntityController : AbstractDBController {
        public EntityController() : base(DBEntitiesFactory.GetEntity(MODELS.Entity)) { }
        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
        public void Initialize() {
            string[][] data = {
                new string[]{"BillingCategory","BillingCategories"},
                new string[]{"AccommClass","BillingAccomodationClasses"},
                new string[]{"Audit","SecurityAudit"},
                new string[]{"Building","HousingBuilding"},
                new string[]{"BuildingType","HousingBuildingTypes"},
                new string[]{"Client","CustomersClient"},
                new string[]{"ClientType","CustomersClientTypes"},
                new string[]{"Compound","HousingCompounds"},
                new string[]{"Dictionary","ToolsDictionary"},
                new string[]{"Entitlement","SecurityEntitlements"},
                new string[]{"EntitlementGroup","SecurityEntitlementGroups"},
                new string[]{"FoodClass","BillingFoodClasses"},
                new string[]{"FoodType","BillingFoodTypes"},
                new string[]{"Identification","CustomersIdentification"},
                new string[]{"IdentificationType","IdentificationType"},
                new string[]{"Country","CustomersCountry"},
                new string[]{"Profile","SecurityProfiles"},
                new string[]{"ProfileEntitlement","SecurityProfileEntitlements"},
                new string[]{"Project","CustomersProject"},
                new string[]{"Room","HousingRoom"},
                new string[]{"User","SecurityUsers"},
                new string[]{"Entity","CommonEntites"},
                new string[]{"Contact","CustomersContact"}
            };
            foreach(var entity in data) {
                Save(new EntityModel() {
                    EntityName = entity[0],
                    EntityDesc = entity[1]
                });
            }
        }
    }
}
