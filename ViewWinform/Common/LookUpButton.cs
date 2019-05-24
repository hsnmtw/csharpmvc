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

        private string valueFromLookup, descFromLookup;
        public string ValueFromLookup => valueFromLookup;
        private LookUpForm lookup;
        private Control controlValu = null,controlDesc = null;
        private IDBController controller = null;

        public LookUpButton() {
            InitializeComponent(); if (DesignMode) return;
            this.button1.Text = ARROW;
            this.Font = new Font("Consolas", 10, FontStyle.Bold);
            this.ShowFieldsInLookUp = new List<string>();
            //this.button1.Click += Button1Click;
            //this.AssociatedControl = null;
        }

        private void Button1Click(object sender, EventArgs e) {
            
            if (lookup.ShowDialog() == DialogResult.OK) {
                valueFromLookup = lookup.SelectedValue;
                descFromLookup = lookup.SelectedDescription;
                if (this.controlValu != null) {
                    controlValu.Text = $"{valueFromLookup}".Trim();
                    SendKeys.Send("\t");
                    if (this.controlDesc != null) {
                        controlDesc.Text = $"{descFromLookup}".Trim();
                    }
                }
                if (this.LookUpSelected != null) {
                    this.LookUpSelected(sender, new LookupEventArgs(valueFromLookup, descFromLookup));
                }
            }
        }

        [Category("(Lookup)")]
        [Description("Associated control/textbox.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string AssociatedControl { get; set; }

        [Category("(Lookup)")]
        [Description("Associated control/textbox for description.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string AssociatedControlDescription { get; set; }

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
            
            if (DesignMode) return;
            if (this.controller == null) {
                Entities num;
                
                if (!Enum.TryParse<Entities>(this.Controller, out num)) {
                    throw new ArgumentException($"Controller: {this.Controller} cannot be found");
                }
                this.controller = DBControllersFactory.GetController(num);
            }

            if (this.ShowFieldsInLookUp.Count == 0) {
                this.ShowFieldsInLookUp.AddRange(this.controller.GetMetaData().GetUniqueKeyFields);
            }

            lookup = new Common.LookUpForm(this.controller, this.ShowFieldsInLookUp.ToArray());

            if (this.AssociatedControl != null && !"".Equals(this.AssociatedControl)) {
                var vControlsValu = this.Parent.Controls.Find(this.AssociatedControl, true);
                controlValu = vControlsValu.Count() == 0 ? null : vControlsValu.First();
            }

            if (this.AssociatedControlDescription != null && !"".Equals(this.AssociatedControlDescription)) {
                var vControlsDesc = this.Parent.Controls.Find(this.AssociatedControlDescription, true);
                controlDesc = vControlsDesc.Count() == 0 ? null : vControlsDesc.First();
                if (controlValu != null) {
                    controlValu.TextChanged += (sndr, ea) => controlDesc.Text = "-";
                }
            }

            if (controlValu!=null && ((TextBoxBase)controlValu).ReadOnly) {
                controlValu.KeyPress += delegate (object s, KeyPressEventArgs ea) {
                    lookup.SearchText = $"{ea.KeyChar}";
                    Button1Click(null, null);
                };
            }
        }
    }
}
