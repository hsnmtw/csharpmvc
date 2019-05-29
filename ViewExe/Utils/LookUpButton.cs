using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;

namespace MVCHIS.Common {


    [DefaultEvent("LookUpSelected")]
    public partial class LookUpButton : UserControl {

        public const string ARROW = "↓";

        [Category("(Lookup)")]
        [Description("This event is fired after the user selects an item from the lookup form.")]
        public event EventHandler LookUpSelected;

        public string ValueFromLookup { get; private set; }
        private LookUpForm lookup;
        private Control controlValu = null;
        private IDBController controller = null;

        public LookUpButton() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            this.button1.Text = ARROW;
            this.Font = new Font("Consolas", 10, FontStyle.Bold);
            this.ShowFieldsInLookUp = new List<string>();
            //this.button1.Click += Button1Click;
            //this.AssociatedControl = null;
        }

        private void Button1Click(object sender, EventArgs e) {
            if (!isInitialized) init();
            lookup = new Common.LookUpForm(this.controller.GetData<BaseModel>(), this.ShowFieldsInLookUp.ToArray());
            lookup.SelectedValueIndex = this.SelectedValueIndex;
            lookup.MdiParent = MainView.Instance;
            lookup.FormClosed += (s, ee) => {
                ValueFromLookup = lookup.SelectedValue;
                if (this.controlValu != null) {
                    controlValu.Text = $"{ValueFromLookup}".Trim();
                    //SendKeys.Send("\t");
                }
                this.LookUpSelected?.Invoke(sender, new LookupEventArgs(ValueFromLookup));
            };
            lookup.Show();
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
        [Description("The controller used to populate values in the lookup.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Controller { get; set; }

        [Category("(Lookup)")]
        [Description("The selected value index from shown columns.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public int SelectedValueIndex { get; set; }

        public override string Text { get => button1.Text; set => button1.Text = value; }

        private void LookUpButtonLoad(object sender, EventArgs e) {
            init();
        }

        private bool isInitialized = false;

        private void init() {
            if(Site != null && Site.DesignMode || isInitialized) return;

            if (this.controller == null) {
                MODELS num;

                if (!Enum.TryParse<MODELS>(this.Controller, out num)) {
                    throw new ArgumentException($"Controller: {this.Controller} cannot be found");
                }
                this.controller = DBControllersFactory.GetController(num);
            }

            if (this.ShowFieldsInLookUp.Count == 0) {
                this.ShowFieldsInLookUp.AddRange(this.controller.GetMetaData().GetUniqueKeyFields);
            }




            if (this.AssociatedControl != null && !"".Equals(this.AssociatedControl)) {
                var vControlsValu = this.Parent.Controls.Find(this.AssociatedControl, true);
                controlValu = vControlsValu.Count() == 0 ? null : vControlsValu.First();
            }

            

            //if (controlValu != null && ((TextBoxBase)controlValu).ReadOnly) {
            //    controlValu.KeyPress += delegate (object s, KeyPressEventArgs ea) {
            //        lookup.SearchText = $"{ea.KeyChar}";
            //        Button1Click(null, null);
            //    };
            //}
            isInitialized = true;
        }
    }
}
