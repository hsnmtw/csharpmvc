using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Housing;
using ControllerLibrary.Common;
using DBManagerLibrary.Common;

namespace ControllerLibrary.Housing
{
    public class CompoundController : AbstractController<CompoundModel>
    {
        public override string TABLE_NAME { get { return "Housing_Compounds"; } }
    }
}
