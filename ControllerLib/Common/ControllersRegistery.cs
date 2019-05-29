using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCHIS.Common {
    public class ControllersRegistery {
        private static Dictionary<MODELS, List<Type>> ControllersMap = new Dictionary<MODELS, List<Type>>();
        private static ControllersRegistery instance = null;
        public static ControllersRegistery Instance {
            get {
                if (instance == null) instance = new ControllersRegistery();
                return instance;
            }
        }

        public List<Type> this[MODELS controllersEnum] {
            get {
                return ControllersMap[controllersEnum];
            }
        }

        private ControllersRegistery() {
            try {
                init();
            } catch { }
        }

        private void init() { 
            foreach(MODELS num in typeof(MODELS).GetEnumValues()) {
                ControllersMap[num] = new List<Type>();
            }

            var type = typeof(IDBController);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => type.IsAssignableFrom(p));

            Console.WriteLine("--------------------------------------------------------");
            foreach (var t in types) {
                try {
                    var FOR = (ForModelAttribute)t.GetCustomAttributes(typeof(ForModelAttribute), false).First();
                    Console.WriteLine($"{FOR.Model}\t{t}");
                    ControllersMap[FOR.Model].Add(t);
                } catch { }
            }
            Console.WriteLine("--------------------------------------------------------");
        }

    }
}
