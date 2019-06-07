using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
using MVCHIS.Common;

namespace MVCHIS.Utils {
    public partial class FixedWidthListBox : UserControl {
        private DataTable source;
        private bool columnsInitialized;
        [Category("(PickList)")]
        [Description("Shown columns.")]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [MergableProperty(false)]
        [Localizable(true)]
        public List<string> ShownColumns { get; set; }
        public DataTable DataSource {
            get { return source; }
            set { source = value; if (DesignMode||(Site!=null && Site.DesignMode)) return; }
        }
        private string filter;
        [Category("(PickList)")]
        [Description("Filter")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Filter {
            get { return filter; }
            set { filter = value; if (DesignMode||(Site!=null && Site.DesignMode)) return; }
        }

        [Category("(PickList)")]
        [Description("The selected fields to be shown in the lookup.")]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [MergableProperty(false)]
        [Localizable(true)]
        public ListBox.ObjectCollection Items => lstView.Items;

        public override string Text => lstView.Text; 

        public FixedWidthListBox() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return; //();
            ShownColumns = new List<string>();
            if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        public int SelectedIndex => lstView.SelectedIndex;

        public int[] ColumnsWidths { get; private set; }

        public void Requery() {
            
            if (ShownColumns == null || ShownColumns.Count() == 0) {
                ShownColumns = (from DataColumn column in source.Columns select column.ColumnName).ToList();
            }
            lstView.Items.Clear();
            if (source.Rows.Count == 0) return;
            var table = source;
            
            string[] sb = new string[ShownColumns.Count()];
            
            try {
                if (table?.Rows.Count > 0) {
                    var view = new DataView(table);
                    view.RowFilter = Filter;// string.Format("{0} Like '%{1}%'", ShownColumns[0], this.lblSearch.Text);
                    view.Sort = $"{ShownColumns[0]} ASC";
                    table = view.ToTable(false, ShownColumns.ToArray());
                    //var widths = (from row)
                }
            } catch (Exception e) {
                FormsHelper.Error(e.Message);
            }
            

            //var table = view.ToTable(false, ShownColumns.ToArray());
            if (!columnsInitialized) {
                ColumnsWidths = new int[ShownColumns.Count()];

                //var widths = (from row in table.Rows select)

                for (int j = 0; j < ColumnsWidths.Length; j++) {
                    ColumnsWidths[j] = Math.Max(ColumnsWidths[j], ShownColumns[j].Length);
                }
                
                for (int j = 0; j < ColumnsWidths.Length; j++) {
                    sb[j] = string.Format(string.Join("", " {0,-", ColumnsWidths[j], "} "), ShownColumns[j]);
                }
                this.lblRowHeader.Text = string.Join("|", sb);
                columnsInitialized = true;
            }

            for (int i = 0; i < table.Rows.Count; i++) {
                for (int j = 0; j < ShownColumns.Count; j++) {
                    sb[j] = (string.Format(" {0,-" + ColumnsWidths[j] + "} ", Formatted(table.Rows[i][ShownColumns[j]])));
                }
                this.lstView.Items.Add(string.Join("|", sb));
            }
            if (this.lstView.Items.Count > 0) this.lstView.SelectedIndex = 0;
        }

        private string Formatted(object v) {
            if (v?.GetType() == typeof(bool)) {
                return Convert.ToBoolean(v) ? FormsHelper.TICK : "";
            }
            if (v?.GetType() == typeof(DateTime)) {
                return ((DateTime)v).ToString(FormsHelper.DATE_FORMAT);
            }
            return Convert.ToString(v);
        }

        private void LstView_KeyDown(object sender, KeyEventArgs e) {
            this.OnKeyDown(e);
        }

        private void LstView_KeyPress(object sender, KeyPressEventArgs e) {
            this.OnKeyPress(e);
        }
    }
}
