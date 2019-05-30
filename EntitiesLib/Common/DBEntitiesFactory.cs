using MVCHIS.Billing;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Security;
using MVCHIS.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCHIS.Common {
    public static class DBEntitiesFactory {
        private static Dictionary<MODELS, IDBEntity> EntitiesMap = new Dictionary<MODELS, IDBEntity>{
              [MODELS.BillingCategory      ] = new BillingCategoryEntity()
            , [MODELS.AccommClass          ] = new AccommClassEntity()
            , [MODELS.Audit                ] = new AuditEntity()
            , [MODELS.Building             ] = new BuildingEntity()
            , [MODELS.BuildingType         ] = new BuildingTypeEntity()
            , [MODELS.Client               ] = new ClientEntity()
            , [MODELS.ClientType           ] = new ClientTypeEntity()
            , [MODELS.Compound             ] = new CompoundEntity()
            , [MODELS.Dictionary           ] = new DictionaryEntity()
            , [MODELS.Entitlement          ] = new EntitlementEntity()
            , [MODELS.EntitlementGroup     ] = new EntitlementGroupEntity()
            , [MODELS.FoodClass            ] = new FoodClassEntity()
            , [MODELS.FoodType             ] = new FoodTypeEntity()
            , [MODELS.Identification       ] = new IdentificationEntity()
            , [MODELS.IdentificationType   ] = new IdentificationTypeEntity()
            , [MODELS.Country              ] = new CountryEntity()
            , [MODELS.Profile              ] = new ProfileEntity()
            , [MODELS.ProfileEntitlement   ] = new ProfileEntitlementsEntity()
            , [MODELS.Project              ] = new ProjectEntity()
            , [MODELS.Room                 ] = new RoomEntity()
            , [MODELS.User                 ] = new UserEntity()
            , [MODELS.Entity               ] = new EntityEntity()
            , [MODELS.Contact              ] = new ContactEntity()
            , [MODELS.ClientContact        ] = new ClientContactEntity()
            , [MODELS.ClientIdentification ] = new ClientIdentificationEntity()
        };
        
        public static void Initialize(){
            //EntitiesMap = new Dictionary<MODELS, IDBEntity>();

            //var type = typeof(IDBEntity);
            //var types = AppDomain.CurrentDomain.GetAssemblies()
            //            .SelectMany(s => s.GetTypes())
            //            .Where(p => type.IsAssignableFrom(p));

            //lock (EntitiesMap) {
            //    foreach (var t in types) {
            //        var FORs = t.GetCustomAttributes(typeof(ForModelAttribute), false);
            //        if (FORs.Count() == 0) continue;
            //        var FOR = (ForModelAttribute)FORs.First();
            //        var entity = EntitiesMap[FOR.Model] = (IDBEntity)Activator.CreateInstance(t);
            //        Console.WriteLine(entity.GetDDL());
            //    }
            //}
            foreach (var k in EntitiesMap.Keys) Console.WriteLine(EntitiesMap[k].GetDDL() + ";");
        }

        public static IDBEntity GetEntity(MODELS ce){
            //if (EntitiesMap == null) Initialize();
            return EntitiesMap[ce];
        }
    }
}
