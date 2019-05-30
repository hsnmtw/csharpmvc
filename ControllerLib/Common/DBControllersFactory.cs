using MVCHIS.Billing;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Security;
using MVCHIS.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCHIS.Common {
    public static class DBControllersFactory {
        private static Dictionary<MODELS, IDBController> ControllersMap = new Dictionary<MODELS, IDBController>{
              [MODELS.BillingCategory      ] = new BillingCategoryController()
            , [MODELS.AccommClass          ] = new AccommClassController()
            , [MODELS.Audit                ] = new AuditController()
            , [MODELS.Building             ] = new BuildingController()
            , [MODELS.BuildingType         ] = new BuildingTypeController()
            , [MODELS.Client               ] = new ClientController()
            , [MODELS.ClientType           ] = new ClientTypeController()
            , [MODELS.Compound             ] = new CompoundController()
            , [MODELS.Dictionary           ] = new DictionaryController()
            , [MODELS.Entitlement          ] = new EntitlementController()
            , [MODELS.EntitlementGroup     ] = new EntitlementGroupController()
            , [MODELS.FoodClass            ] = new FoodClassController()
            , [MODELS.FoodType             ] = new FoodTypeController()
            , [MODELS.Identification       ] = new IdentificationController()
            , [MODELS.IdentificationType   ] = new IdentificationTypeController()
            , [MODELS.Country              ] = new CountryController()
            , [MODELS.Profile              ] = new ProfileController()
            , [MODELS.ProfileEntitlement   ] = new ProfileEntitlementsController()
            , [MODELS.Project              ] = new ProjectController()
            , [MODELS.Room                 ] = new RoomController()
            , [MODELS.User                 ] = new UserController()
            , [MODELS.Entity               ] = new EntityController()
            , [MODELS.Contact              ] = new ContactController()
            , [MODELS.ClientContact        ] = new ClientContactController()
            , [MODELS.ClientIdentification ] = new ClientIdentificationController()
        };

        public static void Initialize(){
            

           // ControllersMap = new Dictionary<MODELS, IDBController>() {
           //};

           //foreach(MODELS num in typeof(MODELS).GetEnumValues()) {
           //     foreach(var type in ControllersRegistery.Instance[num]) {
           //         ForModelAttribute forca = (ForModelAttribute)type.GetCustomAttributes(true).OfType<ForModelAttribute>().First();
           //         if (forca.Enabled) {
           //             DBControllersFactory.ControllersMap[num] = (IDBController)Activator.CreateInstance(type);
           //         }
           //     }
           // }
        }

        public static IDBController GetController(string typeName) {
            return (IDBController)Activator.CreateInstance(Type.GetType(typeName));
        }

        public static Dictionary<MODELS, IDBController> GetControllersMap() {
            return ControllersMap;
		}

        public static IDBController GetController(Common.MODELS ce){
            //if (ControllersMap == null) Initialize();
            return ControllersMap[ce];
        }

        public static void SetController(MODELS ce,IDBController bc) {
            if (ControllersMap == null) Initialize();
            ControllersMap[ce] = bc;
        }
    }
}
