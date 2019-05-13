using ControllerLibrary.Security;
using ViewWinform.Common;
using ModelLibrary.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinform.Security.Profiles {
    public partial class ProfileView : CommonView {

        private MVCAdaptor<ProfileController, ProfileModel> adaptor;

        public ProfileView() {
            InitializeComponent();
            this.adaptor = new MVCAdaptor<ProfileController, ProfileModel>();
            this.adaptor.Requery();
            this.TotalRecords = adaptor.Count;
            this.SetRecordPosition(1);
        }

        private void PorfileView_OnRecordOperationInvoked(RecordOperation operation) {
            ProfileModel model = this.profilesFormView1.model;
            switch (operation) {
                case RecordOperation.Delete:
                    adaptor.Controller.delete(model);
                    adaptor.Requery();
                    this.SetRecordPosition(1);
                    this.TotalRecords = adaptor.Count;
                    break;
                case RecordOperation.Save:
                    adaptor.Controller.save(model);
                    Profile_EntitlementsController pec = new Profile_EntitlementsController();
                    pec.clearEntitlementForProfile(model.Profile_Name);
                    List<string> list = this.profilesFormView1.getSelectedEntitlements();
                    pec.updateEntitlementForProfile(model.Profile_Name, list);
                    adaptor.Requery();
                    this.SetRecordPosition(1);
                    this.TotalRecords = this.adaptor.Count;
                    break;
                case RecordOperation.New:
                    this.profilesFormView1.model = new ProfileModel();
                    break;
                case RecordOperation.Table:
                    
                    break;
            }
        }

        private void PorfileView_OnRecordPositionChanged(int index) {
            this.profilesFormView1.model = adaptor[index];
        }
    }
}
