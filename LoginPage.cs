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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hardcoded Admin Login
            if (username == "admin" && password == "admin")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
                return;
            }

            // Check Database for Cashier Login
            try
            {
                using (System.Data.SqlClient.SqlConnection con = RestaurantManagementSystem.DL.DatabaseHelper.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM Cashiers WHERE Username = @Username AND Password = @Password";
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        CashierForm cashierForm = new CashierForm();
                        cashierForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}

