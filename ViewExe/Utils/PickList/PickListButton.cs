using MVCHIS.Utils;
using MVCHIS.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;

namespace MVCHIS.Common {


    [DefaultEvent("PickListItemSelected")]
    [DefaultProperty("Source")]
    public class PickListButton : Button {

        public const string ARROW = "↓";

        [Category("(PickList)")]
        [Description("This event is fired after the user selects an item from the lookup form.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public event Action<int> PickListItemSelected;

        [Category("(PickList)")]
        [Description("The name of the data source used to populate values in the lookup.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Source { get; set; }

        private PickListBox picklistboxForm;

        public PickListButton() {
            if (DesignMode||(Site!=null && Site.DesignMode)) return;
            Text = ARROW;
            Font = new Font("Consolas", 10, FontStyle.Bold);
            //FlatStyle = FlatStyle.Flat;
            //TextAlign = ContentAlignment.TopCenter;
            //BackColor = Color.Cornsilk;
            //ForeColor = Color.DarkGreen;
            Click += PickListButton_Click;
        }

        private void PickListButton_Click(object sender, EventArgs e) {
            picklistboxForm = new PickListBox(Source, DBControllersFactory.GetController(Source).GetKeysAndValues().ToDataTable() );
            picklistboxForm.FormClosed += (s, ee) => {
                if (picklistboxForm.DialogResult != DialogResult.OK) return;
                SendKeys.Send("\t");
                PickListItemSelected?.Invoke(picklistboxForm.SelectedValue.ToInteger());                
            };
            picklistboxForm.Show();
            FormsHelper.ApplyLanguageLocalization(picklistboxForm);
        }

        private void PickListButtonLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        internal void SetFilter(char keyChar) {
            picklistboxForm.Filter = $"{keyChar}";
        }
    }
}
