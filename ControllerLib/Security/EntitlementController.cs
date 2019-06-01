using MVCHIS.Common;
using MVCHIS.Tools;
using System;
using System.Linq;

namespace MVCHIS.Security {
    //[ForModel(MODELS.Entitlement, Enabled = true)]
    public class EntitlementController : AbstractDBController {

        public EntitlementController() : base(DBEntitiesFactory.GetEntity(MODELS.Entitlement)) { }

        public void InitializeDBValues() {



            foreach (var e in Read<EntitlementModel>()) { Delete(e); }
            var egs = new EntitlementGroupController().Read<EntitlementGroupModel>().ToDictionary(x=>x.EntitlementGroupName,x=>x.Id);
            var ets = new EntityController().Read<EntityModel>().ToDictionary(x => x.EntityName, x => x.Id);

            foreach (MODELS t in Enum.GetValues(typeof(MODELS))) {
                var e = DBEntitiesFactory.GetEntity(t);
                Console.WriteLine($"-------------{e}");
                if ("".Equals(e)) continue;
                Save(new EntitlementModel() {
                    EntitlementName = t.ToString(),
                    EntitlementGroupId = egs[e.GetType().FullName.Split('.')[1]],
                    EntityId = ets[t.ToString()]
                });
            }

        }

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
