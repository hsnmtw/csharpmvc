using MVCHIS.Common;
using System;
using System.Linq;

namespace MVCHIS.Security {
    //[ForModel(MODELS.EntitlementGroup, Enabled = true)]
    public class EntitlementGroupController : AbstractDBController<EntitlementGroupModel> {

        public void InitializeDBValues() {

            foreach (var e in Read()) { Delete(e); }

            foreach (MODELS t in Enum.GetValues(typeof(MODELS))) {
                var e = DBEntitiesFactory.GetEntity(t);
                Console.WriteLine(":::------------------ " + t.ToString() + ": >>> " + e.GetType().FullName.Split('.')[1]);
                try {
                    Save(new EntitlementGroupModel() {
                        EntitlementGroupName = e.GetType().FullName.Split('.')[1],
                        Dynamic = true
                    });

                } catch { }
            }

        }
    }
}
