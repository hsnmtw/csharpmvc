using ModelLibrary.Customers;
using ModelLibrary.Housing;
using ModelLibrary.Security;
using ModelLibrary.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Common {
    public static class DBEntitiesFactory {
        private static Dictionary<Entities, IDBEntity> EntitiesMap = null;

        public static void InitEntitiesMap(){
		   EntitiesMap = new Dictionary<Entities, IDBEntity>() {
              [Entities.Country            ] = new CountryEntity            ()
            , [Entities.Compound           ] = new CompoundEntity           ()
            , [Entities.User               ] = new UserEntity               ()
            , [Entities.Entitlement        ] = new EntitlementEntity        ()
            , [Entities.ProfileEntitlement ] = new ProfileEntitlementsEntity()
            , [Entities.Profile            ] = new ProfileEntity            ()
            , [Entities.Building           ] = new BuildingEntity           ()
            , [Entities.Room               ] = new RoomEntity               ()
            , [Entities.Audit              ] = new AuditEntity              ()
            , [Entities.BuildingType       ] = new BuildingTypeEntity       ()
            , [Entities.ClientType         ] = new ClientTypeEntity         ()
            , [Entities.Client             ] = new ClientEntity             ()
            , [Entities.Project            ] = new ProjectEntity            ()
            , [Entities.AccomCategory      ] = new BillingCategoryEntity    ()
            , [Entities.AccomClass         ] = new AccomClassEntity         ()
            , [Entities.FoodClass          ] = new FoodClassEntity          ()
            , [Entities.FoodType           ] = new FoodTypeEntity           ()
            , [Entities.IdentificationType ] = new IdentificationTypeEntity ()
            , [Entities.Identification     ] = new IdentificationEntity     ()
            , [Entities.EntitlementGroup   ] = new EntitlementGroupEntity   ()
            , [Entities.Dictionary         ] = new DictionaryEntity         ()
           };
        }

        public static Dictionary<Entities, IDBEntity> GetEntitiesMap() {
            return EntitiesMap;
		}

        public static IDBEntity GetEntity(Entities ce){
            if (EntitiesMap == null) InitEntitiesMap();
            return EntitiesMap[ce];
        }

        public static void SetEntity(Entities ce,IDBEntity bc) {
            if (EntitiesMap == null) InitEntitiesMap();
            EntitiesMap[ce] = bc;
        }
    }
}
