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
        private static Dictionary<CollectionsEnum, BaseCollection> CollectionsMap = null;

        public static void InitCollectionsMap(){
		   CollectionsMap = new Dictionary<CollectionsEnum, BaseCollection>() {
              [CollectionsEnum.Nationality        ] = new NationalityCollection        ()
            , [CollectionsEnum.Compound           ] = new CompoundCollection           ()
            , [CollectionsEnum.User               ] = new UserCollection               ()
            , [CollectionsEnum.Entitlement        ] = new EntitlementCollection        ()
            , [CollectionsEnum.ProfileEntitlements] = new ProfileEntitlementsCollection()
            , [CollectionsEnum.Profile            ] = new ProfileCollection            ()
            , [CollectionsEnum.Building           ] = new BuildingCollection           ()
            , [CollectionsEnum.Room               ] = new RoomCollection               ()
            , [CollectionsEnum.Audit              ] = new AuditCollection              ()
           };
        }

        public static Dictionary<CollectionsEnum, BaseCollection> GetCollectionsMap() {
            return CollectionsMap;
		}

        public static BaseCollection GetCollection(CollectionsEnum ce){
            if (CollectionsMap == null) InitCollectionsMap();
            return CollectionsMap[ce];
        }

        public static void SetCollection(CollectionsEnum ce,BaseCollection bc) {
            if (CollectionsMap == null) InitCollectionsMap();
            CollectionsMap[ce] = bc;
        }
    }
}
