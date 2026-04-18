using System;
using System.Data;
using System.Windows.Forms;
using RestaurantManagementSystem.DL; // ✅ Include your DL namespace

namespace RestaurantManagementSystem.UI
{
    public partial class inventory : UserControl
    {
        public inventory()
        {
            InitializeComponent();
        }

        ItemDL itemDL = new ItemDL();

        private void inventory_Load(object sender, EventArgs e)
        {
            itemDL.InitializeRemainingStock();
            dataGridViewOrder.DataSource = itemDL.Select();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text.Trim().ToLower();
            DataTable dt = itemDL.Select();

            if (!string.IsNullOrEmpty(keyword))
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Name LIKE '%{keyword}%' OR CategoryName LIKE '%{keyword}%'";
                dataGridViewOrder.DataSource = dv;
            }
            else
            {
                dataGridViewOrder.DataSource = dt;
            }
        }

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: add logic if needed when a cell is clicked
        }

        private void restaurantDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

