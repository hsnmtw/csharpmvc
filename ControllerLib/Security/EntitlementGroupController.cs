using MVCHIS.Common;
using System;
using System.Linq;

namespace MVCHIS.Security {
    //[ForModel(MODELS.EntitlementGroup, Enabled = true)]
    public class EntitlementGroupController : AbstractDBController<EntitlementGroupModel> {

        public void InitializeDBValues() {

            foreach (var e in Read()) { Delete(e); }
            System.Collections.Generic.HashSet<string> set = new System.Collections.Generic.HashSet<string>();
            foreach (MODELS t in Enum.GetValues(typeof(MODELS))) {
                var e = DBControllersFactory.GetController(t);
                var val = e.GetType().FullName.Split('.')[1];
                if (set.Contains(val)) continue;
                set.Add(val);
                Console.WriteLine(":::------------------ " + t.ToString() + ": >>> " + e.GetType().FullName.Split('.')[1]);
                try {
                    Save(new EntitlementGroupModel() {
                        EntitlementGroupName = val,
                        Dynamic = true
                    });

                } catch { }
            }

        }
    }
}
