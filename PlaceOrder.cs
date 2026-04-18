using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using RestaurantManagementSystem.BL;
using RestaurantManagementSystem.DL;

namespace RestaurantManagementSystem.UI
{
    public partial class PlaceOrder : UserControl
    {
        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            LoadCategories();
            InitializeOrderGrid();
        }

        private void LoadCategories()
        {
            comboBoxCategory.Items.Clear();

            ItemDL itemDL = new ItemDL(); // Object banaya
            List<string> categories = itemDL.GetAllCategories(); // Make sure this returns List<string>
            foreach (string cat in categories)
            {
                comboBoxCategory.Items.Add(cat);
            }
        }
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxCategory.SelectedItem.ToString();

            ItemDL itemDL = new ItemDL();
            List<Item> items = itemDL.GetItemsByCategory(selectedCategory);

            comboBoxItem.Items.Clear();

            foreach (Item item in items)
            {
                comboBoxItem.Items.Add(item.Name); // Sirf name show karenge
            }
        }
        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemName = comboBoxItem.SelectedItem.ToString();
            string selectedCategory = comboBoxCategory.SelectedItem.ToString();

            // Get the selected item from DB
            ItemDL itemDL = new ItemDL();
            List<Item> items = itemDL.GetItemsByCategory(selectedCategory);
            Item selectedItem = null;

            foreach (Item item in items)
            {
                if (item.Name == selectedItemName)
                {
                    selectedItem = item;
                    break;
                }
            }

            if (selectedItem != null)
            {
                textBoxTotal.Text = selectedItem.OriginalPrice.ToString("0.00");
                textBoxtextBoxDiscount.Text = selectedItem.Discount.ToString("0.00");
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Validate selections
                if (comboBoxItem.SelectedItem == null)
                {
                    MessageBox.Show("Please select an item.");
                    return;
                }

                if (comboBoxCategory.SelectedItem == null)
                {
                    MessageBox.Show("Please select a category.");
                    return;
                }

                // Step 2: Read values
                string itemName = comboBoxItem.SelectedItem.ToString();
                string category = comboBoxCategory.SelectedItem.ToString();
                
                int quantity = (int)numericUpDown1.Value;

                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than 0.");
                    return;
                }


                // 🔴 Step 2.1: Check Remaining Stock from database
                int remainingStock = OrderDL.GetRemainingStockByName(itemName); // You'll define this method in DL
                if (remainingStock <= 0)
                {
                    MessageBox.Show($"Item '{itemName}' is out of stock!");
                    return;
                }

                if (quantity > remainingStock)
                {
                    MessageBox.Show($"Only {remainingStock} items available for '{itemName}'.");
                    return;
                }

                // Step 3: Parse price
                if (!decimal.TryParse(textBoxTotal.Text, out decimal price))
                {
                    MessageBox.Show("Invalid price.");
                    return;
                }

                // Step 4: Read discount manually entered by cashier
                decimal discountPercent = numericUpDown2.Value;

                // Step 5: Calculate total and final price
                decimal totalPrice = quantity * price;
                decimal discountAmount = (totalPrice * discountPercent) / 100;
                decimal finalPrice = totalPrice - discountAmount;

                // Step 6: Add row to DataGridView
                dataGridViewOrder.Rows.Add(
                    itemName,
                    category,
                    quantity,
                    price.ToString("0.00"),
                    discountPercent.ToString("0.00"),
                    finalPrice.ToString("0.00")
                );

                // Step 7: Update total discount and total price
                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        //private void buttonPlaceOrder_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (dataGridViewOrder.Rows.Count == 0)
        //        {
        //            MessageBox.Show("Please add at least one item to place an order.");
        //            return;
        //        }

        //        // Step 1: Calculate total amount
        //        decimal totalAmount = 0;
        //        foreach (DataGridViewRow row in dataGridViewOrder.Rows)
        //        {
        //            if (row.Cells[5].Value != null)
        //            {
        //                decimal rowTotal;
        //                if (decimal.TryParse(row.Cells[5].Value.ToString(), out rowTotal))
        //                {
        //                    totalAmount += rowTotal;
        //                }
        //            }
        //        }

        //        // Step 2: Insert into Orders table
        //        int orderId = 0;
        //        using (SqlConnection conn = new SqlConnection("Data Source=PIRZADAHAROON\\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False"))
        //        {
        //            conn.Open();

        //            SqlCommand cmdOrder = new SqlCommand("INSERT INTO Orders (OrderDate, TotalAmount) OUTPUT INSERTED.OrderID VALUES (GETDATE(), @total)", conn);
        //            cmdOrder.Parameters.AddWithValue("@total", totalAmount);
        //            orderId = (int)cmdOrder.ExecuteScalar(); // Get newly inserted OrderID

        //            // Step 3: Insert each item into OrderDetails and update stock
        //            foreach (DataGridViewRow row in dataGridViewOrder.Rows)
        //            {
        //                string itemName = row.Cells[0].Value.ToString();
        //                int quantity = int.Parse(row.Cells[2].Value.ToString());
        //                decimal unitPrice = decimal.Parse(row.Cells[3].Value.ToString());
        //                decimal subtotal = decimal.Parse(row.Cells[5].Value.ToString());

        //                // Get ItemID and current stock
        //                SqlCommand getItem = new SqlCommand("SELECT Id, Stock FROM Items WHERE Name = @name", conn);
        //                getItem.Parameters.AddWithValue("@name", itemName);
        //                SqlDataReader reader = getItem.ExecuteReader();

        //                int itemId = 0;
        //                int currentStock = 0;

        //                if (reader.Read())
        //                {
        //                    itemId = (int)reader["Id"];
        //                    currentStock = (int)reader["Stock"];
        //                }
        //                reader.Close();

        //                // Step 4: Insert into OrderDetails
        //                SqlCommand cmdDetail = new SqlCommand("INSERT INTO OrderDetails (OrderID, ItemID, Quantity, UnitPrice, SubTotal) VALUES (@oid, @iid, @qty, @price, @sub)", conn);
        //                cmdDetail.Parameters.AddWithValue("@oid", orderId);
        //                cmdDetail.Parameters.AddWithValue("@iid", itemId);
        //                cmdDetail.Parameters.AddWithValue("@qty", quantity);
        //                cmdDetail.Parameters.AddWithValue("@price", unitPrice);
        //                cmdDetail.Parameters.AddWithValue("@sub", subtotal);
        //                cmdDetail.ExecuteNonQuery();

        //                // Step 5: Decrease stock
        //                int newStock = currentStock - quantity;
        //                SqlCommand updateStock = new SqlCommand("UPDATE Items SET Stock = @stock WHERE Id = @id", conn);
        //                updateStock.Parameters.AddWithValue("@stock", newStock);
        //                updateStock.Parameters.AddWithValue("@id", itemId);
        //                updateStock.ExecuteNonQuery();
        //            }

        //            conn.Close();
        //        }

        //        // Clear everything
        //        dataGridViewOrder.Rows.Clear();
        //        UpdateTotal();
        //        MessageBox.Show("Order placed successfully!");

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error while placing order: " + ex.Message);
        //    }
        //}



        private void UpdateTotal()
        {
            decimal totalBill = 0;
            decimal totalDiscount = 0;

            foreach (DataGridViewRow row in dataGridViewOrder.Rows)
            {
                if (row.IsNewRow || row.Cells[2].Value == null || row.Cells[3].Value == null || row.Cells[4].Value == null) continue;

                decimal quantity = Convert.ToDecimal(row.Cells[2].Value);
                decimal price = Convert.ToDecimal(row.Cells[3].Value);
                decimal discountPercent = Convert.ToDecimal(row.Cells[4].Value);

                decimal itemTotal = quantity * price;
                decimal itemDiscount = (itemTotal * discountPercent) / 100;

                totalBill += itemTotal;
                totalDiscount += itemDiscount;
            }

            // Show values
            textBoxTotal.Text = totalBill.ToString("0.00");
            textBoxtextBoxDiscount.Text = totalDiscount.ToString("0.00");
            textBoxGrandTotal.Text = (totalBill - totalDiscount).ToString("0.00");
        }


        private void InitializeOrderGrid()
        {
            dataGridViewOrder.Columns.Clear();
            dataGridViewOrder.Columns.Add("ItemName", "Item Name");
            dataGridViewOrder.Columns.Add("Category", "Category");
            dataGridViewOrder.Columns.Add("Quantity", "Quantity");
            dataGridViewOrder.Columns.Add("Price", "Price");
            dataGridViewOrder.Columns.Add("Discount", "Discount (%)");
            dataGridViewOrder.Columns.Add("DiscountPrice", "Discounted Price");
        }
        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                decimal total = 0;

                // Calculate total from grid
                foreach (DataGridViewRow row in dataGridViewOrder.Rows)
                {
                    if (row.IsNewRow || row.Cells[5].Value == null) continue;
                    decimal rowTotal = Convert.ToDecimal(row.Cells[5].Value);
                    total += rowTotal;
                }

                // Save main order
                int orderId = OrderDL.SaveOrder(total);

                // Save each item
                foreach (DataGridViewRow row in dataGridViewOrder.Rows)
                {
                    if (row.IsNewRow || row.Cells[0].Value == null) continue;
                    string itemName = row.Cells[0].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells[2].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells[3].Value);

                    // Get item ID by name (you should create this helper in ItemDL)
                   // OrderDL order = new OrderDL();
                    int itemId = OrderDL.GetItemIdByName(itemName);

                    // Save details and update stock
                    OrderDL.SaveOrderDetail(orderId, itemId, quantity, unitPrice);
                    OrderDL.DecreaseStock(itemId, quantity);
                }

                MessageBox.Show("Order placed successfully!");
                dataGridViewOrder.Rows.Clear();
                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message);
            }
        }










        //private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void itemsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewOrder.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridViewOrder.Rows.Remove(row);
                    }
                }

                UpdateTotal(); // Recalculate total after removal
            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }
        }


    }
}

