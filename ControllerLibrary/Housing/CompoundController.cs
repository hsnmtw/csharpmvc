﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Housing;
using ControllerLibrary.Common;
using ModelLibrary.Common;

namespace ControllerLibrary.Housing
{
    public class CompoundController : AbstractController {
        public CompoundController() : base(new CompoundCollection()) {

        }
    }
}
