using MVCHIS.Billing;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Security;
using MVCHIS.Tools;
using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MVCHIS.Common {
    public static class DBControllersFactory {
        private static Dictionary<MODELS, IController> ControllerMap = new Dictionary<MODELS, IController> { };
        private static Dictionary<string, Type> ControllerTypes = new Dictionary<string, Type>();
        public static string FK(MODELS models, string id) => FK(models, id.ToInteger());
        public static string FK(MODELS models,int id) {
            return GetController(models).GetValues(id);
        }

        /// <summary>
        /// assumes that {TableName}{Id} convension is used,
        /// example: 
        /// <code>
        /// Department ('Id',Name)
        /// Employee   ('Id',Name,DepartmentId) : where (Department => Department(id))
        /// </code>
        /// </summary>
        /// <param name="k"></param>
        /// <returns>either foreign key value or same key provided</returns>
        public static string GetFKSource(string k,object value) {
            if ((value is int) && k.Length > 2 && Enum.TryParse(k.Substring(0, k.Length - 2), out MODELS m)) {
                return GetController(m).GetValues((int)value).ToSortableString();
            }
            return value.ToSortableString();
        }



        public static IController GetController(string models) {
            if(Enum.TryParse(models,out MODELS m)) {
                return GetController(m);
            }
            throw new Exception($"Controller : [{models}] cannot be found !!!");
        }

        public static IController GetController(MODELS model) {
            if (ControllerMap.ContainsKey(model) == false) InitializeTypesMap(model);
            return ControllerMap[model];
        }

        private static void InitializeTypesMap(MODELS model) {
            var type = Assembly
                       .GetExecutingAssembly()
                       .GetTypes()
                       .Where(x => x.Name.Equals($"{model}Controller"))
                       .FirstOrDefault();
            ControllerTypes[type.Name] = type;
            ControllerMap[model] = (IController)Activator.CreateInstance(type);
        }

        public static IDBController<M> GetControllerOfModel<M>() where M : BaseModel {
            var name = typeof(M).Name;
            if (Enum.TryParse(name.Substring(0, name.Length - "Model".Length), out MODELS model)) {
                return (IDBController<M>)GetController(model);
            }
            throw new Exception($"Controller: IDBController<{typeof(M)}> cannot be found in the list of MODELS enum");
        }

        public static C GetController<C>() where C:IController {
            var name = typeof(C).Name;
            if (Enum.TryParse(name.Substring(0,name.Length-"Controller".Length),out MODELS model)) {
                return (C)GetController(model);
            }
            throw new Exception($"Controller: {typeof(C)} cannot be found in the list of MODELS enum");
        }

        public static WordLanguageController         WordLanguage         ()=> (WordLanguageController)        GetController(MODELS.WordLanguage);
        public static LanguageController             Language             ()=> (LanguageController)            GetController(MODELS.Language);
        public static AuditController                Audit                ()=> (AuditController)               GetController(MODELS.Audit               );
        public static BillingCategoryController      BillingCategory      ()=> (BillingCategoryController)     GetController(MODELS.BillingCategory     );
        public static ClientController               Client               ()=> (ClientController)              GetController(MODELS.Client              );
        public static ClientContactController        ClientContact        ()=> (ClientContactController)       GetController(MODELS.ClientContact       );
        public static ClientIdentificationController ClientIdentification ()=> (ClientIdentificationController)GetController(MODELS.ClientIdentification); 
        public static ContactController              Contact              ()=> (ContactController)             GetController(MODELS.Contact             );
        public static ContractController             Contract             ()=> (ContractController)            GetController(MODELS.Contract            );
        public static CurrencyController             Currency             ()=> (CurrencyController)            GetController(MODELS.Currency            );
        public static WordController                 Word                 ()=> (WordController)                GetController(MODELS.Word          );
        public static EntitlementController          Entitlement          ()=> (EntitlementController)         GetController(MODELS.Entitlement         );
        public static EntitlementGroupController     EntitlementGroup     ()=> (EntitlementGroupController)    GetController(MODELS.EntitlementGroup    );
        public static EntityController               Entity               ()=> (EntityController)              GetController(MODELS.Entity              );
        public static IdentificationController       Identification       ()=> (IdentificationController)      GetController(MODELS.Identification      );
        public static ProfileController              Profile              ()=> (ProfileController)             GetController(MODELS.Profile             );
        public static ProfileEntitlementController   ProfileEntitlement   ()=> (ProfileEntitlementController)  GetController(MODELS.ProfileEntitlement  );
        public static RoomController                 Room                 ()=> (RoomController)                GetController(MODELS.Room                );
        public static ServiceController              Service              ()=> (ServiceController)             GetController(MODELS.Service             );
        public static UserController                 User                 ()=> (UserController)                GetController(MODELS.User                );
        public static VATController                  VAT                  ()=> (VATController)                 GetController(MODELS.VAT                 );

    }
}
