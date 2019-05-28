using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCWinform.Common {
    public static class DBEntitiesFactory {
        private static Dictionary<Entities, IDBEntity> EntitiesMap = null;

        public static void InitEntitiesMap(){
            EntitiesMap = new Dictionary<Entities, IDBEntity>();

            var type = typeof(IDBEntity);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => type.IsAssignableFrom(p));

            //Console.WriteLine("--------------------------------------------------------");
            foreach (var t in types) {
                //try {
                var FORs = t.GetCustomAttributes(typeof(ForEntityAttribute), false);
                if (FORs.Count() == 0) continue;
                var FOR = (ForEntityAttribute)FORs.First();
                //Console.WriteLine($"{FOR.Entity}\t{t}");
                EntitiesMap[FOR.Entity] = (IDBEntity)Activator.CreateInstance(t);
                //} catch { }
                Console.WriteLine(EntitiesMap[FOR.Entity].GetDDL());
                //Console.WriteLine("go");
            }
            //Console.WriteLine("--------------------------------------------------------");
            
        }

        public static IDBEntity GetEntity(Entities ce){
            if (EntitiesMap == null) InitEntitiesMap();
            return EntitiesMap[ce];
        }
    }
}
