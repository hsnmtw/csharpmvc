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
        private LookUpForm2 lookup;
        private Control controlValu = null;
        private IController controller = null;

        public LookUpButton() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            button1.Text = ARROW;
            Font = new Font("Consolas", 10, FontStyle.Bold);
            ShowFieldsInLookUp = new List<string>();
            //this.button1.Click += Button1Click;
            //this.AssociatedControl = null;
        }

        private void Button1Click(object sender, EventArgs e) {
            if (!isInitialized) init();
            lookup = new LookUpForm2(controller.GetData(), ShowFieldsInLookUp.ToArray());
            lookup.SelectedValueIndex = SelectedValueIndex;           
            lookup.FormClosed += (s, ee) => {
                if (lookup.DialogResult != DialogResult.OK) return;
                ValueFromLookup = lookup.SelectedValue;
                if (controlValu != null && lookup.ValueHasBeenSelected) {
                    controlValu.Text = $"{ValueFromLookup}".Trim();
                    SendKeys.Send("\t");
                    LookUpSelected?.Invoke(sender, new LookupEventArgs(ValueFromLookup));
                }
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

        private void LookUpButtonLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
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
                this.controller = (IController)DBControllersFactory.GetController(num);
            }

            if (this.ShowFieldsInLookUp.Count == 0) {
                this.ShowFieldsInLookUp.AddRange(this.controller.GetMetaData().UniqueKeyFields.FirstOrDefault());
            }




            if (this.AssociatedControl != null && !"".Equals(this.AssociatedControl)) {
                var vControlsValu = this.Parent.Controls.Find(this.AssociatedControl, true);
                controlValu = vControlsValu.Count() == 0 ? null : vControlsValu.First();
            }



            if (controlValu != null && ((TextBoxBase)controlValu).ReadOnly) {
                controlValu.KeyPress += delegate (object s, KeyPressEventArgs ea) {
                    if (lookup == null || !lookup.Visible) button1.PerformClick();
                    lookup.SearchText = $"{ea.KeyChar}";
                };
            }
            isInitialized = true;
        }
    }
}
