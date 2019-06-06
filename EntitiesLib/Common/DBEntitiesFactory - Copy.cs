using MVCHIS.Billing;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Security;
using MVCHIS.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCHIS.Common {
    //protected static class DBEntitiesFactory2 {
    //    private static Dictionary<Type, object> EntitysMap = new Dictionary<Type, object> { };

    //    public static IDBEntity<M> GetEntity<M>() where M : BaseModel {
    //        Type mtype = typeof(M);
    //        return (IDBEntity<M>)GetEntity(mtype);
    //    }

    //    public static object GetEntity(Type mtype) {
    //        var entity = AppDomain.CurrentDomain.GetAssemblies()
    //                    .SelectMany(s => s.GetTypes())
    //                    .Where(x => x.Name.Equals($"{mtype.Name.Replace("Model", "")}Entity") || (x.Name.EndsWith("Entity") && x.Name.Equals(mtype.Name)))
    //                    .FirstOrDefault();

    //        if (EntitysMap.ContainsKey(entity) == false) {
    //            InitializeEntity(entity);
    //        }
    //        return EntitysMap[entity];
    //    }

    //    public static object GetEntity(MODELS num) {
    //        var entity = AppDomain.CurrentDomain.GetAssemblies()
    //                    .SelectMany(s => s.GetTypes())
    //                    .Where(x => x.Name.Equals($"{num}Entity"))
    //                    .FirstOrDefault();
    //        return GetEntity(entity);
    //    }

    //    private static void InitializeEntity(Type entity) {// where M:BaseModel{


    //        if (entity != null) {
    //            if (Enum.TryParse(entity.Name.Substring(0, (entity.Name.Length) - ("Entity".Length)), out MODELS num)) {
    //                EntitysMap[entity] = Activator.CreateInstance(entity);
    //                Console.WriteLine($" + [Entity] : {num}:{entity}");
    //                Console.WriteLine(EntitysMap[entity].GetType().GetMethod("GetDDL").Invoke(EntitysMap[entity],null));

    //            } else {
    //                throw new Exception($"no Enum was defined for {entity}");
    //            }
    //        }
    //    }
    //}
}
