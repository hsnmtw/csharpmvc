using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCHIS.Security {
    public class PermissionsHelper<M,C> where M:BaseModel where C:IDBController {
        public PermissionsHelper(BaseView<M,C> view) {
            if(view==null) throw new ArgumentException("view cannot be null");
            //if(model==default) throw new ArgumentException("model cannot be null");
            var ecn = DBControllersFactory.GetController(MODELS.Entitlement);
            var pec = DBControllersFactory.GetController(MODELS.ProfileEntitlement);
            var pc  = DBControllersFactory.GetController(MODELS.Profile);

            var usr = Session.Instance.CurrentUser;

            if (usr == null) return;
            //var mdl = view?.GetType().GetCustomAttributes().OfType<ForModelAttribute>().FirstOrDefault();
            //if (mdl == null) return;

            var ent = ecn.Find(new EntitlementModel() { EntityName = $"{typeof(M).Name}".Replace("Model","") }, "EntityName");
            if (ent == null) return;
            
            var pen = pec.Find(new ProfileEntitlementModel() {
                ProfileId = usr.ProfileId ,
                EntitlementId = ent.Id
            }, "ProfileId", "EntitlementId");

            view.NewButtonEnabled = pen.AllowCreate;
            view.SaveButtonEnabled = pen.AllowUpdate;
            view.DeleteButtonEnabled = pen.AllowDelete;

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
