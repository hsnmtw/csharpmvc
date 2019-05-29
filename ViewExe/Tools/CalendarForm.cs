using MVCHIS.Common;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MVCHIS.Tools {
    public partial class CalendarForm: Form {

        public int MinYear { get; set; }
        public int MaxYear { get; set; }
        private int year, month;
        public int Year => year;
        public int Month => month;

        public int Day {
            get {

                return -1;
            }
        }

        public DateTime Date => new DateTime(Year, Month, Day);

        public CalendarController Controller;

        public CalendarForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            MinYear = 2018;
            MaxYear = 2020;
            Controller = new CalendarController();
        }

        private void CalendarForm_Load(object sender, EventArgs e) {
            //return;
            if(Site != null && Site.DesignMode) return;
            
            //this.dataGridView1.AutoGenerateColumns = false;
            
            this.cmbYear.Items.Clear();
            this.cmbMonth.Items.Clear();

            for (int y = MinYear; y < MaxYear; y++) {
                this.cmbYear.Items.Add($"{y}");
            }

            for(int m = 1; m <= 12; m++) {
                this.cmbMonth.Items.Add($"{m}");
            }

            this.cmbYear.Text = $"{DateTime.Now.Year}";
            this.cmbMonth.Text = $"{DateTime.Now.Month}";
            //ShowCalendar();
        }

        private void ShowCalendar() {
            int.TryParse(this.cmbYear.Text, out year);
            int.TryParse(this.cmbMonth.Text, out month);
            if (year == 0 || month == 0) return;
            //this.dataGridView1.DataSource = Controller.GetMonthDays(Year, Month);
            object[][] calendar = Controller.GetMonthCalendar(year, month);
            for(int w = 0; w < 6; w++) {
                for(int d = 0; d < 7; d++) {
                    this.Controls.Find($"lbl{w}_{d}", false).First().Text = $"{calendar[w][d]}";
                }
            }
        }


        private void BtnOK_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CmbYear_SelectedIndexChanged(object sender, EventArgs e) {
            ShowCalendar();
        }
    }
}
