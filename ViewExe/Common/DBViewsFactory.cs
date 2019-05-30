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
        private static Dictionary<MODELS, Type> ViewsMap = new Dictionary<MODELS, Type> {
              [MODELS.BillingCategory      ] = typeof(BillingCategoryForm)
            , [MODELS.AccommClass          ] = typeof(AccommClassForm)
            , [MODELS.Audit                ] = typeof(AuditForm)
            , [MODELS.Building             ] = typeof(BuildingForm)
            , [MODELS.BuildingType         ] = typeof(BuildingTypeForm)
            , [MODELS.Client               ] = typeof(ClientForm)
            , [MODELS.ClientType           ] = typeof(ClientTypeForm)
            , [MODELS.Compound             ] = typeof(CompoundForm)
            , [MODELS.Dictionary           ] = typeof(DictionaryForm)
            , [MODELS.Entitlement          ] = typeof(EntitlementForm)
            , [MODELS.EntitlementGroup     ] = typeof(EntitlementGroupForm)
            , [MODELS.FoodClass            ] = typeof(FoodClassForm)
            , [MODELS.FoodType             ] = typeof(FoodTypeForm)
            , [MODELS.Identification       ] = typeof(IdentificationForm)
            , [MODELS.IdentificationType   ] = typeof(IdentificationTypeForm)
            , [MODELS.Country              ] = typeof(CountryForm)
            , [MODELS.Profile              ] = typeof(ProfileForm)
            , [MODELS.ProfileEntitlement   ] = typeof(ProfileEntitlementForm)
            , [MODELS.Project              ] = typeof(ProjectForm)
            , [MODELS.Room                 ] = typeof(RoomForm)
            , [MODELS.User                 ] = typeof(UserForm)
            , [MODELS.Entity               ] = typeof(EntityForm)
            , [MODELS.Contact              ] = typeof(ContactForm)
            , [MODELS.ClientContact        ] = null // typeof(ClientContactForm)
            , [MODELS.ClientIdentification ] = null // typeof(ClientIdentificationForm)
        };

        public static void Initialize(){
            //ViewsMap = new Dictionary<MODELS, Type>();

            //var type = typeof(IView);
            //var types = AppDomain.CurrentDomain.GetAssemblies()
            //            .SelectMany(s => s.GetTypes())
            //            .Where(p => type.IsAssignableFrom(p));


            //Console.WriteLine("--------------------------------------------------------");
            //foreach (var t in types) {
            //    //try {
            //    var FORs = t.GetCustomAttributes(typeof(ForModelAttribute), false);
            //    if (FORs.Count() == 0) continue;
            //    var FOR = (ForModelAttribute)FORs.First();
            //    Console.WriteLine($"{FOR.Model}\t{t}");
            //    ViewsMap[FOR.Model] = t; // (ISingleForm)Activator.CreateInstance(t);
            //    //} catch { }
            //}
            //Console.WriteLine("--------------------------------------------------------");
        }

        public static IView GetView(MODELS ce){
            //if (ViewsMap == null) Initialize();
            return (IView)Activator.CreateInstance(ViewsMap[ce]);
        }
    }
}
