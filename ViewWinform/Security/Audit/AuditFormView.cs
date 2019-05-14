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

namespace ViewWinform.Security.Audit {
    public partial class AuditFormView : UserControl , BaseView<AuditModel> {
        public AuditFormView() {
            InitializeComponent();
            Utils.FormsHelper.registerEnterAsTab(this);

        }
        private AuditModel _model;
        public AuditModel model {
            get {
                return _model;
            }
            set {
                _model = value;

                Id_TextBox.Text = _model == null ? "" : _model.Id.ToString();
                Event_Comments_TextBox.Text = _model == null ? "" : _model.Event_Comments;
                Event_Date_TextBox.Text = _model == null ? "" : _model.Event_Date.ToString("yyyy-MM-dd HH:mm:ss");
                User_Name_TextBox.Text = _model == null ? "" : _model.User_Name;
            }
        }
    }
}
