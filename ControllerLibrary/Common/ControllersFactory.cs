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
        private static Dictionary<ControllersEnum, BaseController> ControllersMap = null;

        public static void InitControllersMap(){
		   ControllersMap = new Dictionary<ControllersEnum, BaseController>() {
              [ControllersEnum.Nationality        ] = new NationalityController        ()
            , [ControllersEnum.Compound           ] = new CompoundController           ()
            , [ControllersEnum.User               ] = new UserController               ()
            , [ControllersEnum.Entitlement        ] = new EntitlementController        ()
            , [ControllersEnum.ProfileEntitlements] = new ProfileEntitlementsController()
            , [ControllersEnum.Profile            ] = new ProfileController            ()
            , [ControllersEnum.Building           ] = new BuildingController           ()
            , [ControllersEnum.Room               ] = new RoomController               ()
            , [ControllersEnum.Audit              ] = new AuditController              ()
           };
        }

        public static Dictionary<ControllersEnum, BaseController> GetControllersMap() {
            return ControllersMap;
		}

        public static BaseController GetController(ControllersEnum ce){
            if (ControllersMap == null) InitControllersMap();
            return ControllersMap[ce];
        }

        public static void SetController(ControllersEnum ce,BaseController bc) {
            if (ControllersMap == null) InitControllersMap();
            ControllersMap[ce] = bc;
        }
    }
}
