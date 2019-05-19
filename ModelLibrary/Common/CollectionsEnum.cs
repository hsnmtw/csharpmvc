﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Common {
    [Serializable]
    [Flags]
    public enum CollectionsEnum {
         Audit                 = 0
        ,Building              = 1
        ,Compound              = 2
        ,Entitlement           = 3
        ,Nationality           = 4
        ,Profile               = 5
        ,ProfileEntitlements   = 6
        ,Room                  = 7
        ,User                  = 8
    }
}
