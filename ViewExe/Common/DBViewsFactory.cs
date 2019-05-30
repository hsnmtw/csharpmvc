using System;
using System.Collections.Generic;
using System.Linq;
using MVCHIS.Billing;
using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Housing.Buildings;
using MVCHIS.Housing.BuildingTypes;
using MVCHIS.Housing.Rooms;
using MVCHIS.Security;
using MVCHIS.Security.Users;
using MVCHIS.Tools;

namespace MVCHIS.Common {
    public static class DBViewsFactory {
        private static Dictionary<MODELS, Type> ViewsMap = new Dictionary<MODELS, Type> { };

        public static IView GetView(MODELS model) {
            if (ViewsMap.ContainsKey(model) == false) {
                InitializeView(model);
            }
            return (IView)Activator.CreateInstance(ViewsMap[model]);
        }

        private static void InitializeView(MODELS model) {
            var type = typeof(IView);
            var view = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => type.IsAssignableFrom(p))
                        .Where(x => x.Name.Equals($"{model}Form"))
                        .FirstOrDefault();

            if (view != null) {
                if (Enum.TryParse(view.Name.Substring(0, (view.Name.Length) - ("Form".Length)), out MODELS num)) {
                    ViewsMap[num] = view;
                    Console.WriteLine($" + [View] : {num}:{view}");
                } else {
                    throw new Exception($"no Enum was defined for {view}");
                }
            }
        }



    }
}
