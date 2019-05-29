using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    [ForModel(MODELS.Project, Enabled = true)]
    public class ProjectController : AbstractDBController {
        public ProjectController() : base(DBEntitiesFactory.GetEntity(MODELS.Project)) {}

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }


    }
}
