using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagementSystem.DL;
using RestaurantManagementSystem.BL;


namespace RestaurantManagementSystem.UI
{
    public partial class ViewCashier : UserControl
    {
        public ViewCashier()
        {
            InitializeComponent();
        }

        private void ViewCashier_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CashierDL.GetAllCashiers();
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    string keyword = textBoxSearch.Text.Trim().ToLower();
        //    DataTable dt = CashierDL.Search();

        //    if (!string.IsNullOrEmpty(keyword))
        //    {
        //        DataView dv = dt.DefaultView;
        //        dv.RowFilter = $"Name LIKE '%{keyword}%' OR CategoryName LIKE '%{keyword}%'";
        //        dataGridView1.DataSource = dv;
        //    }
        //    else
        //    {
        //        dataGridView1.DataSource = dt;
        //    }
        //}
    }
}

