﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LU.DataAccessLayer;
using LU.BusinessLayer;
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
            try
            {

               string username = username1.Text;
                string password = password1.Text;
                int count = new DataAccess().CheckLogin(username, password);

                if (count > 0)
                {
                    if (username == "admin")
                    {
                        this.Hide();
                        UI createobj = new UI(username);
                        createobj.Show();
                    }
                    else
                    {
                        this.Hide();
                        User createobj = new User(username);
                        createobj.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Enter correct credential", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter correct credential" + ex);
            }

        }

        private void username1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
