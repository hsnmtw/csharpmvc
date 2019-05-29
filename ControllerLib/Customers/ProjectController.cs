using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForModel(MODELS.Project, Enabled = true)]
    public class ProjectController : AbstractDBController {
        public ProjectController() : base(DBEntitiesFactory.GetEntity(MODELS.Project)) {}
    }
}
