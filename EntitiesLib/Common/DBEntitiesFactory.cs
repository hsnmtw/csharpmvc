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
    public static class DBEntitiesFactory {
        private static Dictionary<MODELS, object> EntityMap = new Dictionary<MODELS, object> { };
        private static bool EntityTypesIsInitialized = false;
        private static Dictionary<string, Type> EntityTypes = new Dictionary<string, Type>();

        private static object GetEntity(MODELS model) {
            InitializeContrllersTypesMap();
            if (EntityMap.ContainsKey(model)) return EntityMap[model];
            return EntityMap[model] = Activator.CreateInstance(EntityTypes[$"{model}Entity"]);
        }

        private static void InitializeContrllersTypesMap() {
            if (!EntityTypesIsInitialized) {
                EntityTypesIsInitialized = true;
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies()) {
                    foreach (var type in asm.GetTypes()) {
                        if (type.Name.EndsWith("Entity")) {
                            EntityTypes[type.Name] = type;
                        }
                    }
                }
            }
        }

        public static IDBEntity<M> GetEntityOfModel<M>() where M:BaseModel {
            var name = typeof(M).Name;
            if (Enum.TryParse(name.Substring(0, name.Length - "Model".Length), out MODELS model)) {
                return (IDBEntity<M>)GetEntity(model);
            }
            throw new Exception($"Entity: {typeof(M)} cannot be found in the list of MODELS enum");
        }


        public static E GetEntity<E>() where E:IEntity {
            var name = typeof(E).Name;
            if (Enum.TryParse(name.Substring(0,name.Length-"Entity".Length),out MODELS model)) {
                return (E)GetEntity(model);
            }
            throw new Exception($"Entity: {typeof(E)} cannot be found in the list of MODELS enum");
        }

        public static AccommClassEntity          GetAccommClassEntity          ()=> (AccommClassEntity)         GetEntity(MODELS.AccommClass         );
        public static AuditEntity                GetAuditEntity                ()=> (AuditEntity)               GetEntity(MODELS.Audit               );
        public static BillingCategoryEntity      GetBillingCategoryEntity      ()=> (BillingCategoryEntity)     GetEntity(MODELS.BillingCategory     );
        public static BillingCycleEntity         GetBillingCycleEntity         ()=> (BillingCycleEntity)        GetEntity(MODELS.BillingCycle        );
        public static BuildingEntity             GetBuildingEntity             ()=> (BuildingEntity)            GetEntity(MODELS.Building            );
        public static BuildingTypeEntity         GetBuildingTypeEntity         ()=> (BuildingTypeEntity)        GetEntity(MODELS.BuildingType        );
        public static CityEntity                 GetCityEntity                 ()=> (CityEntity)                GetEntity(MODELS.City                );
        public static ClientEntity               GetClientEntity               ()=> (ClientEntity)              GetEntity(MODELS.Client              );
        public static ClientContactEntity        GetClientContactEntity        ()=> (ClientContactEntity)       GetEntity(MODELS.ClientContact       );
        public static ClientIdentificationEntity GetClientIdentificationEntity ()=> (ClientIdentificationEntity)GetEntity(MODELS.ClientIdentification); 
        public static ClientTypeEntity           GetClientTypeEntity           ()=> (ClientTypeEntity)          GetEntity(MODELS.ClientType          );
        public static CompoundEntity             GetCompoundEntity             ()=> (CompoundEntity)            GetEntity(MODELS.Compound            );
        public static ContactEntity              GetContactEntity              ()=> (ContactEntity)             GetEntity(MODELS.Contact             );
        public static ContractEntity             GetContractEntity             ()=> (ContractEntity)            GetEntity(MODELS.Contract            );
        public static CountryEntity              GetCountryEntity              ()=> (CountryEntity)             GetEntity(MODELS.Country             );
        public static CurrencyEntity             GetCurrencyEntity             ()=> (CurrencyEntity)            GetEntity(MODELS.Currency            );
        public static CurrencyFXRateEntity       GetCurrencyFXRateEntity       ()=> (CurrencyFXRateEntity)      GetEntity(MODELS.CurrencyFXRate      );
        public static DateConversionEntity       GetDateConversionEntity       ()=> (DateConversionEntity)      GetEntity(MODELS.DateConversion      );
        public static DictionaryEntity           GetDictionaryEntity           ()=> (DictionaryEntity)          GetEntity(MODELS.Dictionary          );
        public static EntitlementEntity          GetEntitlementEntity          ()=> (EntitlementEntity)         GetEntity(MODELS.Entitlement         );
        public static EntitlementGroupEntity     GetEntitlementGroupEntity     ()=> (EntitlementGroupEntity)    GetEntity(MODELS.EntitlementGroup    );
        public static EntityEntity               GetEntityEntity               ()=> (EntityEntity)              GetEntity(MODELS.Entity              );
        public static FoodClassEntity            GetFoodClassEntity            ()=> (FoodClassEntity)           GetEntity(MODELS.FoodClass           );
        public static FoodTypeEntity             GetFoodTypeEntity             ()=> (FoodTypeEntity)            GetEntity(MODELS.FoodType            );
        public static IdentificationEntity       GetIdentificationEntity       ()=> (IdentificationEntity)      GetEntity(MODELS.Identification      );
        public static IdentificationTypeEntity   GetIdentificationTypeEntity   ()=> (IdentificationTypeEntity)  GetEntity(MODELS.IdentificationType  );
        public static ProfileEntity              GetProfileEntity              ()=> (ProfileEntity)             GetEntity(MODELS.Profile             );
        public static ProfileEntitlementEntity   GetProfileEntitlementEntity   ()=> (ProfileEntitlementEntity)  GetEntity(MODELS.ProfileEntitlement  );
        public static ProjectEntity              GetProjectEntity              ()=> (ProjectEntity)             GetEntity(MODELS.Project             );
        public static ReservationEntity          GetReservationEntity          ()=> (ReservationEntity)         GetEntity(MODELS.Reservation         );
        public static RoomEntity                 GetRoomEntity                 ()=> (RoomEntity)                GetEntity(MODELS.Room                );
        public static ServiceEntity              GetServiceEntity              ()=> (ServiceEntity)             GetEntity(MODELS.Service             );
        public static UserEntity                 GetUserEntity                 ()=> (UserEntity)                GetEntity(MODELS.User                );
        public static VATEntity                  GetVATEntity                  ()=> (VATEntity)                 GetEntity(MODELS.VAT                 );


    }
}
