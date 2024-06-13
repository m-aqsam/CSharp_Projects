using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Blodd_Bank_Management
{
    class Functions
    {

        public MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;port=3306;username=root;password='';database=bloodbank";
            return con;
        }

        public DataSet getData(String query) // Get Data From Database 
        {
            MySqlConnection conn = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData (String query) // Update , Delete and Insert Data
        {
            MySqlConnection conn = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText= query;    
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Processed Succesfully");

        }


    }
}
