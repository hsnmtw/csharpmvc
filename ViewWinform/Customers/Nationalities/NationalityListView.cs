using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLibrary.Customers;
using ControllerLibrary.Customers;


namespace ViewWinform.Customers.Nationalities {
    public partial class NationalityListView : UserControl //, BaseView<NationalityModel>
    {
        private NationalityController controller;

        public NationalityListView()
        {
            InitializeComponent();
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.controller = new NationalityController();
            Button1_Click(null, null);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Search_TextBox.Text = "%";
            DataTable table = controller.all();
            DataView view = new DataView(table);
            view.Sort = "Nationality_Desc";
            this.dataGridView1.DataSource = view;
        }

        private void Go_Button_Click(object sender, EventArgs e)
        {
            //var controller = new NationalityController();
            var table = controller.search(new NationalityModel() { Nationality_Code=Search_TextBox.Text }, "Nationality_Code".Split(','));
            var view = (from row in table orderby row.Nationality_Desc select row);
            this.dataGridView1.DataSource = view;
        }

        private void NationalityFormView1_OnSaveDeleteAction(object sender, EventArgs e) {
            Button1_Click(sender, e);
        }


        private void DataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e) {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            if (this.dataGridView1.SelectedRows.Count < 1) return;
            NationalityModel model = new NationalityModel();
            var row = dataGridView1.SelectedRows[0];
            model.Id                 = int.Parse(row.Cells["Id"].Value.ToString());
            model.Nationality_Code   = row.Cells["Nationality_Code"].Value.ToString();
            model.Nationality_Desc   = row.Cells["Nationality_Desc"].Value.ToString();
            model.Nationality_Arabic = row.Cells["Nationality_Arabic"].Value.ToString();
            
            this.nationalityFormView1.model = model;
        }
    }
}
