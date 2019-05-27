using MVCWinform.Common;
using System.Linq;

namespace MVCWinform.Security {
    [ForEntityAttribute(Entities.Entitlement, Enabled = true)]
    public class EntitlementController : AbstractDBController {

        public EntitlementController() : base(DBEntitiesFactory.GetEntity(Entities.Entitlement)) { }

        public void Initialize() {
            string[][] data = {
                new string[]{"Rooms","Housing","Room"},
                new string[]{"Buildings","Housing","Building"},
                new string[]{"Compounds","Housing","Compound"},
                new string[]{"Billing Categories","Billing","BillingCategory"},
                new string[]{"Residents","Customers",null},
                //new string[]{"Companies","Customers",null},
                new string[]{"Projects","Customers","Project"},
                new string[]{"Entitlements","Security","Entitlement"},
                new string[]{"Profiles","Security","Profile"},
                new string[]{"Residents Search","Reports",null},
                new string[]{"New Check In","Operations",null},
                new string[]{"SQL Viewer","Developer",null},
                new string[]{"Check In","Operations",null},
                new string[]{"Check Out","Operations",null},
                new string[]{"Room Movement","Operations",null},
                new string[]{"Encryption Tool","Developer",null},
                new string[]{"Users","Security","User"},
                new string[]{"Country","Customers","Country"},
                new string[]{"Bills","Billing",null},
                new string[]{"Audit","Security","Audit"},
                new string[]{"Contracts","Billing",null},
                new string[]{"Building Types","Housing","BuildingType"},
                new string[]{"Clients","Customers","Client"},
                new string[]{"Client Types","Customers","ClientType"},
                new string[]{"Accommodation Classes","Billing","AccomClass"},
                new string[]{"Food Classes","Billing","FoodClass"},
                new string[]{"Food Types","Billing","FoodType"},
                new string[]{"Identification Types","Customers","IdentificationType"},
                new string[]{"Entitlement Groups","Security","EntitlementGroup"},
                new string[]{"Identification","Customers","Identification"},
                new string[]{"Date Conversion","Tools",null},
                new string[]{"Dictionary","Tools","Dictionary"},
                new string[]{"Profile Entitlements","Security","ProfileEntitlement"},
                new string[]{"Contacts","Customers","Contact"},
                new string[]{"Initialize","File",null},
                new string[]{"Entities","Tools","Entity"},
            };
            foreach(string[]entitlement in data) {
                Save(new EntitlementModel() {
                    EntitlementName = entitlement[0],
                    EntitlementGroupName = entitlement[1],
                    EntityName = entitlement[2]
                });
            }
        }
    }
}
