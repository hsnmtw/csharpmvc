﻿using MVCHIS.Common;


namespace MVCHIS.Housing {
    [ForModel(MODELS.Building, Enabled = true)]
    public class BuildingController : AbstractDBController {
        public BuildingController() : base(DBEntitiesFactory.GetEntity(MODELS.Building)) { }
    }
}
