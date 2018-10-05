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
    public partial class TagArticles : Form
    {
        public TagArticles()
        {
            InitializeComponent();
        }

        private void TagArticles_Load(object sender, EventArgs e)
        {
            string query = "select R.* from Reference R,Tag T where R.Title like  '%'+T.Text+'%'";
            DBConnection db = new DBConnection(query);
           
            DataTable dtTagArticles = db.GetDataTable();
            dataGridView1.DataSource = dtTagArticles;
            
        }
    }
}
