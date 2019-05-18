using ControllerLibrary.Customers;
using ControllerLibrary.Housing;
using ControllerLibrary.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Common {
    public class ControllersRegistery {
        private Dictionary<ControllersEnum, string> controllerMap = new Dictionary<ControllersEnum, string>();
        private static ControllersRegistery _instance = null;
        public static ControllersRegistery Instance {
            get {
                if (_instance == null) _instance = new ControllersRegistery();
                return _instance;
            }
        }

        private ControllersRegistery() {
            //Housing
            controllerMap[ControllersEnum.Room]     = Properties.Settings.Default.RoomController;
            controllerMap[ControllersEnum.Building] = Properties.Settings.Default.BuildingController;
            controllerMap[ControllersEnum.Compound] = Properties.Settings.Default.CompoundController;

            //Security
            controllerMap[ControllersEnum.User]                = Properties.Settings.Default.UserController;
            controllerMap[ControllersEnum.Entitlement]         = Properties.Settings.Default.EntitlementController;
            controllerMap[ControllersEnum.Profile]             = Properties.Settings.Default.ProfileController;
            controllerMap[ControllersEnum.ProfileEntitlements] = Properties.Settings.Default.ProfileEntitlementsController;

            //Customers
            controllerMap[ControllersEnum.Nationality]         = Properties.Settings.Default.NationalityController;
        }

        /// <summary>
        /// This method checks if the controllers are loadable
        /// if a controller is missing, an exception should be 
        /// thrown.
        /// </summary>
        public void Validate() {
            foreach (var type in this.controllerMap.Values) {
                Type.GetType(type);
            }
        }
    }
}
