using MVCHIS.Billing;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Security;
using MVCHIS.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MVCHIS.Common {
    public static class DBControllersFactory {
        private static Dictionary<MODELS, object> ControllersMap = new Dictionary<MODELS, object> { };
        private static bool ControllersTypesIsInitialized = false;
        private static Dictionary<string, Type> ControllersTypes = new Dictionary<string, Type>();

        private static object GetController(MODELS model) {
            InitializeContrllersTypesMap();
            if (ControllersMap.ContainsKey(model)) return ControllersMap[model];
            return ControllersMap[model] = Activator.CreateInstance(ControllersTypes[$"{model}Controller"]);
        }

        private static void InitializeContrllersTypesMap() {
            if (!ControllersTypesIsInitialized) {
                ControllersTypesIsInitialized = true;
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies()) {
                    foreach (var type in asm.GetTypes()) {
                        if (type.Name.EndsWith("Controller")) {
                            ControllersTypes[type.Name] = type;
                        }
                    }
                }
            }
        }

        public static C GetController<C>() where C:IController {
            var name = typeof(C).Name;
            if (Enum.TryParse(name.Substring(0,name.Length-"Controller".Length),out MODELS model)) {
                return (C)GetController(model);
            }
            throw new Exception($"Controller: {typeof(C)} cannot be found in the list of MODELS enum");
        }

        public static AccommClassController          GetAccommClassController          ()=> (AccommClassController)         GetController(MODELS.AccommClass         );
        public static AuditController                GetAuditController                ()=> (AuditController)               GetController(MODELS.Audit               );
        public static BillingCategoryController      GetBillingCategoryController      ()=> (BillingCategoryController)     GetController(MODELS.BillingCategory     );
        public static BillingCycleController         GetBillingCycleController         ()=> (BillingCycleController)        GetController(MODELS.BillingCycle        );
        public static BuildingController             GetBuildingController             ()=> (BuildingController)            GetController(MODELS.Building            );
        public static BuildingTypeController         GetBuildingTypeController         ()=> (BuildingTypeController)        GetController(MODELS.BuildingType        );
        public static CityController                 GetCityController                 ()=> (CityController)                GetController(MODELS.City                );
        public static ClientController               GetClientController               ()=> (ClientController)              GetController(MODELS.Client              );
        public static ClientContactController        GetClientContactController        ()=> (ClientContactController)       GetController(MODELS.ClientContact       );
        public static ClientIdentificationController GetClientIdentificationController ()=> (ClientIdentificationController)GetController(MODELS.ClientIdentification); 
        public static ClientTypeController           GetClientTypeController           ()=> (ClientTypeController)          GetController(MODELS.ClientType          );
        public static CompoundController             GetCompoundController             ()=> (CompoundController)            GetController(MODELS.Compound            );
        public static ContactController              GetContactController              ()=> (ContactController)             GetController(MODELS.Contact             );
        public static ContractController             GetContractController             ()=> (ContractController)            GetController(MODELS.Contract            );
        public static CountryController              GetCountryController              ()=> (CountryController)             GetController(MODELS.Country             );
        public static CurrencyController             GetCurrencyController             ()=> (CurrencyController)            GetController(MODELS.Currency            );
        public static CurrencyFXRateController       GetCurrencyFXRateController       ()=> (CurrencyFXRateController)      GetController(MODELS.CurrencyFXRate      );
        public static DateConversionController       GetDateConversionController       ()=> (DateConversionController)      GetController(MODELS.DateConversion      );
        public static DictionaryController           GetDictionaryController           ()=> (DictionaryController)          GetController(MODELS.Dictionary          );
        public static EntitlementController          GetEntitlementController          ()=> (EntitlementController)         GetController(MODELS.Entitlement         );
        public static EntitlementGroupController     GetEntitlementGroupController     ()=> (EntitlementGroupController)    GetController(MODELS.EntitlementGroup    );
        public static EntityController               GetEntityController               ()=> (EntityController)              GetController(MODELS.Entity              );
        public static FoodClassController            GetFoodClassController            ()=> (FoodClassController)           GetController(MODELS.FoodClass           );
        public static FoodTypeController             GetFoodTypeController             ()=> (FoodTypeController)            GetController(MODELS.FoodType            );
        public static IdentificationController       GetIdentificationController       ()=> (IdentificationController)      GetController(MODELS.Identification      );
        public static IdentificationTypeController   GetIdentificationTypeController   ()=> (IdentificationTypeController)  GetController(MODELS.IdentificationType  );
        public static ProfileController              GetProfileController              ()=> (ProfileController)             GetController(MODELS.Profile             );
        public static ProfileEntitlementController   GetProfileEntitlementController   ()=> (ProfileEntitlementController)  GetController(MODELS.ProfileEntitlement  );
        public static ProjectController              GetProjectController              ()=> (ProjectController)             GetController(MODELS.Project             );
        public static ReservationController          GetReservationController          ()=> (ReservationController)         GetController(MODELS.Reservation         );
        public static RoomController                 GetRoomController                 ()=> (RoomController)                GetController(MODELS.Room                );
        public static ServiceController              GetServiceController              ()=> (ServiceController)             GetController(MODELS.Service             );
        public static UserController                 GetUserController                 ()=> (UserController)                GetController(MODELS.User                );
        public static VATController                  GetVATController                  ()=> (VATController)                 GetController(MODELS.VAT                 );


    }
}
