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
    public partial class TagList : Form
    {
        int userId = 0;
        public TagList(int pUserId)
        {
            userId = pUserId;
            InitializeComponent();
        }

        private void TagList_Load(object sender, EventArgs e)
        {
            loadTags();
        }

        private void loadTags()
        {
            try
            {
                string query = "select * from Tag where UserId=" + userId;
                DBConnection db = new DBConnection(query);
               dataGridView1.DataSource= db.GetDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
