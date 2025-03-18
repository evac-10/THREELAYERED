using System;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    
    public class Data
    {
        private string connectionString = "Server=DESKTOP-KI3V701\\SQLEXPRESS;Database=Test;Trusted_Connection=True;";
        public DataTable GetStudents()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT StudentName FROM Students";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    con.Open();
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
