using ControllerLibrary.Common;
using ModelLibrary.Common;
using ModelLibrary.Customers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Billing {
    [ForControllerAttribute(Entities.FoodType, Enabled = true)]
    public class FoodTypeController : AbstractController {
        public FoodTypeController() : base(EntitiesFactory.GetEntity(Entities.FoodType)) {}
    }
}
