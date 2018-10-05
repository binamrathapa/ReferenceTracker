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
    public partial class AddBook : Form
    {
        public int UserId = 0;
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert into book values('"+txtBookName.Text+"','"+txtShortDescription.Text+"',"+UserId+")";
                DBConnection db = new DBConnection(query);
                
                db.ExecuteQuery();
                MessageBox.Show("Saved successfylly");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
