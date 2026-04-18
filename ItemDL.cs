namespace RestaurantManagementSystem.DL
{
    using RestaurantManagementSystem.BL;
    using System.Collections.Generic;
    using System;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    using System.Data;

    public class ItemDL
    {
        private string connectionString = DatabaseHelper.ConnectionString;

        public bool AddItem(Item item)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string status = item.Stock > 0 ? "Available" : "Unavailable";
                    decimal discountedPrice = item.CalculateDiscountedPrice();

                    string query = "INSERT INTO Items (Name, OriginalPrice, DiscountPrice, CategoryName, Stock, Status, Discount) " +
                                   "VALUES (@Name, @OriginalPrice, @DiscountPrice, @CategoryName, @Stock, @Status, @Discount)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@Name", item.Name);
                    cmd.Parameters.AddWithValue("@OriginalPrice", item.OriginalPrice);
                    cmd.Parameters.AddWithValue("@DiscountPrice", discountedPrice);
                    cmd.Parameters.AddWithValue("@CategoryName", item.Category);
                    cmd.Parameters.AddWithValue("@Stock", item.Stock);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Discount", item.Discount);

                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message);
                return false;
            }
        }

        public bool DeleteItem(string name)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Items WHERE Name = @Name";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Name", name);

                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message);
                return false;
            }
        }

        public bool UpdateItem(Item item)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string status = item.Stock > 0 ? "Available" : "Unavailable";
                    decimal discountedPrice = item.CalculateDiscountedPrice();

                    string query = "UPDATE Items SET OriginalPrice = @OriginalPrice, DiscountPrice = @DiscountPrice, CategoryName = @CategoryName, Stock = @Stock, Status = @Status, Discount = @Discount " +
                                   "WHERE Name = @Name";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@Name", item.Name);
                    cmd.Parameters.AddWithValue("@OriginalPrice", item.OriginalPrice);
                    cmd.Parameters.AddWithValue("@DiscountPrice", discountedPrice);
                    cmd.Parameters.AddWithValue("@CategoryName", item.Category);
                    cmd.Parameters.AddWithValue("@Stock", item.Stock);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Discount", item.Discount);

                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating item: " + ex.Message);
                return false;
            }
        }

        public List<string> GetAllCategories()
        {
            List<string> categories = new List<string>();
            try
            {
                string query = "SELECT DISTINCT CategoryName FROM Items";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                categories.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
            return categories;
        }

        public List<Item> GetItemsByCategory(string category)
        {
            List<Item> items = new List<Item>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Items WHERE CategoryName = @Category";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Category", category);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader["Name"].ToString();
                                decimal price = Convert.ToDecimal(reader["OriginalPrice"]);
                                string categoryName = reader["CategoryName"].ToString();
                                int stock = Convert.ToInt32(reader["Stock"]);
                                decimal discount = Convert.ToDecimal(reader["Discount"]);

                                Item item = new Item(name, price, categoryName, stock, discount);
                                items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting items: " + ex.Message);
            }
            return items;
        }

        public static bool DecreaseStock(string itemName, int quantity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    string checkStockQuery = "SELECT Stock FROM Items WHERE Name = @Name";
                    using (SqlCommand checkCmd = new SqlCommand(checkStockQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Name", itemName);

                        object result = checkCmd.ExecuteScalar();
                        if (result == null) return false;

                        int currentStock = Convert.ToInt32(result);
                        if (currentStock < quantity) return false;
                    }

                    string updateStockQuery = "UPDATE Items SET Stock = Stock - @Quantity WHERE Name = @Name";
                    using (SqlCommand updateCmd = new SqlCommand(updateStockQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@Quantity", quantity);
                        updateCmd.Parameters.AddWithValue("@Name", itemName);
                        updateCmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error decreasing stock: " + ex.Message);
                return false;
            }
        }

        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Name, CategoryName, OriginalPrice, DiscountPrice, Stock, RemainingStock, Status FROM Items";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
            return dt;
        }

        public void InitializeRemainingStock()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Items SET RemainingStock = Stock WHERE RemainingStock IS NULL";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing remaining stock: " + ex.Message);
            }
        }
    }
}
