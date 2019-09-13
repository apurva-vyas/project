using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LU.DataAccessLayer;
using LU.Watcher;
namespace LU.UserInterface
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            
            string username = username1.Text;
            string password = password1.Text;
            DataTable dt = DataAccess.Check_Login(username,password);
            
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                UI createobj = new UI();
                createobj.Show();

            }
            else
            {
                MessageBox.Show("Enter correct credential", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
    }
}
