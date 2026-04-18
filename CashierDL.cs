using System.Data.SqlClient;
using System.Data;

namespace RestaurantManagementSystem.DL
{
    public class CashierDL
    {
        public static bool AddCashier(string name, string contact, string email, string cnic, string username, string password, string photoPath)
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO Cashiers (Name, Contact, Email, CNIC, Username, Password, PhotoPath) " +
                                   "VALUES (@name, @contact, @email, @cnic, @username, @password, @photo)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@cnic", cnic);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@photo", photoPath);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error adding cashier: " + ex.Message);
                return false;
            }
        }

        // 👇 Add this method to support viewing in DataGridView
        public static DataTable GetAllCashiers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT * FROM Cashiers";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(dt);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error loading cashiers: " + ex.Message);
            }
            return dt;
        }
        //public static DataTable Search()
        //{
        //    DataTable dt = new DataTable();
        //    using (SqlConnection conn = new SqlConnection("Data Source=PIRZADAHAROON\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True;Encrypt=False"))
        //    {
        //        string query = "SELECT Name, Contact, Email, CNIC, Username, Password, Status FROM Cashiers";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        adapter.Fill(dt);
        //    }
        //    return dt;
        //}
    }
}

