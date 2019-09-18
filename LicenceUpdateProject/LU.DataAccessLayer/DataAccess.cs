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
        public int CheckLogin(string username, string password)
        {
            
            string connectionstring = null;
            SqlConnection connection = null;
            SqlCommand command = null;
            string query = null;
            int count = 0;
            try
            {
                connectionstring = ConfigurationManager.ConnectionStrings["siemensDbConStr1"].ConnectionString;
                query = ConfigurationManager.AppSettings["AuthenticateUserQuery"];
                connection = new SqlConnection(connectionstring);
                if (connection != null)
                {
                    command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = query;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@uname", username);
                    command.Parameters.AddWithValue("@pwd", password);


                    connection.Open();
                    count = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return count;
        }
    }
}
