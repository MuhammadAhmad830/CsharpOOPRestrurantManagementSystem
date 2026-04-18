using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantManagementSystem.DL
{
    public class OrderDL
    {
        private static string connectionString = DatabaseHelper.ConnectionString;

        public static int SaveOrder(decimal totalAmount)
        {
            int orderId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Orders (TotalAmount) OUTPUT INSERTED.OrderID VALUES (@TotalAmount)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        orderId = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving order: " + ex.Message);
            }
            return orderId;
        }

        public static void SaveOrderDetail(int orderId, int itemId, int quantity, decimal price)
        {
            try
            {
                decimal subTotal = quantity * price;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO OrderDetails (OrderID, ItemID, Quantity, UnitPrice, SubTotal)
                                     VALUES (@OrderID, @ItemID, @Quantity, @UnitPrice, @SubTotal)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", orderId);
                        cmd.Parameters.AddWithValue("@ItemID", itemId);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@UnitPrice", price);
                        cmd.Parameters.AddWithValue("@SubTotal", subTotal);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving order detail: " + ex.Message);
            }
        }

        public static void DecreaseStock(int itemId, int quantity)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateRemainingStockQuery = "UPDATE Items SET RemainingStock = RemainingStock - @Quantity WHERE Id = @ItemId";

                    using (SqlCommand cmd = new SqlCommand(updateRemainingStockQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@itemID", itemId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error decreasing stock: " + ex.Message);
            }
        }

        public static int GetItemIdByName(string name)
        {
            int itemId = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id FROM Items WHERE Name = @Name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                itemId = Convert.ToInt32(reader["Id"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting item ID: " + ex.Message);
            }
            return itemId;
        }

        public static int GetRemainingStockByName(string itemName)
        {
            int stock = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT RemainingStock FROM Items WHERE Name = @Name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", itemName);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            stock = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting stock: " + ex.Message);
            }
            return stock;
        }
    }
}
