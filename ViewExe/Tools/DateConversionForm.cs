using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCHIS.Common;
using System.Globalization;
using MVCHIS.Utils;

namespace MVCHIS.Tools {
    public partial class DateConversionForm : DateConversionView {

        
        public DateConversionForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;
        }

        private void BtnGO_Click(object sender, EventArgs e) {
            if (int.TryParse(txtYear.Text, out int year)) {
                SupportedCalendar calendar = rdoHijri.Checked ? SupportedCalendar.HIJRI : SupportedCalendar.GREGORIAN;
                
                this.listViewControl1.LoadData("", Controller.GetYearDates(year,calendar), "Id", "GregorianDate", "HijriYear", "HijriMonth", "HijriDay");
            }
        }



        private void DateConversionForm_Load(object sender, EventArgs e) {
            
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            if (int.TryParse(txtYear.Text, out int y)) {
                SupportedCalendar calendar = rdoHijri.Checked ? SupportedCalendar.HIJRI : SupportedCalendar.GREGORIAN;
                Controller.Delete(y, calendar);
                listViewControl1.Items.Clear();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e) {

        }

        private void ListViewControl1_DoubleClick(object sender, EventArgs e) {
            if (listViewControl1.SelectedIndices.Count < 1) return;
            int row = listViewControl1.SelectedIndices[0];
            int id = int.Parse(listViewControl1.Items[row].Text);
            var dcuc = new DateConversionUC() {
                Dock = DockStyle.Fill,
                Model = Controller.Find(new DateConversionModel() { Id = id }, "Id")
            };
            var form = new Form() { Width = 430, Height = 430, Text = "Date Conversion" };
            form.Controls.Add(dcuc);
            dcuc.DeleteButton.Visible = false;
            dcuc.NewButton.Visible = false;
            form.Show();
            FormsHelper.ApplyLanguageLocalization(dcuc);
            dcuc.AfterSave += delegate (bool status) {
                if (status) {
                    listViewControl1.Items[row].SubItems[2].Text = dcuc.Model.HijriYear.ToString ();
                    listViewControl1.Items[row].SubItems[3].Text = dcuc.Model.HijriMonth.ToString();
                    listViewControl1.Items[row].SubItems[4].Text = dcuc.Model.HijriDay.ToString  ();
                }
            };
        }
    }
}
