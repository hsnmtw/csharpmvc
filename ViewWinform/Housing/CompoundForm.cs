using ControllerLibrary.Common;
using ControllerLibrary.Housing;
using ModelLibrary.Common;
using ModelLibrary.Housing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewWinform.Common;

namespace ViewWinform.Housing.Compounds {
    public partial class CompoundForm : SingleForm {
        public CompoundForm() {
            InitializeComponent();
        }

        public BaseController Controller => ControllersFactory.GetController(Entities.Compound);
        private CompoundModel model = new CompoundModel();

        public CompoundModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);
            }
        }
        public override void UpdateModel() { var _ = Model; }

        private void CompoundFormLoad1(object sender, EventArgs e) {
            Utils.FormsHelper.BindViewToModel(this,ref this.model);
        }

        private void CompoundNameLookupButtonLookUpSelected(object sender, EventArgs e) {
            this.Model = (CompoundModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }

        private void LookUpButton1Load(object sender, EventArgs e) {

        }
    }
}
