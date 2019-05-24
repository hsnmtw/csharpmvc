using ControllerLibrary.Common;
using ControllerLibrary.Housing;
using ControllerLibrary.Tools;
using ModelLibrary.Common;
using ModelLibrary.Tools;
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

namespace ViewWinform.Tools {
    public partial class DictionaryForm : SingleForm {

        public IDBController Controller;
        private IDBController dictionaryController;
        private DictionaryModel model;

        public DictionaryForm() : base() {
            InitializeComponent(); if (DesignMode) return;
            dictionaryController = DBControllersFactory.GetController(Entities.Dictionary);
            Controller = DBControllersFactory.GetController(Entities.Dictionary);
            model = new DictionaryModel();
            Utils.FormsHelper.BindViewToModel(this, ref this.model);
        }

        public DictionaryModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtWordInEnglish.Focus();
                this.txtWordInEnglish.Select();
            }
        }
        public override void UpdateModel() { var _ = Model; }

        private void DictionaryFormLoad1(object sender, EventArgs e) {

        }

        private void DictionaryNameLookupButtonLookUpSelected(object sender, EventArgs e) {
            this.Model = (DictionaryModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }
    }
}
