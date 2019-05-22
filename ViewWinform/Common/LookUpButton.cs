using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerLibrary.Common;
using System.Drawing.Design;
using ControllerLibrary.Customers;
using ControllerLibrary.Housing;
using ControllerLibrary.Security;
using ModelLibrary.Common;

namespace ViewWinform.Common {


    [DefaultEvent("LookUpSelected")]
    public partial class LookUpButton : UserControl {

        public const string ARROW = "↓";

        [Category("(Lookup)")]
        [Description("This event is fired after the user selects an item from the lookup form.")]
        public event EventHandler LookUpSelected;

        private string valueFromLookup;
        public string ValueFromLookup => valueFromLookup;
        private LookUpForm lookup;
        private Control control;
        private BaseController controller = null;

        public LookUpButton() {
            InitializeComponent();
            this.button1.Text = ARROW;
            this.Font = new Font("Consolas", 10, FontStyle.Bold);
            this.ShowFieldsInLookUp = new List<string>();
            //this.button1.Click += Button1Click;
            //this.AssociatedControl = null;
        }

        private void Button1Click(object sender, EventArgs e) {
            
            if (lookup.ShowDialog() == DialogResult.OK) {
                valueFromLookup = lookup.SelectedValue;//[this.SelectedFieldFromLookUp];
                if (this.AssociatedControl != null && !"".Equals(this.AssociatedControl)) {
                    try {
                        control.Text = $"{valueFromLookup}".Trim();
                        SendKeys.Send("\t");
                    } catch (Exception ex) {
                        Console.WriteLine($"Exception : {ex.Message}");
                    }
                }
                if (this.LookUpSelected != null) {
                    this.LookUpSelected(sender, new LookupEventArgs(valueFromLookup));
                }
            }
        }

        [Category("(Lookup)")]
        [Description("Associated control/textbox.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string AssociatedControl { get; set; }

        [Category("(Lookup)")]
        [Description("The selected fields to be shown in the lookup.")]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [MergableProperty(false)]
        [Localizable(true)]
        public List<string> ShowFieldsInLookUp { get; set; }

        [Category("(Lookup)")]
        [Description("The selected fields to be shown in the lookup.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public int SelectedFieldFromLookUp { get; set; }

        [Category("(Lookup)")]
        [Description("The controller used to populate values in the lookup.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Controller { get; set; }

        public override string Text { get => button1.Text; set => button1.Text = value; }

        private void LookUpButtonLoad(object sender, EventArgs e) {
            try {

                if (this.controller == null) {
                    Entities num;
                    Enum.TryParse<Entities>(this.Controller, out num);
                    this.controller = ControllersFactory.GetController(num);
                }

                if (this.ShowFieldsInLookUp.Count == 0) {
                    this.ShowFieldsInLookUp.AddRange(this.controller.GetMetaData().GetUniqueKeyFields);
                }

                lookup = new Common.LookUpForm(this.controller, this.ShowFieldsInLookUp.ToArray());

                control = this.Parent.Controls.Find(this.AssociatedControl, true).First();

                if (((TextBoxBase)control).ReadOnly) {
                    control.KeyPress += delegate (object s, KeyPressEventArgs ea) {
                        lookup.SearchText = $"{ea.KeyChar}";
                        Button1Click(null, null);
                    };
                }
            } catch (Exception ex) {
                Console.WriteLine($"Exception : {ex.Message}");
            }
        }
    }
}
