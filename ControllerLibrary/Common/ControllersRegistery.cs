using ControllerLibrary.Customers;
using ControllerLibrary.Housing;
using ControllerLibrary.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Common {
    public class ControllersRegistery {
        private Dictionary<ControllersEnum, List<Type>> controllerMap = new Dictionary<ControllersEnum, List<Type>>();
        private static ControllersRegistery _instance = null;
        public static ControllersRegistery Instance {
            get {
                if (_instance == null) _instance = new ControllersRegistery();
                return _instance;
            }
        }

        public List<Type> this[ControllersEnum controllersEnum] {
            get {
                return this.controllerMap[controllersEnum];
            }
        }

        private ControllersRegistery() {

            foreach(ControllersEnum num in typeof(ControllersEnum).GetEnumValues()) {
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
