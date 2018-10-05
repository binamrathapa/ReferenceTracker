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
    public partial class AddTag : Form
    {
        int userId = 0;
        public AddTag(int pUserId)
        {
            userId = pUserId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into Tag values('" + txtTag.Text + "'," + userId + ")";
                DBConnection db = new DBConnection(query);
                db.ExecuteQuery();
                MessageBox.Show(txtTag.Text+" tagged successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
