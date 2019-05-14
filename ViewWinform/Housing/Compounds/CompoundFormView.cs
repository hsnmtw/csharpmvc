using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLibrary.Housing;

namespace ViewWinform.Housing.Compounds {
    public partial class CompoundFormView : UserControl, BaseView<CompoundModel> {
        public CompoundFormView() {
            InitializeComponent();
        }

        private CompoundModel _model;
        public CompoundModel model {
            get {
                _model.Id = int.Parse(this.Id_TextBox.Text);
                _model.Compound_Name = this.Compound_Name_TextBox.Text;
                return _model;
            }
            set {
                _model = value;
                this.Id_TextBox.Text = _model == null ? "" : _model.Id.ToString();
                this.Compound_Name_TextBox.Text = _model == null ? "" : _model.Compound_Name;
            }
        }
    }
}
