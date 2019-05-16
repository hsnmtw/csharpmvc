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

namespace ViewWinform.Common {



    public partial class LookUpField : UserControl {
        public delegate void LookUpSelectedHandler(string value);
        public event LookUpSelectedHandler OnLookUpSelected;
        public event EventHandler ValueChanged;

        private BaseController _controller = null;

        public static Dictionary<DBControllers, Type> controllerMap = new Dictionary<DBControllers, Type>() {
            [DBControllers.Nationality] = typeof(NationalityController),
            [DBControllers.Compound]    = typeof(CompoundController),
            [DBControllers.User]        = typeof(UserController),
            [DBControllers.Entitlement] = typeof(EntitlementController),
            [DBControllers.Profile]     = typeof(ProfileController)
        };

        public LookUpField() {
            InitializeComponent();
            this.ShowFieldsInLookUp = new List<string>();
        }

        private void Button1_Click(object sender, EventArgs e) {
            if(this._controller == null) {
                this._controller = (BaseController)Activator.CreateInstance(controllerMap[this.Controller]);
            }
            if(this.ShowFieldsInLookUp == null || this.ShowFieldsInLookUp.Count() == 0) {
                return;
            }

            LookUp lookup = new Common.LookUp(this._controller.selectModelsAsDataTable(),this.ShowFieldsInLookUp.ToArray());
            
            if (lookup.ShowDialog() == DialogResult.OK) {
                this.Text = lookup.SelectedValue[this.SelectedFieldFromLookUp];
                if (this.OnLookUpSelected != null) this.OnLookUpSelected(this.Text);
            }
        }


        [Category("Appearance")]
        [Description("The selected fields to be shown in the lookup.")]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [MergableProperty(false)]
        [Localizable(true)]
        public List<string> ShowFieldsInLookUp { get; set; }

        [Category("Appearance")]
        [Description("The selected fields to be shown in the lookup.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public int SelectedFieldFromLookUp { get; set; }


        [Category("Appearance")]
        [Description("The controller used to populate values in the lookup.")]
        [Browsable(true),DefaultValue(DBControllers.Compound), EditorBrowsable(EditorBrowsableState.Always)]
        public DBControllers Controller { get; set; }



        [Category("Appearance")]
        [Description("The text displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }

        [Category("Appearance")]
        [Description("The back color displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color TextBackColor {
            get { return this.textBox1.BackColor; }
            set { this.textBox1.BackColor = value; }
        }

        private void LookUpField_SizeChanged(object sender, EventArgs e) {
            if(this.Height>22) this.Height = 22;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) {
            if (this.ValueChanged != null) this.ValueChanged(sender, e);
        }
    }
}
