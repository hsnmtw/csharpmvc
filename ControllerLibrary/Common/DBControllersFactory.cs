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
    public static class DBControllersFactory {
        private static Dictionary<Entities, IDBController> ControllersMap = null;

        public static void InitControllersMap(){
		   ControllersMap = new Dictionary<Entities, IDBController>() {
           };

           foreach(Entities num in typeof(Entities).GetEnumValues()) {
                foreach(var type in ControllersRegistery.Instance[num]) {
                    ForControllerAttribute forca = (ForControllerAttribute)type.GetCustomAttributes(true).OfType<ForControllerAttribute>().First();
                    if (forca.Enabled) {
                        DBControllersFactory.ControllersMap[num] = (IDBController)Activator.CreateInstance(type);
                    }
                }
            }
        }

        public static IDBController GetController(string typeName) {
            return (IDBController)Activator.CreateInstance(Type.GetType(typeName));
        }

        public static Dictionary<Entities, IDBController> GetControllersMap() {
            return ControllersMap;
		}

        public static IDBController GetController(Entities ce){
            if (ControllersMap == null) InitControllersMap();
            return ControllersMap[ce];
        }

        public static void SetController(Entities ce,IDBController bc) {
            if (ControllersMap == null) InitControllersMap();
            ControllersMap[ce] = bc;
        }
    }
}
