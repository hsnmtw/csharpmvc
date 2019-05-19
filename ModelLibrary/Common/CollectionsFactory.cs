using ModelLibrary.Customers;
using ModelLibrary.Housing;
using ModelLibrary.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Common {
    public class CollectionsFactory {
        public static Dictionary<CollectionsEnum, BaseCollection> GetCollections() {
            return new Dictionary<CollectionsEnum, BaseCollection> {
                  [CollectionsEnum.Building] = new BuildingCollection()
                , [CollectionsEnum.Compound] = new CompoundCollection()
                , [CollectionsEnum.Room]     = new RoomCollection()
                , [CollectionsEnum.Entitlement] = new EntitlementCollection()
                , [CollectionsEnum.Profile] = new ProfileCollection()
                , [CollectionsEnum.ProfileEntitlements] = new ProfileEntitlementsCollection()
                , [CollectionsEnum.User] = new UserCollection()
                , [CollectionsEnum.Nationality] = new NationalityCollection()
            };
        }

        public static BaseCollection CreateCollection(CollectionsEnum collectionsEnum) {
            return GetCollections()[collectionsEnum];
        }

    }
}
