﻿using System;
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

namespace ViewWinform.Common {



    public partial class LookUpButton : UserControl {

        public const string ARROW = "↓";

        [Category("(Lookup)")]
        [Description("This event is fired after the user selects an item from the lookup form.")]
        public event EventHandler OnLookUpSelected;

        private string valueFromLookup;
        public string ValueFromLookup => valueFromLookup;


        private BaseController _controller = null;



        public LookUpButton() {
            InitializeComponent();
            //this.AssociatedControl = null;
            this.button1.Text = ARROW;
            this.Font = new Font("Consolas", 10, FontStyle.Bold);
            this.ShowFieldsInLookUp = new List<string>();
            //this.button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e) {
            if(this._controller == null) {
                ControllersEnum num;
                Enum.TryParse<ControllersEnum>(this.Controller,out num);
                this._controller = ControllersFactory.GetController(num);
            }

            LookUpForm lookup;

            lookup = new Common.LookUpForm(this._controller.GetTable(),this.ShowFieldsInLookUp.ToArray());
            
            if (lookup.ShowDialog() == DialogResult.OK) {
                valueFromLookup = lookup.SelectedValue[this.SelectedFieldFromLookUp];
                if (this.AssociatedControl != null && !"".Equals(this.AssociatedControl)) {
                    try {
                        this.Parent.Controls.Find(this.AssociatedControl,true)[0].Text = valueFromLookup;
                    }catch(Exception ex) {
                        Console.WriteLine($"Exception : {ex.Message}");
                    }
                }
                if (this.OnLookUpSelected != null) {
                    this.OnLookUpSelected(sender, new LookupEventArgs(valueFromLookup));
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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [MergableProperty(false)]
        public string Controller { get; set; }

        public override string Text { get => button1.Text; set => button1.Text = value; }
    }
}