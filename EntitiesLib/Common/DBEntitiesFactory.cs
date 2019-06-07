using MVCHIS.Billing;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Security;
using MVCHIS.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Linq;

namespace MVCHIS.Common {
    public static class DBEntitiesFactory {
        private static Dictionary<MODELS, object> EntityMap = new Dictionary<MODELS, object> { };
        private static Dictionary<string, Type> EntityTypes = new Dictionary<string, Type>();

        private static object GetEntity(MODELS model) {
            if (EntityMap.ContainsKey(model)==false) InitializeTypesMap(model);
            return EntityMap[model];
        }

        public static object GetEntityByName(string entityName) {
            return GetEntity(Enum.GetValues(typeof(MODELS)).Cast<MODELS>().Where(x => entityName == $"{x}" ).First());
        }

        private static void InitializeTypesMap(MODELS model) {
            var type = Assembly
                       .GetExecutingAssembly()
                       .GetTypes()
                       .Where(x => x.Name.Equals($"{model}Entity"))
                       .FirstOrDefault();
            EntityTypes[type.Name] = type;
            EntityMap[model] = Activator.CreateInstance(type);
            //this should be disabled after go-live
            //Console.WriteLine(EntityMap[model].GetType().GetMethod("GetDDL").Invoke(EntityMap[model], null));
        }

        public static IDBEntity<M> GetEntityOfModel<M>() where M:BaseModel {
            var name = typeof(M).Name;
            if (Enum.TryParse(name.Substring(0, name.Length - "Model".Length), out MODELS model)) {
                return (IDBEntity<M>)GetEntity(model);
            }
            throw new Exception($"Entity: IDBEntity<{typeof(M)}> cannot be found in the list of MODELS enum");
        }

        public static E GetEntity<E>() where E:IEntity {
            var name = typeof(E).Name;
            if (Enum.TryParse(name.Substring(0,name.Length-"Entity".Length),out MODELS model)) {
                return (E)GetEntity(model);
            }
            throw new Exception($"Entity: {typeof(E)} cannot be found in the list of MODELS enum");
        }


    }
}
