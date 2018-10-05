using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenceTracker
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*string query = "select * from [User] where username='" + txtUserName.Text + "' and password='" + txtPassword.Text + "'";
                DBConnection db = new DBConnection(query);
               
                DataTable dt = db.GetDataTable();*/
                UserService us = new UserService();
              int userId=  us.GetLoginUserID(txtUserName.Text, txtPassword.Text);
                if (userId > 0)
                {
                    this.Hide();
                    Dashboard h = new Dashboard();
                    h.UserId = userId;
                    h.Show();
                    
                }
                else
                {
                    MessageBox.Show("Username or password incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();
        }
    }
}
