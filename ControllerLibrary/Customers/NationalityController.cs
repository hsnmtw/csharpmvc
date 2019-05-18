using ControllerLibrary.Common;
using ModelLibrary.Customers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Customers {
    public class NationalityController : AbstractController {
        public NationalityController() : base(new NationalityCollection()) {

        }
    }
}
