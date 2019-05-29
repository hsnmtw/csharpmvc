﻿using MVCHIS.Common;

namespace MVCHIS.Customers {
    [ForModel(MODELS.ClientType, Enabled = true)]
    public class ClientTypeController : AbstractDBController {
        public ClientTypeController() : base(DBEntitiesFactory.GetEntity(MODELS.ClientType)) {}
    }
}
