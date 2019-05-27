using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCWinform.Common {
    public static class DBViewsFactory {
        private static Dictionary<Entities, Type> ViewsMap = null;

        public static void InitViewsMap(){
            ViewsMap = new Dictionary<Entities, Type>();

            var type = typeof(ISingleForm);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => type.IsAssignableFrom(p));


            Console.WriteLine("--------------------------------------------------------");
            foreach (var t in types) {
                //try {
                var FORs = t.GetCustomAttributes(typeof(ForEntityAttribute), false);
                if (FORs.Count() == 0) continue;
                var FOR = (ForEntityAttribute)FORs.First();
                Console.WriteLine($"{FOR.Entity}\t{t}");
                ViewsMap[FOR.Entity] = t; // (ISingleForm)Activator.CreateInstance(t);
                //} catch { }
            }
            Console.WriteLine("--------------------------------------------------------");

        }

        public static ISingleForm GetView(Entities ce){
            if (ViewsMap == null) InitViewsMap();
            //return ViewsMap[ce];
            return (ISingleForm)Activator.CreateInstance(ViewsMap[ce]);
        }
    }
}
