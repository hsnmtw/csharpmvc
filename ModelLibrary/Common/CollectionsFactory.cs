using ModelLibrary.Customers;
using ModelLibrary.Housing;
using ModelLibrary.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Common {
    public static class CollectionsFactory {
        private static Dictionary<Entities, BaseCollection> CollectionsMap = null;

        public static void InitCollectionsMap(){
		   CollectionsMap = new Dictionary<Entities, BaseCollection>() {
              [Entities.Nationality        ] = new NationalityCollection        ()
            , [Entities.Compound           ] = new CompoundCollection           ()
            , [Entities.User               ] = new UserCollection               ()
            , [Entities.Entitlement        ] = new EntitlementCollection        ()
            , [Entities.ProfileEntitlement ] = new ProfileEntitlementsCollection()
            , [Entities.Profile            ] = new ProfileCollection            ()
            , [Entities.Building           ] = new BuildingCollection           ()
            , [Entities.Room               ] = new RoomCollection               ()
            , [Entities.Audit              ] = new AuditCollection              ()
            , [Entities.BuildingType       ] = new BuildingTypeCollection       ()
            , [Entities.ClientType         ] = new ClientTypeCollection         ()
            , [Entities.Client             ] = new ClientCollection             ()
            , [Entities.Project            ] = new ProjectCollection            ()
            , [Entities.AccomCategory      ] = new AccomCategoryCollection      ()
            , [Entities.AccomClass         ] = new AccomClassCollection         ()
            , [Entities.FoodClass          ] = new FoodClassCollection          ()
           };
        }

        public static Dictionary<Entities, BaseCollection> GetCollectionsMap() {
            return CollectionsMap;
		}

        public static BaseCollection GetCollection(Entities ce){
            if (CollectionsMap == null) InitCollectionsMap();
            return CollectionsMap[ce];
        }

        public static void SetCollection(Entities ce,BaseCollection bc) {
            if (CollectionsMap == null) InitCollectionsMap();
            CollectionsMap[ce] = bc;
        }
    }
}
