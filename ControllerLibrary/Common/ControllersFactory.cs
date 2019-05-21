using ControllerLibrary.Customers;
using ControllerLibrary.Housing;
using ControllerLibrary.Security;
using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Common {
    public static class ControllersFactory {
        private static Dictionary<Entities, BaseController> ControllersMap = null;

        public static void InitControllersMap(){
		   ControllersMap = new Dictionary<Entities, BaseController>() {
            //  [ControllersEnum.Nationality        ] = new NationalityController        ()
            //, [ControllersEnum.Compound           ] = new CompoundController           ()
            //, [ControllersEnum.User               ] = new UserController               ()
            //, [ControllersEnum.Entitlement        ] = new EntitlementController        ()
            //, [ControllersEnum.ProfileEntitlements] = new ProfileEntitlementsController()
            //, [ControllersEnum.Profile            ] = new ProfileController            ()
            //, [ControllersEnum.Building           ] = new BuildingController           ()
            //, [ControllersEnum.Room               ] = new RoomController               ()
            //, [ControllersEnum.Audit              ] = new AuditController              ()
           };

           foreach(Entities num in typeof(Entities).GetEnumValues()) {
                foreach(var type in ControllersRegistery.Instance[num]) {
                    ForControllerAttribute forca = (ForControllerAttribute)type.GetCustomAttributes(true).First();
                    if (forca.Enabled) {
                        ControllersFactory.ControllersMap[num] = (BaseController)Activator.CreateInstance(type);
                    }
                }
            }
        }

        public static BaseController GetController(string typeName) {
            return (BaseController)Activator.CreateInstance(Type.GetType(typeName));
        }

        public static Dictionary<Entities, BaseController> GetControllersMap() {
            return ControllersMap;
		}

        public static BaseController GetController(Entities ce){
            if (ControllersMap == null) InitControllersMap();
            return ControllersMap[ce];
        }

        public static void SetController(Entities ce,BaseController bc) {
            if (ControllersMap == null) InitControllersMap();
            ControllersMap[ce] = bc;
        }
    }
}
