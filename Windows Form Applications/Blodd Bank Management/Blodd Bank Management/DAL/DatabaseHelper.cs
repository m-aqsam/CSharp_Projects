// DAL/DatabaseHelper.cs
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BloodBank.DAL
{
    public class DatabaseHelper
    {
        private MySqlConnection GetConnection()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password='';database=bloodbank";
            return con;
        }

        public DataSet ExecuteQuery(string query)
        {
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void ExecuteNonQuery(string query)
        {
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Processed Successfully");
        }

        public bool ValidateUser(string username, string password)
        {
            MySqlConnection conn = GetConnection();
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return result > 0;
        }
    }
}
