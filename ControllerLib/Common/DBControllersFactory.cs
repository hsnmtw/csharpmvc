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
        private static Dictionary<Type, object> ControllersMap = new Dictionary<Type, object> { };

        public static IDBController<M> GetController<M>() where M:BaseModel {
            Type mtype = typeof(M);
            return (IDBController<M>)GetController(mtype);
        }

        public static object GetController(Type mtype) {
            var cntrlr = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(x => x.Name.Equals($"{mtype.Name.Replace("Model", "")}Controller") || (x.Name.EndsWith("Controller") &&  x.Name.Equals(mtype.Name)) )
                        .FirstOrDefault();

            if (ControllersMap.ContainsKey(cntrlr) == false) {
                InitializeController(cntrlr);
            }
            return ControllersMap[cntrlr];
        }

        public static object GetController(MODELS num) {
            var cntrlr = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(x => x.Name.Equals($"{num}Controller"))
                        .FirstOrDefault();
            return GetController(cntrlr);
        }

        private static void InitializeController(Type cntrlr) {// where M:BaseModel{


            if (cntrlr != null) {
                if (Enum.TryParse(cntrlr.Name.Substring(0, (cntrlr.Name.Length) - ("Controller".Length)), out MODELS num)) {
                    ControllersMap[cntrlr] = Activator.CreateInstance(cntrlr);
                    Console.WriteLine($" + [Controller] : {num}:{cntrlr}");
                } else {
                    throw new Exception($"no Enum was defined for {cntrlr}");
                }
            }
        }
    }
}
