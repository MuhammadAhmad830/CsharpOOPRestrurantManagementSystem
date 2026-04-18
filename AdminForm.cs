


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.UI
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.Load += AdminForm_Load;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Form maximize fix
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;

            // Sab controls pehle hide karein
            addEditItemControl1.Visible = false;
            placeOrder1.Visible = false;
            inventory1.Visible = false;
            add_Cashier1.Visible = false;
            viewCashier1.Visible = false;
            updateForm1.Visible = false;
            reports1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            addEditItemControl1.Visible = true;
            placeOrder1.Visible = false;
            inventory1.Visible = false;
            add_Cashier1.Visible = false;
            viewCashier1.Visible = false;
            updateForm1.Visible = false;
            reports1.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e) { }

        private void placeOrder1_Load(object sender, EventArgs e) { }

        private void panelMain_Paint(object sender, PaintEventArgs e) { }

        private void panelLeft_Paint(object sender, PaintEventArgs e) { }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private void btnManageCashiers_Click(object sender, EventArgs e)
        {
            addEditItemControl1.Visible = false;
            placeOrder1.Visible = false;
            inventory1.Visible = false;
            add_Cashier1.Visible = true;
            viewCashier1.Visible = false;
            updateForm1.Visible = false;
            reports1.Visible = false;
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            addEditItemControl1.Visible = false;
            placeOrder1.Visible = false;
            inventory1.Visible = false;
            add_Cashier1.Visible = false;
            viewCashier1.Visible = false;
            updateForm1.Visible = false;
            reports1.Visible = true;
        }

        private void btnManageCategories_Click(object sender, EventArgs e) { }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            placeOrder1.Visible = true;
            addEditItemControl1.Visible = false;
            inventory1.Visible = false;
            add_Cashier1.Visible = false;
            viewCashier1.Visible = false;
            updateForm1.Visible = false;
            reports1.Visible = false;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e) { }

        private void lblTitle_Click(object sender, EventArgs e) { }

        private void panelTop_Paint(object sender, PaintEventArgs e) { }

        private void addEditItemControl1_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            placeOrder1.Visible = false;
            addEditItemControl1.Visible = false;
            inventory1.Visible = true;
            add_Cashier1.Visible = false;
            viewCashier1.Visible = false;
            updateForm1.Visible = false;
            reports1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewCashier1.Visible = true;
            placeOrder1.Visible = false;
            addEditItemControl1.Visible = false;
            inventory1.Visible = false;
            add_Cashier1.Visible = false;
            updateForm1.Visible = false;
            reports1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewCashier1.Visible = false;
            placeOrder1.Visible = false;
            addEditItemControl1.Visible = false;
            inventory1.Visible = false;
            add_Cashier1.Visible = false;
            updateForm1.Visible = true;
            reports1.Visible = false;
        }
    }
}