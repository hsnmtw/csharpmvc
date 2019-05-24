using ControllerLibrary.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinform.Tools {
    public partial class CalendarForm : Form {

        public int MinYear { get; set; }
        public int MaxYear { get; set; }
        private int year, month;
        public int Year => year;
        public int Month => month;

        public int Day {
            get {
                if(dataGridView1.SelectedCells.Count > 0) {
                    var cellvalue = this.dataGridView1.SelectedCells[0].Value;
                    if(cellvalue!=null && !"".Equals($"{cellvalue}")){
                        return int.Parse($"{cellvalue}");
                    }
                }
                return -1;
            }
        }

        public DateTime Date => new DateTime(Year, Month, Day);

        public CalendarController Controller;

        public CalendarForm() {
            InitializeComponent(); if (DesignMode) return;
            MinYear = 1960;
            MaxYear = 2029;
            Controller = new CalendarController();
        }

        private void CalendarForm_Load(object sender, EventArgs e) {
            if (DesignMode) return;
            
            this.dataGridView1.AutoGenerateColumns = false;
            
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
            this.dataGridView1.DataSource = Controller.GetMonthDays(Year, Month);
        }

        private void DataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e) {
            if (e.Cell == null || e.StateChanged != DataGridViewElementStates.Selected) return;
            if (e.Cell.Value == null || "".Equals($"{e.Cell.Value}")) {
                e.Cell.Selected = false;
                foreach(DataGridViewCell cell in dataGridView1.Rows[0].Cells) {
                    if(!(cell.Value == null || "".Equals($"{cell.Value}"))) {
                        cell.Selected = true;
                        break;
                    }
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
