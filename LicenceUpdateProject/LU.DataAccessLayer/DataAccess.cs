using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace LU.DataAccessLayer
{
    public class DataAccess
    {
        public static DataTable Check_Login(string username, string password)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["siemensDbConStr1"].ConnectionString;
            //SqlConnection con = new SqlConnection();
            SqlConnection connection = new SqlConnection(connectionstring);
            ConnectionState state = connection.State;
            if (state == ConnectionState.Closed)
            {
                connection.Open();
            }
            if (connection != null)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Login where username='" + username + "' and password ='" + password + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            else{
                return null;
            }
            if (state == ConnectionState.Open)
            {
                connection.Close();
            }

        } 
    }
}
