using MVCHIS.Common;
using MVCHIS.Security;
using MVCHIS.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web {
    public partial class Main : System.Web.UI.Page {
        private ProfileEntitlementController CntrlPE;
        private UserController CntrlUS;

        protected void Page_Load(object sender, EventArgs e) {
            CntrlUS = DBControllersFactory.User();
            CntrlPE = DBControllersFactory.ProfileEntitlement();
            MVCHIS.Common.MVCHISSession.Instance.Initialize();
            Login1.Visible = MVCHISSession.Instance.CurrentUser == null;
            //DictionaryUC1.Visible = false;
            Login1.GoClicked += (um) => {
                UserController uc = DBControllersFactory.User();
                um = uc.Autheniticate(um);
                if (um == null) {
                    ScriptManager.RegisterStartupScript(this,GetType(),"error","alert('Login denied')",true);
                } else {
                    WhenAuthenticated(um);
                }
            };
        }

        private void WhenAuthenticated(UserModel model) {
            MVCHISSession.Instance.CurrentUser = model;
            Login1.Visible = false;
            DictionaryUC1.Visible = false;

            string prev = "";
            TreeNode node = null;
            foreach (var stuple in CntrlUS.GetMenu(model).OrderBy(x => x.Item1)) {
                var egn = stuple.Item1;
                if (prev.Equals(egn) == false) {
                    node = new TreeNode(egn);
                    TreeView2.Nodes.Add(node);
                    prev = egn;
                }
                TreeNode child = new TreeNode(stuple.Item2);
                node.ChildNodes.Add(child);
            }

            MVCHISSession.Instance.UserEntitlements = CntrlPE.Read(new ProfileEntitlementModel { ProfileId = model.ProfileId }, "ProfileId");

        }

        protected void TreeView2_SelectedNodeChanged(object sender, EventArgs e) {
            TreeNode node = TreeView2.SelectedNode;
            if (node.Text.Equals("Word")) {
                DictionaryUC1.Visible = true;
                DictionaryUC1.Model = new WordModel();
            }
        }
    }
}