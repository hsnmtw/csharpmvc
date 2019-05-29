using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCHIS.Common {
    public class ControllersRegistery {
        private static Dictionary<Entities, List<Type>> ControllersMap = new Dictionary<Entities, List<Type>>();
        private static ControllersRegistery instance = null;
        public static ControllersRegistery Instance {
            get {
                if (instance == null) instance = new ControllersRegistery();
                return instance;
            }
        }

        public List<Type> this[Entities controllersEnum] {
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
            foreach(Entities num in typeof(Entities).GetEnumValues()) {
                ControllersMap[num] = new List<Type>();
            }

            var type = typeof(IDBController);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => type.IsAssignableFrom(p));

            Console.WriteLine("--------------------------------------------------------");
            foreach (var t in types) {
                try {
                    var FOR = (ForEntityAttribute)t.GetCustomAttributes(typeof(ForEntityAttribute), false).First();
                    Console.WriteLine($"{FOR.Entity}\t{t}");
                    ControllersMap[FOR.Entity].Add(t);
                } catch { }
            }
            Console.WriteLine("--------------------------------------------------------");
        }

    }
}
