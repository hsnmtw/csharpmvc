using MVCHIS.Common;
using MVCHIS.Tools;
using System;
using System.Linq;

namespace MVCHIS.Security {
    //[ForModel(MODELS.Entitlement, Enabled = true)]
    public class EntitlementController : AbstractDBController<EntitlementModel> {

        public void InitializeDBValues() {
            foreach (var e in Read()) { Delete(e); }
            var egs = new EntitlementGroupController().Read().ToDictionary(x => x.EntitlementGroupName, x => x.Id);
            var ets = new EntityController().Read().ToDictionary(x => x.EntityName, x => x.Id);

            foreach (MODELS t in Enum.GetValues(typeof(MODELS))) {
                var e = DBControllersFactory.GetController(t);
                Console.WriteLine($"-------------{e}");
                if ("".Equals(e)) continue;
                Save(new EntitlementModel() {
                    EntitlementName = t.ToString(),
                    EntitlementGroupId = egs[e.GetType().FullName.Split('.')[1]],
                    EntityId = ets[t.ToString()]
                });
            }
        }
    }
}
