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
    public class ControllersRegistery {
        private Dictionary<Entities, List<Type>> controllerMap = new Dictionary<Entities, List<Type>>();
        private static ControllersRegistery instance = null;
        public static ControllersRegistery Instance {
            get {
                if (instance == null) instance = new ControllersRegistery();
                return instance;
            }
        }

        public List<Type> this[Entities controllersEnum] {
            get {
                return this.controllerMap[controllersEnum];
            }
        }

        private ControllersRegistery() {

            foreach(Entities num in typeof(Entities).GetEnumValues()) {
                controllerMap[num] = new List<Type>();
            }

            var type = typeof(BaseController);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => type.IsAssignableFrom(p));

            Console.WriteLine("--------------------------------------------------------");
            foreach (var t in types) {
                try {
                    ForControllerAttribute FOR = (ForControllerAttribute)t.GetCustomAttributes(typeof(ForControllerAttribute), false).First();
                    Console.WriteLine($"{FOR.ControllersEnum}\t{t}");
                    controllerMap[FOR.ControllersEnum].Add(t);
                } catch { }
            }
            Console.WriteLine("--------------------------------------------------------");
        }

    }
}
