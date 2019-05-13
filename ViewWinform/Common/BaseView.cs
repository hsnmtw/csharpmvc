﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ViewWinform
{
    interface BaseView<T> where T: BaseModel
    {
        T model { get; set; }
    }
}
