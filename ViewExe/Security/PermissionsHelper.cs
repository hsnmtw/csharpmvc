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
            var ecn = DBControllersFactory.GetController(MVCHIS.Common.MODELS.Entitlement);
            var pec = DBControllersFactory.GetController(MVCHIS.Common.MODELS.ProfileEntitlement);
            var usr = Session.Instance.CurrentUser;

            var mdl = view?.GetType().GetCustomAttributes().OfType<ForModelAttribute>().FirstOrDefault();
            if (mdl == null) return;

            var ent = ecn.Find(new EntitlementModel() { EntityName = $"{mdl.Model}" }, "EntityName");
            if (ent == null) return;
            
            var pen = pec.Find(new ProfileEntitlementsModel() {
                ProfileName = usr.ProfileName,
                EntitlementName = ent.EntitlementName
            }, "ProfileName", "EntitlementName");

            view.NewButtonEnabled = pen.AllowCreate;
            view.SaveButtonEnabled = pen.AllowUpdate;
            view.DeleteButtonEnabled = pen.AllowDelete;

            if (!pen.AllowRead) {
                FormsHelper.Error($"You don't have enough permissions to open {view}.");
                view.GotFocus += (x, y) => {
                    view.Enabled = false;
                    view.BeginInvoke(new MethodInvoker(view.Close));
                };
            }
            
        }
    }
}
