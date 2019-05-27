﻿using MVCWinform.Common;

namespace MVCWinform.Customers {
    [ForEntityAttribute(Entities.Project, Enabled = true)]
    public class ProjectController : AbstractDBController {
        public ProjectController() : base(DBEntitiesFactory.GetEntity(Entities.Project)) {}
    }
}
