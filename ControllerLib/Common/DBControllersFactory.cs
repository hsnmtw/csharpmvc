using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCHIS.Common {
    public static class DBControllersFactory {
        private static Dictionary<Entities, IDBController> ControllersMap = null;

        public static void Initialize(){
            

            ControllersMap = new Dictionary<Entities, IDBController>() {
           };

           foreach(Entities num in typeof(Entities).GetEnumValues()) {
                foreach(var type in ControllersRegistery.Instance[num]) {
                    ForEntityAttribute forca = (ForEntityAttribute)type.GetCustomAttributes(true).OfType<ForEntityAttribute>().First();
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
            if (ControllersMap == null) Initialize();
            return ControllersMap[ce];
        }

        public static void SetController(Entities ce,IDBController bc) {
            if (ControllersMap == null) Initialize();
            ControllersMap[ce] = bc;
        }
    }
}
