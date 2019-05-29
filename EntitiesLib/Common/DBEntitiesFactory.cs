using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCHIS.Common {
    public static class DBEntitiesFactory {
        private static Dictionary<MODELS, IDBEntity> EntitiesMap = null;

        public static void Initialize(){
            EntitiesMap = new Dictionary<MODELS, IDBEntity>();

            var type = typeof(IDBEntity);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => type.IsAssignableFrom(p));

            //Console.WriteLine("--------------------------------------------------------");
            foreach (var t in types) {
                //try {
                var FORs = t.GetCustomAttributes(typeof(ForModelAttribute), false);
                if (FORs.Count() == 0) continue;
                var FOR = (ForModelAttribute)FORs.First();
                //Console.WriteLine($"{FOR.Entity}\t{t}");
                EntitiesMap[FOR.Model] = (IDBEntity)Activator.CreateInstance(t);
                //} catch { }
                Console.WriteLine(EntitiesMap[FOR.Model].GetDDL());
                //Console.WriteLine("go");
            }
            //Console.WriteLine("--------------------------------------------------------");
            
        }

        public static IDBEntity GetEntity(MODELS ce){
            if (EntitiesMap == null) Initialize();
            return EntitiesMap[ce];
        }
    }
}
