using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace ViewWinform.Utils
{
    public partial class AdvancedCheckedListBox : UserControl
    {
        private DataTable source { get; set; }

        private Dictionary<string,bool> checkedStateList = new Dictionary<string, bool>();

        public ListViewItemCollection Items { get { return this.listView1.Items; } }
        public AdvancedCheckedListBox()
        {
            InitializeComponent();
        }

        public void setDataSource(DataTable dataTable)
        {
            this.source = dataTable;
            this.listView1.Columns.Clear();
            this.listView1.Items.Clear();
            foreach (DataRow row in source.Rows) { checkedStateList[row[0].ToString()] = false ; }
            this.refresh();
        }

        public void refresh()
        {

            foreach (ListViewItem item in listView1.Items)
            {
                this.checkedStateList[item.SubItems[0].Text] = item.Checked;
            }

            this.listView1.Items.Clear();
            int i = 0;
            foreach (string row in getFilteredRows())
            {
                this.listView1.Items.Add(row);
                this.setCheckedItem(i, this.checkedStateList[ this.listView1.Items[i].SubItems[0].Text ]);
                i++;
            }

        }

        public void setCheckedItem(int index, bool state)
        {
            this.listView1.Items[index].Checked = state;
            this.checkedStateList[this.listView1.Items[index].SubItems[0].Text] = state;
        }

        public bool getCheckedState(int index)
        {
            return this.listView1.Items[index].Checked;
        }

        public string getItemAtIndex(int index)
        {
            return this.listView1.Items[index].SubItems[0].Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

        public void setAll(bool is_checked)
        {
            foreach(ListViewItem item in listView1.Items)
            {
                item.Checked = is_checked;
                this.checkedStateList[item.SubItems[0].Text] = is_checked;
            }
        }

        public string[] getFilteredRows()
        {

            var query = from row in source.AsEnumerable()
                        where row.Field<object>(0).ToString().ToLower().Contains(this.textBox1.Text.ToLower())
                        select row[0].ToString();

            return query.ToArray<string>();
        }

        public List<string> getCheckedRows()
        {
            var query = from row in this.listView1.Items.Cast<ListViewItem>()
                        where row.Checked
                        select row.SubItems[0].Text;
            return query.ToList<string>();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //this.checkedStateList[ this.listView1.Items[e.Item.Index].SubItems[0].Text ] = e.Item.Checked;
        }
    }
}
