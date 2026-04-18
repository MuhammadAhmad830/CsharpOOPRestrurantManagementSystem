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

namespace RestaurantManagementSystem.UI
{
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void buttonTotally_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReportDL.ExecuteStoredProcedure("GetTotalRevenue");
        }

        private void buttonWeekly_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReportDL.ExecuteStoredProcedure("GetWeeklyRevenue");

        }

        private void buttonMonthly_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ReportDL.ExecuteStoredProcedure("GetMonthlyRevenue");


        }
    }
}

