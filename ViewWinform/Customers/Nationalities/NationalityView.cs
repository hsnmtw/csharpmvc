using ControllerLibrary.Customers;
using ModelLibrary.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinform.Customers.Nationalities {
    public partial class NationalityView : Common.CommonView {

        private Common.MVCAdaptor<NationalityController, NationalityModel> adaptor;

        public NationalityView() {
            InitializeComponent();
            this.adaptor = new Common.MVCAdaptor<NationalityController, NationalityModel>();
            this.adaptor.Requery();
            this.TotalRecords = this.adaptor.Count;
            this.SetRecordPosition(1);
        }

        private void NationalityView_OnRecordOperationInvoked(Common.RecordOperation operation) {
            NationalityModel model = this.nationalityFormView1.model;
            switch (operation) {
                case Common.RecordOperation.Save:
                    if (model.Id == null || model.Id.Equals("")) {
                        adaptor.Controller.insert(model);
                        adaptor.Requery();
                        TotalRecords = adaptor.Count;
                        SetRecordPosition(TotalRecords);
                    } else {
                        adaptor.Controller.update(model);
                    }
                    Utils.FormsHelper.successMessage("saved");
                    break;
                case Common.RecordOperation.Delete:
                    adaptor.Controller.delete(model);
                    adaptor.Requery();
                    TotalRecords = adaptor.Count;
                    SetRecordPosition(Position > 1 ? Position - 1 : 1);
                    Utils.FormsHelper.successMessage("deleted");
                    break;
                case Common.RecordOperation.New:
                    this.nationalityFormView1.model = new NationalityModel();
                    break;
                case Common.RecordOperation.Table:
                    Utils.FormsHelper.showView(this.MdiParent, new NationalityListView());
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void NationalityView_OnRecordPositionChanged(int index) {
            this.nationalityFormView1.model = adaptor[index];
        }
    }
}
