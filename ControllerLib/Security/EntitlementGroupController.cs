using MVCHIS.Common;
using System;
using System.Linq;

namespace MVCHIS.Security {
    //[ForModel(MODELS.EntitlementGroup, Enabled = true)]
    public class EntitlementGroupController : AbstractDBController {

        public EntitlementGroupController() : base(DBEntitiesFactory.GetEntity(MODELS.EntitlementGroup)) { }

        public void InitializeDBValues() {

            foreach (var e in Read<EntitlementGroupModel>()) { Delete(e); }

            foreach (MODELS t in Enum.GetValues(typeof(MODELS))) {
                var e = DBEntitiesFactory.GetEntity(t);
                Console.WriteLine(":::------------------ " + t.ToString() + ": >>> " + e.GetType().FullName.Split('.')[1]);
                try {
                    Save(new EntitlementGroupModel() {
                        EntitlementGroupName = e.GetType().FullName.Split('.')[1],
                        Dynamic=true
                    });
                    
                } catch { }
            }

        }

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
}
