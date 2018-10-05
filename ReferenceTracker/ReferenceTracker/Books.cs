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
    public partial class Books : Form
    {
        public int UserId = 0;
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from Book where UserId="+UserId;
                DBConnection db = new DBConnection(query);
               
                DataTable dtBooks = db.GetDataTable();
                dataGridView1.DataSource = dtBooks;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
