using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RestaurantManagementSystem.DL;

namespace RestaurantManagementSystem.UI
{
    public partial class UpdateForm : UserControl
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        string imagePath = ""; // store the path of the image internally

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void ButtonEnter__Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }



        private void ClearForm()
        {
            textBoxCNIC.Clear();
            textBoxName.Clear();
            textBoxContact.Clear();
            textBoxEmail.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            pictureBox1.Image = null;
            imagePath = "";

            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            string cnic = textBoxCNIC.Text.Trim();

            if (cnic == "")
            {
                MessageBox.Show("Please enter CNIC.");
                return;
            }

            SqlConnection con = DatabaseHelper.GetConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Cashiers WHERE CNIC = @cnic", con);
            cmd.Parameters.AddWithValue("@cnic", cnic);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBoxName.Text = reader["Name"].ToString();
                textBoxContact.Text = reader["Contact"].ToString();
                textBoxEmail.Text = reader["Email"].ToString();
                textBoxUsername.Text = reader["Username"].ToString();
                textBoxPassword.Text = reader["Password"].ToString();

                imagePath = reader["PhotoPath"].ToString();

                if (File.Exists(imagePath))
                {
                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox1.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }

                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
            }
            else
            {
                MessageBox.Show("Cashier not found.");
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
            }

            reader.Close();
            con.Close();
        }

        private void buttonBrowseImage_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string cnic = textBoxCNIC.Text.Trim();

            SqlConnection con = DatabaseHelper.GetConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Cashiers SET Name=@name, Contact=@contact, Email=@email, Username=@username, Password=@password, PhotoPath=@photo WHERE CNIC=@cnic", con);

            cmd.Parameters.AddWithValue("@name", textBoxName.Text.Trim());
            cmd.Parameters.AddWithValue("@contact", textBoxContact.Text.Trim());
            cmd.Parameters.AddWithValue("@email", textBoxEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@username", textBoxUsername.Text.Trim());
            cmd.Parameters.AddWithValue("@password", textBoxPassword.Text.Trim());
            cmd.Parameters.AddWithValue("@photo", imagePath);
            cmd.Parameters.AddWithValue("@cnic", cnic);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Cashier updated successfully.");
            }
            else
            {
                MessageBox.Show("Update failed.");
            }

            con.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string cnic = textBoxCNIC.Text.Trim();

            SqlConnection con = DatabaseHelper.GetConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Cashiers WHERE CNIC=@cnic", con);
            cmd.Parameters.AddWithValue("@cnic", cnic);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Cashier deleted successfully.");

                if (File.Exists(imagePath))
                {
                    try
                    {
                        File.Delete(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Image not deleted: " + ex.Message);
                    }
                }

                ClearForm();
            }
            else
            {
                MessageBox.Show("Delete failed.");
            }

            con.Close();
        }
    }
}

