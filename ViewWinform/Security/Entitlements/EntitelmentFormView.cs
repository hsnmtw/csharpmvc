using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLibrary.Security;
using ControllerLibrary.Security;

namespace ViewWinform.Security.Entitlements
{
    public partial class EntitelmentFormView : UserControl, BaseView<EntitlementModel>
    {

        private EntitlementModel _model = new EntitlementModel();
        public EntitlementModel model {
            get {
                _model.Id = int.Parse(this.Id_TextBox.Text);
                _model.Entitlement_Name = this.Entitlement_Name_TextBox.Text;
                return _model;
            }
            set {
                _model = value;
                this.Id_TextBox.Text = _model == null ? "" : _model.Id.ToString();
                this.Entitlement_Name_TextBox.Text = _model == null ? "" : _model.Entitlement_Name;
                //this.auditView1.setModel(_model);
            }
        }

        public EntitelmentFormView()
        {
            InitializeComponent();
            Utils.FormsHelper.registerEnterAsTab(this);
        }
    }
}
