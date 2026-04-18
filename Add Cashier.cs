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

namespace RestaurantManagementSystem
{
    public partial class Add_Cashier : UserControl
    {
        public Add_Cashier()
        {
            InitializeComponent();
        }
        string imagePath = "";


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Cashier_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName; // Store the path
                pictureBox1.ImageLocation = imagePath;
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string contact = textBoxContact.Text;
            string email = textBoxEmail.Text;
            string cnic = textBoxCNIC.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string photoPath = pictureBox1.ImageLocation;
            
            bool isSaved = CashierDL.AddCashier(name, contact, email, cnic, username, password, photoPath);

            if (isSaved)
            {
                MessageBox.Show("Cashier added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add cashier.");
            }
        }


    }
}

