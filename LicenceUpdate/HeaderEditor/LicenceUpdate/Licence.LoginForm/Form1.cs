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
using System.Configuration;

namespace Licence.LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
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
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Login where username='" + login_username_text.Text + "' and password ='" + login_password_text.Text + "'", connection);
               DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() =="1")
                {
                    this.Hide();
                    Dummy d = new Dummy();
                    d.Show();
                }
                else
                {
                    MessageBox.Show("Enter correct credential", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Database is Empty");
            }
            if (state == ConnectionState.Open)
            {
                connection.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
