using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCHIS.Common {
    public static class DBControllersFactory {
        private static Dictionary<MODELS, IDBController> ControllersMap = null;

        public static void Initialize(){
            

            ControllersMap = new Dictionary<MODELS, IDBController>() {
           };

           foreach(MODELS num in typeof(MODELS).GetEnumValues()) {
                foreach(var type in ControllersRegistery.Instance[num]) {
                    ForModelAttribute forca = (ForModelAttribute)type.GetCustomAttributes(true).OfType<ForModelAttribute>().First();
                    if (forca.Enabled) {
                        DBControllersFactory.ControllersMap[num] = (IDBController)Activator.CreateInstance(type);
                    }
                }
            }
        }

        public static IDBController GetController(string typeName) {
            return (IDBController)Activator.CreateInstance(Type.GetType(typeName));
        }

        public static Dictionary<MODELS, IDBController> GetControllersMap() {
            return ControllersMap;
		}

        public static IDBController GetController(Common.MODELS ce){
            if (ControllersMap == null) Initialize();
            return ControllersMap[ce];
        }

        public static void SetController(MODELS ce,IDBController bc) {
            if (ControllersMap == null) Initialize();
            ControllersMap[ce] = bc;
        }
    }
}
