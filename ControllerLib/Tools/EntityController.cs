using MVCHIS.Common;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.Entity, Enabled = true)]
    public class EntityController : AbstractDBController {
        public EntityController() : base(DBEntitiesFactory.GetEntity(MODELS.Entity)) { }
        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
        public void Initialize() {
            string[][] data = {
                new string[]{"BillingCategory","BillingCategory"},
                new string[]{"BillingCycle","BillingCycle"},
                new string[]{"AccommClass","BillingAccomodationClass"},
                new string[]{"Audit","SecurityAudit"},
                new string[]{"Building","HousingBuilding"},
                new string[]{"BuildingType","HousingBuildingType"},
                new string[]{"Client","CustomersClient"},
                new string[]{"ClientType","CustomersClientType"},
                new string[]{"Compound","HousingCompound"},
                new string[]{"Dictionary","ToolsDictionary"},
                new string[]{"Entitlement","SecurityEntitlement"},
                new string[]{"EntitlementGroup","SecurityEntitlementGroup"},
                new string[]{"FoodClass","BillingFoodClass"},
                new string[]{"FoodType","BillingFoodType"},
                new string[]{"Identification","CustomersIdentification"},
                new string[]{"IdentificationType","IdentificationType"},
                new string[]{"Country","CustomersCountry"},
                new string[]{"Profile","SecurityProfile"},
                new string[]{"ProfileEntitlement","SecurityProfileEntitlement"},
                new string[]{"Project","CustomersProject"},
                new string[]{"Room","HousingRoom"},
                new string[]{"User","SecurityUser"},
                new string[]{"Entity","ToolsEntity"},
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
