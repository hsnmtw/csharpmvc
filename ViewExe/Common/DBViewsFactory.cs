using System;
using System.Collections.Generic;
using System.Linq;
using ViewWinform.Common;

namespace MVCHIS.Common {
    public static class DBViewsFactory {
        private static Dictionary<MODELS, Type> ViewsMap = null;

        public static void InitViewsMap(){
            ViewsMap = new Dictionary<MODELS, Type>();

            var type = typeof(IView);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => type.IsAssignableFrom(p));


            Console.WriteLine("--------------------------------------------------------");
            foreach (var t in types) {
                //try {
                var FORs = t.GetCustomAttributes(typeof(ForModelAttribute), false);
                if (FORs.Count() == 0) continue;
                var FOR = (ForModelAttribute)FORs.First();
                Console.WriteLine($"{FOR.Model}\t{t}");
                ViewsMap[FOR.Model] = t; // (ISingleForm)Activator.CreateInstance(t);
                //} catch { }
            }
            Console.WriteLine("--------------------------------------------------------");

        }

        public static IView GetView(MODELS ce){
            if (ViewsMap == null) InitViewsMap();
            return (IView)Activator.CreateInstance(ViewsMap[ce]);
        }
    }
}
