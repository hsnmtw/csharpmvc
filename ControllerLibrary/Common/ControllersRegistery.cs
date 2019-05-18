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
        private Dictionary<DBControllersEnum, string> controllerMap = new Dictionary<DBControllersEnum, string>();
        private static ControllersRegistery _instance = null;
        public static ControllersRegistery Instance {
            get {
                if (_instance == null) _instance = new ControllersRegistery();
                return _instance;
            }
        }

        private ControllersRegistery() {
            //Housing
            controllerMap[DBControllersEnum.Room] = Properties.Settings.Default.RoomController;
            controllerMap[DBControllersEnum.Building] = Properties.Settings.Default.BuildingController;
            controllerMap[DBControllersEnum.Compound] = Properties.Settings.Default.CompoundController;

            //Security
            controllerMap[DBControllersEnum.User] = Properties.Settings.Default.UserController;
            controllerMap[DBControllersEnum.Entitlement] = Properties.Settings.Default.EntitlementController;
            controllerMap[DBControllersEnum.Profile] = Properties.Settings.Default.ProfileController;
            controllerMap[DBControllersEnum.ProfileEntitlements] = Properties.Settings.Default.ProfileEntitlementsController;

            //Customers
            controllerMap[DBControllersEnum.Nationality] = Properties.Settings.Default.NationalityController;
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
