using System;
using System.Data.SqlClient;

namespace RestaurantManagementSystem.DL
{
    public static class DatabaseHelper
    {
        public static string ConnectionString
        {
            get
            {
                var connectionString = System.Configuration.ConfigurationManager
                    .ConnectionStrings["RestaurantDB"]?
                    .ConnectionString;

                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new InvalidOperationException(
                        "App.config mein 'RestaurantDB' connection string nahi mila.\n" +
                        "Name exactly 'RestaurantDB' hona chahiye.");
                }

                return connectionString;
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}