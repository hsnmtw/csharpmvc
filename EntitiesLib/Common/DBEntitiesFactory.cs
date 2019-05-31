using MVCHIS.Billing;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Security;
using MVCHIS.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCHIS.Common {
    public static class DBEntitiesFactory {
        private static Dictionary<MODELS, IDBEntity> EntitiesMap = new Dictionary<MODELS, IDBEntity> { };
        public static IDBEntity GetEntity(MODELS model){
            if (EntitiesMap.ContainsKey(model) == false) {
                InitializeEntity(model);
            }
            
            return EntitiesMap[model];
        }

        private static void InitializeEntity(MODELS model) {
            var type = typeof(AbstractDBEntity);
            var entity = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => type.IsAssignableFrom(p))
                        .Where(x => x.Name.Equals($"{model}Entity"))
                        .FirstOrDefault();

            if(entity != null) {
                if (Enum.TryParse(entity.Name.Substring(0, (entity.Name.Length)-("Entity".Length)), out MODELS num)) {
                    EntitiesMap[num] = (IDBEntity)Activator.CreateInstance(entity);
                    Console.WriteLine($" + [Entity] : {num}:{entity}");
                    Console.WriteLine(EntitiesMap[model].GetDDL());
                } else {
                    throw new Exception($"no Enum was defined for {entity}");
                }
            }
        }
    }
}
