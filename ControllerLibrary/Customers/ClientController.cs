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
    [ForControllerAttribute(Entities.Client, Enabled = true)]
    public class ClientController : AbstractController {
        public ClientController() : base(CollectionsFactory.GetCollection(Entities.Client)) {}
    }
}
