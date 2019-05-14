using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Security;
using ControllerLibrary.Common;

namespace ControllerLibrary.Security
{
    public class ProfileController : AbstractController<ProfileModel>
    {
        public override string TABLE_NAME { get { return "Security_Profiles"; } }
    }
}
