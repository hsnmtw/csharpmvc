using MVCWinform.Tools;
using MVCWinform.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MVCWinform.Common {
    public class SingleForm : Form, ISingleForm {

        public SingleForm() {
            InitializeComponent();
            if (Site != null && Site.DesignMode) return;            
        }

        public void PerformAction(string action) {
            try {
                var buttons = this.Controls.Find($"btn{action}", true).OfType<Button>();
                if (buttons.Count() == 0) return;
                buttons.First().PerformClick();
            } catch { }
        }

        public virtual void UpdateModel() { }

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleForm));
            this.SuspendLayout();
            // 
            // SingleForm
            // 
            resources.ApplyResources(this, "$this");
            this.Name = "SingleForm";
            this.Load += new System.EventHandler(this.SingleForm_Load);
            this.ResumeLayout(false);

        }

        private void SingleForm_Load(object sender, EventArgs e) {
            if (Site != null && Site.DesignMode) return;
            this.MdiParent = MainView.Instance;
            if (DictionaryController.LanguageState == LanguageState.Arabic) {
                FormsHelper.ApplyLanguageLocalization(this);
            }
        }
    }
}
