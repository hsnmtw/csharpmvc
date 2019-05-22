using ControllerLibrary.Common;
using ControllerLibrary.Customers;
using ModelLibrary.Common;
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
using ViewWinform.Common;

namespace ViewWinform.Customers.Nationalities {
    public partial class NationalityForm : SingleForm {

        public NationalityForm() {
            InitializeComponent();
        }


        public BaseController Controller => ControllersFactory.GetController(Entities.Nationality);
        private NationalityModel model = new NationalityModel();


        public NationalityModel Model{
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtNationalityCode.Select();
                this.txtNationalityCode.Focus();

            }
        }
        public override void UpdateModel() { var _ = Model; }


        private void NationalityFormLoad(object sender, EventArgs e) {
            Utils.FormsHelper.BindViewToModel(this,ref this.model);

            Label[] fieldsmarkers = { lblMetaDataNationalityArabic,lblMetaDataNationalityCode,lblMetaDataNationalityDesc };

            foreach(var required in fieldsmarkers) {
                string field = required.Name.Replace("lblMetaData", "");
                if (this.Controller.GetMetaData().GetRequiredFields.Contains(field)) {
                    required.Text = "*";
                } else {
                    required.Text = "";
                }
            }
        }

        private void NationalityCodeTextBoxLookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtNationalityCode.Text = selected;
            
            this.Model = (NationalityModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }
    }
}
