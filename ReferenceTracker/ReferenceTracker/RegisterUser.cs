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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*string query = "insert into [user] values('"+txtUserName.Text+"','"+txtPassword.Text+"','"+txtEmail.Text+"','"+txtFirstName.Text+"','"+txtLastName+"')";
                DBConnection db = new DBConnection(query);               
                db.ExecuteQuery();*/
                Helper h = new Helper();
                if (h.CheckEmail(txtEmail.Text))
                {
                    if (h.CheckPasswords(txtPassword.Text, txtConfirmPassword.Text))
                    {
                        UserService us = new UserService();
                        User user = new User();
                        user.UserName = txtUserName.Text;
                        user.Password = txtPassword.Text;
                        user.Email = txtEmail.Text;
                        user.FirstName = txtFirstName.Text;
                        user.LastName = txtLastName.Text;
                        us.SaveUser(user);
                        MessageBox.Show("User registered successfully");
                    }
                    else
                        MessageBox.Show("Passwords donot match");
                }
                else
                {
                    MessageBox.Show("Email is invalid");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
