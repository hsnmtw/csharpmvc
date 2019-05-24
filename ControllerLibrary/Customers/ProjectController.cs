﻿using ControllerLibrary.Common;
using ModelLibrary.Common;
using ModelLibrary.Customers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Customers {
    [ForControllerAttribute(Entities.Project, Enabled = true)]
    public class ProjectController : AbstractDBController {
        public ProjectController() : base(DBEntitiesFactory.GetEntity(Entities.Project)) {}
    }
}