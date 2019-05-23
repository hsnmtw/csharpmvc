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
    [ForControllerAttribute(Entities.Country, Enabled = true)]
    public class CountryController : AbstractController {
        public CountryController() : base(EntitiesFactory.GetEntity(Entities.Country)) {}
    }
}
