using MVCHIS.Billing;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Security;
using MVCHIS.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCHIS.Common {
    public static class DBControllersFactory {
        private static Dictionary<MODELS, IDBController> ControllersMap = new Dictionary<MODELS, IDBController> { };

        public static IDBController GetController(MODELS model) {
            if (ControllersMap.ContainsKey(model) == false) {
                InitializeController(model);
            }
            return ControllersMap[model];
        }

        private static void InitializeController(MODELS model) {
            var type = typeof(AbstractDBController);
            var cntrlr = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => type.IsAssignableFrom(p))
                        .Where(x => x.Name.Equals($"{model}Controller"))
                        .FirstOrDefault();

            if (cntrlr != null) {
                if (Enum.TryParse(cntrlr.Name.Substring(0, (cntrlr.Name.Length) - ("Controller".Length)), out MODELS num)) {
                    ControllersMap[num] = (IDBController)Activator.CreateInstance(cntrlr);
                    Console.WriteLine($" + [Controller] : {num}:{cntrlr}");
                } else {
                    throw new Exception($"no Enum was defined for {cntrlr}");
                }
            }
        }

        public static IDBController GetController(string v) {
            throw new NotImplementedException();
        }

        public static void SetController(MODELS num, IDBController iDBController) {
            throw new NotImplementedException();
        }
    }
}
