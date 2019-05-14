using ControllerLibrary.Housing;
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

namespace ViewWinform.Housing.Compounds {
    public partial class CompoundView : Common.CommonView {

        private Common.MVCAdaptor<CompoundController, CompoundModel> adaptor;

        public CompoundView() {
            InitializeComponent();
            this.adaptor = new Common.MVCAdaptor<CompoundController, CompoundModel>();
            this.adaptor.Requery();
            this.TotalRecords = adaptor.Count;
            this.SetRecordPosition(1);
        }

        private void CompoundView_OnRecordPositionChanged(int index) {
            this.compoundFormView1.model = adaptor[index];
        }

        private void CompoundView_OnSaveInvoked() {
            this.adaptor.Controller.save(this.compoundFormView1.model);
            this.adaptor.Requery();
            this.TotalRecords = adaptor.Count;
            this.SetRecordPosition(adaptor.Count);
        }

        private void CompoundView_OnTableInvoked() {

        }

        private void CompoundView_OnDeleteInvoked() {
            this.adaptor.Controller.delete(this.compoundFormView1.model);
            this.adaptor.Requery();
            this.TotalRecords = adaptor.Count;
            this.SetRecordPosition(this.Position-1);
        }

        private void CompoundView_OnNewInvoked() {
            this.compoundFormView1.model = new CompoundModel();
        }
    }
}
