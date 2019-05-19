using ControllerLibrary.Common;
using ModelLibrary.Common;
using ModelLibrary.Customers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Customers {
    [ForControllerAttribute(ControllersEnum.Nationality, Enabled = true)]
    public class NationalityController : AbstractController {
        public NationalityController() : base(CollectionsFactory.GetCollection(CollectionsEnum.Nationality)) {}
    }
}
