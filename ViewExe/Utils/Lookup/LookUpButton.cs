﻿using MVCHIS.Utils;
using MVCHIS.Utils.Extensions;
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

        //public Action<object, EventArgs> OnLookupItemSelected; 

        public string ValueFromLookup { get; private set; }
        private LookupBox lookup;
        private Control controlValu = null;
        //private IController controller = null;

        public LookUpButton() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            button1.Text = ARROW;
            Font = new Font("Consolas", 10, FontStyle.Bold);
        }

        private void Button1Click(object sender, EventArgs e) {
            if (!isInitialized) init();
            lookup = new LookupBox(Source,ForeignKeys.Instance.GetLookUp(Source).ToDataTable());
            
            lookup.FormClosed += (s, ee) => {
                if (lookup.DialogResult != DialogResult.OK) return;
                ValueFromLookup = lookup.SelectedValue;
                if (controlValu != null && lookup.ValueHasBeenSelected) {
                    controlValu.Text = $"{ValueFromLookup}".Trim();
                    SendKeys.Send("\t");
                    LookUpSelected?.Invoke(sender, e);
                }
            };
            lookup.Show();
            FormsHelper.ApplyLanguageLocalization(lookup);
        }

        [Category("(Lookup)")]
        [Description("Associated control/textbox.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string AssociatedControl { get; set; }

        [Category("(Lookup)")]
        [Description("The name of the data source used to populate values in the lookup.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Source { get; set; }

        public override string Text { get => button1.Text; set => button1.Text = value; }

        private void LookUpButtonLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            if(!isInitialized) init();
        }

        private bool isInitialized = false;

        private void init() {
            if(Site != null && Site.DesignMode || isInitialized) return;

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