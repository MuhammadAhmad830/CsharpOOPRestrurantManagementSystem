using System;
using System.Windows.Forms;
using RestaurantManagementSystem.BL;
using RestaurantManagementSystem.DL;  // Make sure that ItemDL exists and is correctly referenced

namespace RestaurantManagementSystem.UI
{
    public partial class AddItem : UserControl
    {
        private ItemDL itemDL = new ItemDL();

        public AddItem()
        {
            InitializeComponent();

            btnSave.Click += btnSave_Click;
            btnClear.Click += btnClear_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textBoxItemName.Text.Trim();
            string category = textBox2.Text.Trim(); // Category is taken from the textBox2
            decimal price;
            int stock;
            decimal Discount;

            // Validate inputs
            if (name == "")
            {
                MessageBox.Show("Please enter item name.");
                return;
            }

            if (category == "")
            {
                MessageBox.Show("Please enter food category.");
                return;
            }

            if (!decimal.TryParse(textBox1.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            if (!int.TryParse(textBoxStock.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity.");
                return;
            }
            if (!decimal.TryParse(textBox4.Text, out Discount))
            {
                Discount = 0; // Default value if not provided
            }

            // Creating an ItemBL object with the fields provided
            Item item = new Item(name, price, category, stock, Discount);
            bool added = itemDL.AddItem(item);

            if (added)
            {
                MessageBox.Show("Item added successfully!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add item.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxItemName.Text.Trim();
            string category = textBox2.Text.Trim();
            decimal price;
            int stock;
            decimal Discount;

            // Validate inputs
            if (name == "")
            {
                MessageBox.Show("Please enter item name.");
                return;
            }

            if (category == "")
            {
                MessageBox.Show("Please enter food category.");
                return;
            }

            if (!decimal.TryParse(textBox1.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            if (!int.TryParse(textBoxStock.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity.");
                return;
            }
            if (!decimal.TryParse(textBox4.Text, out Discount))
            {
                Discount = 0; // Default value if not provided
            }

            // Creating an ItemBL object with the fields provided
            Item item = new Item(name, price, category, stock, Discount);

            // Update the item in the database
            bool updated = itemDL.UpdateItem(item);

            if (updated)
            {
                MessageBox.Show("Item updated successfully!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to update item. Make sure the item exists.");
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = textBoxItemName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter the name of the item to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool deleted = itemDL.DeleteItem(name);
                if (deleted)
                {
                    MessageBox.Show("Item deleted successfully.");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete item. Make sure the item exists.");
                }
            }
        }

        private void ClearFields()
        {
            textBoxItemName.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBoxStock.Text = "";
            textBox4.Text = "";



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

