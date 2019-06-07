using MVCHIS.Common;
using MVCHIS.Tools;
using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCHIS.Security {
    public class PermissionsHelper<M,C> where C:IDBController<M> where M : BaseModel {
        public PermissionsHelper(BaseView<M,C> view) {
            if(view==null) throw new ArgumentException("view cannot be null");
            //if(model==default) throw new ArgumentException("model cannot be null");
            var CntrlEN = DBControllersFactory.Entitlement(); 
            var CntrlPE = DBControllersFactory.ProfileEntitlement(); 
            var CntrlPR = DBControllersFactory.Profile(); 
            var CntrlET = DBControllersFactory.Entity(); 

            var usr = MVCHISSession.Instance.CurrentUser;

            if (usr == null) return;
            //var mdl = view?.GetType().GetCustomAttributes().OfType<ForModelAttribute>().FirstOrDefault();
            //if (mdl == null) return;

            var entity = CntrlET.Find(new EntityModel() { EntityName = $"{typeof(M).Name}".Replace("Model", "") }, "EntityName");

            var ent = CntrlEN.Find(new EntitlementModel() { EntityId = entity.Id }, "EntityId");
            if (ent == null) return;
            
            var pen = CntrlPE.Find(new ProfileEntitlementModel() {
                ProfileId = usr.ProfileId ,
                EntitlementId = ent.Id
            }, "ProfileId", "EntitlementId");

            if (view.NewButton != null)    view.SetNewButtonEnabled    ( view.NewButton.Enabled && pen.AllowCreate );
            if (view.SaveButton != null)   view.SetSaveButtonEnabled   ( view.SaveButton.Enabled && pen.AllowUpdate );
            if (view.DeleteButton != null) view.SetDeleteButtonEnabled ( view.DeleteButton.Enabled && pen.AllowDelete );

            if (!pen.AllowRead) {
                FormsHelper.Error($"You don't have enough permissions to open {view}.");
                view.GotFocus += (x, y) => {
                    view.Enabled = false;
                    view.BeginInvoke(new MethodInvoker(view.Hide));
                };
            }
            
        }
    }
}
